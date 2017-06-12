using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace PipCalculator
{
    public partial class MainPanel : Form
    {
        public static char[] VALID_INPUTS;
        private int pips;

        public MainPanel()
        {
            //valid char values that can be passed.
            VALID_INPUTS = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '\b' };

            InitializeComponent();
            //add Event Handlers for KeyPress events
            pipBox.KeyPress += pipBox_KeyPress;
            goalBox.KeyPress += goalBox_KeyPress;
            tickBox.KeyPress += tickBox_KeyPress;

            pips = 0;
            currentDatePercent(); //Initialize Progress Bar.

            //sets the default icon
            Icon = Icon.ExtractAssociatedIcon(System.Reflection.Assembly.GetExecutingAssembly().Location);
        }

        /// <summary>
        /// Identifies if key input is an integer or backspace
        /// </summary>
        /// <param name="text">current textBox text</param>
        /// <param name="key">char key being handled in the KeyPress Event</param>
        /// <param name="maxInt">Max Int value that we want the user to be able to enter</param>
        /// <returns></returns>
        private bool isValidInput(string text, char key, int maxInt)
        {
            if (VALID_INPUTS.Contains(key))
            {
                if (key == (char)8)
                    return true;
                int currentInt = Int32.Parse(text + key);
                if (currentInt <= maxInt)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Determines if the goal time will elapse over WvW reset time.
        /// </summary>
        private void computeTime()
        {
            if (pips > 0 && tickBox.Text.Length > 0)
            {
                //Makes sure we don't divide by 0
                if (Int32.Parse(tickBox.Text) == 0)
                    return;
                //calculate number of ticks required based off number of pips and pips per tick
                int numTicks = pips / Int32.Parse(tickBox.Text);
                //rounds up to next full tick int value since you cant recieve partial ticks
                if (pips % Int32.Parse(tickBox.Text) > 0)
                {
                    numTicks += 1;
                }

                //Create a timespan off numTicks and 5 min per tick
                TimeSpan span = new TimeSpan(0, numTicks * 5, 0);
                //set to eastern time zone
                DateTime currentTime = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.UtcNow, "Eastern Standard Time");
                //Create a DateTime off of the user's Current Time with the ticks time added to it
                DateTime goalTime = currentTime.Add(span);

                //display information
                goalDateLabel.Text = goalTime.ToShortDateString();
                goalTimeLabel.Text = goalTime.ToShortTimeString();
                timeLabel.Text = span.ToString();
                if(isDoable(goalTime) == true)
                {
                    resetLabel.Text = "Yes";
                    resetLabel.ForeColor = Color.Green;
                }
                else
                {
                    resetLabel.Text = "No";
                    resetLabel.ForeColor = Color.Red;
                }
                    
            }
        }

        /// <summary>
        /// Uses a 0 to 100 scale for progress through a week and gauge how much of a given week has passed
        /// </summary>
        /// <returns></returns>
        private double currentDatePercent()
        {
            DateTime currentTime = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.UtcNow, "Eastern Standard Time");
            double currentSeconds = currentTime.Second + (currentTime.Minute * 60) + (currentTime.Hour * 3600);
            double time = 0;
            switch (currentTime.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    time = 2;
                    break;
                case DayOfWeek.Tuesday:
                    time = 3;
                    break;
                case DayOfWeek.Wednesday:
                    time = 4;
                    break;
                case DayOfWeek.Thursday:
                    time = 5;
                    break;
                case DayOfWeek.Friday:
                    time = 6;
                    break;
                case DayOfWeek.Saturday:
                    time = 0;
                    break;
                case DayOfWeek.Sunday:
                    time = 1;
                    break;
            }

            //if percent of Day is < 0 it means that it's the previous day (7200 adjustment is 2 hour adjustment back)
            //wvw reset at 10 pm east (I need to add some handler for daylight savings.
            //It's a 2-3 hour adjustment because reset is 2-3 hours before saturday starts and thos 0 is at saturday
            //and the adjustment is -2 to -3 hours
            double percentOfDay;
            if (TimeZoneInfo.Local.IsDaylightSavingTime(currentTime))
                percentOfDay = (currentSeconds - 7200) / 86400;
            else
            {
                percentOfDay = (currentSeconds - 10800) / 86400;
            }
            if (percentOfDay < 0)
            {
                if (time > 0)
                    time += percentOfDay;
                else
                    time = 6+percentOfDay;
            }
            else
                time += percentOfDay;
            double progressToReset = 100 * time / 7;
            
            //sets the progress bar size based off of current time through the week's reset
            resetBar.Value = (int)progressToReset;

            return progressToReset;
        }

        /// <summary>
        /// Used to calculate if a given number of pips before reset is doable.
        /// </summary>
        /// <param name="currentTime">takes the goal time to see if it's before or after wvw reset</param>
        /// <returns></returns>
        private bool isDoable(DateTime currentTime)
        {
            double currentSeconds = currentTime.Second + (currentTime.Minute * 60) + (currentTime.Hour * 3600);
            double time = 0;
            switch (currentTime.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    time = 2;
                    break;
                case DayOfWeek.Tuesday:
                    time = 3;
                    break;
                case DayOfWeek.Wednesday:
                    time = 4;
                    break;
                case DayOfWeek.Thursday:
                    time = 5;
                    break;
                case DayOfWeek.Friday:
                    time = 6;
                    break;
                case DayOfWeek.Saturday:
                    time = 0;
                    break;
                case DayOfWeek.Sunday:
                    time = 1;
                    break;
            }

            double percentOfDay = (currentSeconds - 7200) / 86400;
            //if there is overflow over reset then it means the time constraints wont be reached
            time += percentOfDay;
            double progressToReset = 100 * time / 7;

            //resetLabel.Text = progressToReset.ToString();
            if (currentDatePercent() > progressToReset)
                return false;
            return true;
        }

        //use helper methods to handle keypresses
        private void tickBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isValidInput(tickBox.Text, e.KeyChar, 17) == false)
            {
                e.Handled = true;
            }
            
            //computeTime();
        }

        private void pipBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isValidInput(pipBox.Text, e.KeyChar, 1450) == false)
            {
                e.Handled = true;
            }
        }

        private void goalBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isValidInput(goalBox.Text, e.KeyChar, 1450) == false)
            {
                e.Handled = true;
            }
        }

        //Use TextChange Events to update calculated values.
        //I do this in a seperate event from KeyPress since KeyPress will not concatenate the box text
        //until after the key press event has been asserted as false.
        private void pipBox_TextChanged(object sender, EventArgs e)
        {
            if (goalBox.Text.Length > 0 && pipBox.Text.Length > 0)
            {
                pips = Int32.Parse(goalBox.Text) - Int32.Parse(pipBox.Text);
                pipLabel.Text = pips.ToString();
            }

            computeTime();
        }

        private void goalBox_TextChanged(object sender, EventArgs e)
        {
            if (pipBox.Text.Length > 0 && goalBox.Text.Length > 0)
            {
                pips = Int32.Parse(goalBox.Text) - Int32.Parse(pipBox.Text);
                pipLabel.Text = pips.ToString();
            }

            computeTime();
        }

        private void tickBox_TextChanged(object sender, EventArgs e)
        {
            computeTime();
        }
    }
}
