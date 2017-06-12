namespace PipCalculator
{
    partial class MainPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPanel));
            this.pipBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.goalBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.pipLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tickBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.goalDateLabel = new System.Windows.Forms.Label();
            this.goalTimeLabel = new System.Windows.Forms.Label();
            this.resetLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.resetBar = new System.Windows.Forms.ProgressBar();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pipBox
            // 
            this.pipBox.Location = new System.Drawing.Point(94, 12);
            this.pipBox.Name = "pipBox";
            this.pipBox.Size = new System.Drawing.Size(36, 20);
            this.pipBox.TabIndex = 0;
            this.pipBox.TextChanged += new System.EventHandler(this.pipBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current Pips";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "max 1450";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Goal";
            // 
            // goalBox
            // 
            this.goalBox.Location = new System.Drawing.Point(94, 38);
            this.goalBox.Name = "goalBox";
            this.goalBox.Size = new System.Drawing.Size(36, 20);
            this.goalBox.TabIndex = 4;
            this.goalBox.TextChanged += new System.EventHandler(this.goalBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "max 1450";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Time Remaining:";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(98, 107);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(13, 13);
            this.timeLabel.TabIndex = 7;
            this.timeLabel.Text = "0";
            // 
            // pipLabel
            // 
            this.pipLabel.AutoSize = true;
            this.pipLabel.Location = new System.Drawing.Point(98, 94);
            this.pipLabel.Name = "pipLabel";
            this.pipLabel.Size = new System.Drawing.Size(13, 13);
            this.pipLabel.TabIndex = 9;
            this.pipLabel.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Pips Remaining:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Pips per Tick";
            // 
            // tickBox
            // 
            this.tickBox.Location = new System.Drawing.Point(94, 65);
            this.tickBox.Name = "tickBox";
            this.tickBox.Size = new System.Drawing.Size(36, 20);
            this.tickBox.TabIndex = 11;
            this.tickBox.TextChanged += new System.EventHandler(this.tickBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(137, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "max 17";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Time Estimate:";
            // 
            // goalDateLabel
            // 
            this.goalDateLabel.AutoSize = true;
            this.goalDateLabel.Location = new System.Drawing.Point(98, 120);
            this.goalDateLabel.Name = "goalDateLabel";
            this.goalDateLabel.Size = new System.Drawing.Size(13, 13);
            this.goalDateLabel.TabIndex = 14;
            this.goalDateLabel.Text = "0";
            // 
            // goalTimeLabel
            // 
            this.goalTimeLabel.AutoSize = true;
            this.goalTimeLabel.Location = new System.Drawing.Point(98, 133);
            this.goalTimeLabel.Name = "goalTimeLabel";
            this.goalTimeLabel.Size = new System.Drawing.Size(13, 13);
            this.goalTimeLabel.TabIndex = 15;
            this.goalTimeLabel.Text = "0";
            // 
            // resetLabel
            // 
            this.resetLabel.AutoSize = true;
            this.resetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetLabel.Location = new System.Drawing.Point(92, 159);
            this.resetLabel.Name = "resetLabel";
            this.resetLabel.Size = new System.Drawing.Size(100, 31);
            this.resetLabel.TabIndex = 16;
            this.resetLabel.Text = "Wowie";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(47, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Doable:";
            // 
            // resetBar
            // 
            this.resetBar.Location = new System.Drawing.Point(9, 235);
            this.resetBar.Name = "resetBar";
            this.resetBar.Size = new System.Drawing.Size(183, 23);
            this.resetBar.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 219);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(142, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Time Passed in WvW Week";
            // 
            // MainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(199, 270);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.resetBar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.resetLabel);
            this.Controls.Add(this.goalTimeLabel);
            this.Controls.Add(this.goalDateLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tickBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pipLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.goalBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pipBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPanel";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pipBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox goalBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label pipLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tickBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label goalDateLabel;
        private System.Windows.Forms.Label goalTimeLabel;
        private System.Windows.Forms.Label resetLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ProgressBar resetBar;
        private System.Windows.Forms.Label label11;
    }
}

