namespace PCBreakTimer
{
    partial class SettingsForm
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
            this.CancelSettingsButton = new System.Windows.Forms.Button();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.LunchTimeTextBox = new System.Windows.Forms.TextBox();
            this.WorkDayTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AddTimeTextBox = new System.Windows.Forms.TextBox();
            this.MaxTimeTextBox = new System.Windows.Forms.TextBox();
            this.WinXPosTextBox = new System.Windows.Forms.TextBox();
            this.WinYPosTextBox = new System.Windows.Forms.TextBox();
            this.PopupMessageCheckBox = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.StartMinimizedCheckBox = new System.Windows.Forms.CheckBox();
            this.useWorkingPatternCheckBox = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.workingPatternTB = new System.Windows.Forms.TextBox();
            this.lunchPatternTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CancelSettingsButton
            // 
            this.CancelSettingsButton.Location = new System.Drawing.Point(108, 310);
            this.CancelSettingsButton.Name = "CancelSettingsButton";
            this.CancelSettingsButton.Size = new System.Drawing.Size(75, 23);
            this.CancelSettingsButton.TabIndex = 0;
            this.CancelSettingsButton.Text = "Cancel";
            this.CancelSettingsButton.UseVisualStyleBackColor = true;
            this.CancelSettingsButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(190, 310);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(75, 23);
            this.ApplyButton.TabIndex = 1;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // LunchTimeTextBox
            // 
            this.LunchTimeTextBox.Location = new System.Drawing.Point(111, 14);
            this.LunchTimeTextBox.Name = "LunchTimeTextBox";
            this.LunchTimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.LunchTimeTextBox.TabIndex = 3;
            // 
            // WorkDayTextBox
            // 
            this.WorkDayTextBox.Location = new System.Drawing.Point(111, 40);
            this.WorkDayTextBox.Name = "WorkDayTextBox";
            this.WorkDayTextBox.Size = new System.Drawing.Size(100, 20);
            this.WorkDayTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lunch Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Work Day";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Add Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Window X Position";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Window Y Position";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Popup Messages";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Default Max Time";
            // 
            // AddTimeTextBox
            // 
            this.AddTimeTextBox.Location = new System.Drawing.Point(111, 67);
            this.AddTimeTextBox.Name = "AddTimeTextBox";
            this.AddTimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.AddTimeTextBox.TabIndex = 12;
            // 
            // MaxTimeTextBox
            // 
            this.MaxTimeTextBox.Location = new System.Drawing.Point(111, 93);
            this.MaxTimeTextBox.Name = "MaxTimeTextBox";
            this.MaxTimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.MaxTimeTextBox.TabIndex = 13;
            // 
            // WinXPosTextBox
            // 
            this.WinXPosTextBox.Location = new System.Drawing.Point(111, 118);
            this.WinXPosTextBox.Name = "WinXPosTextBox";
            this.WinXPosTextBox.Size = new System.Drawing.Size(100, 20);
            this.WinXPosTextBox.TabIndex = 14;
            // 
            // WinYPosTextBox
            // 
            this.WinYPosTextBox.Location = new System.Drawing.Point(111, 147);
            this.WinYPosTextBox.Name = "WinYPosTextBox";
            this.WinYPosTextBox.Size = new System.Drawing.Size(100, 20);
            this.WinYPosTextBox.TabIndex = 15;
            // 
            // PopupMessageCheckBox
            // 
            this.PopupMessageCheckBox.AutoSize = true;
            this.PopupMessageCheckBox.Checked = true;
            this.PopupMessageCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PopupMessageCheckBox.Location = new System.Drawing.Point(122, 237);
            this.PopupMessageCheckBox.Name = "PopupMessageCheckBox";
            this.PopupMessageCheckBox.Size = new System.Drawing.Size(15, 14);
            this.PopupMessageCheckBox.TabIndex = 16;
            this.PopupMessageCheckBox.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Start Minimized";
            // 
            // StartMinimizedCheckBox
            // 
            this.StartMinimizedCheckBox.AutoSize = true;
            this.StartMinimizedCheckBox.Location = new System.Drawing.Point(122, 261);
            this.StartMinimizedCheckBox.Name = "StartMinimizedCheckBox";
            this.StartMinimizedCheckBox.Size = new System.Drawing.Size(15, 14);
            this.StartMinimizedCheckBox.TabIndex = 18;
            this.StartMinimizedCheckBox.UseVisualStyleBackColor = true;
            // 
            // useWorkingPatternCheckBox
            // 
            this.useWorkingPatternCheckBox.AutoSize = true;
            this.useWorkingPatternCheckBox.Location = new System.Drawing.Point(122, 286);
            this.useWorkingPatternCheckBox.Name = "useWorkingPatternCheckBox";
            this.useWorkingPatternCheckBox.Size = new System.Drawing.Size(15, 14);
            this.useWorkingPatternCheckBox.TabIndex = 19;
            this.useWorkingPatternCheckBox.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 287);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "User Working Patterns";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(2, 179);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Working Pattern";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(2, 206);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Lunch Pattern";
            // 
            // workingPatternTB
            // 
            this.workingPatternTB.Location = new System.Drawing.Point(111, 176);
            this.workingPatternTB.Name = "workingPatternTB";
            this.workingPatternTB.Size = new System.Drawing.Size(100, 20);
            this.workingPatternTB.TabIndex = 23;
            // 
            // lunchPatternTB
            // 
            this.lunchPatternTB.Location = new System.Drawing.Point(111, 203);
            this.lunchPatternTB.Name = "lunchPatternTB";
            this.lunchPatternTB.Size = new System.Drawing.Size(100, 20);
            this.lunchPatternTB.TabIndex = 24;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 345);
            this.ControlBox = false;
            this.Controls.Add(this.lunchPatternTB);
            this.Controls.Add(this.workingPatternTB);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.useWorkingPatternCheckBox);
            this.Controls.Add(this.StartMinimizedCheckBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.PopupMessageCheckBox);
            this.Controls.Add(this.WinYPosTextBox);
            this.Controls.Add(this.WinXPosTextBox);
            this.Controls.Add(this.MaxTimeTextBox);
            this.Controls.Add(this.AddTimeTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WorkDayTextBox);
            this.Controls.Add(this.LunchTimeTextBox);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.CancelSettingsButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelSettingsButton;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.TextBox LunchTimeTextBox;
        private System.Windows.Forms.TextBox WorkDayTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox AddTimeTextBox;
        private System.Windows.Forms.TextBox MaxTimeTextBox;
        private System.Windows.Forms.TextBox WinXPosTextBox;
        private System.Windows.Forms.TextBox WinYPosTextBox;
        private System.Windows.Forms.CheckBox PopupMessageCheckBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox StartMinimizedCheckBox;
        private System.Windows.Forms.CheckBox useWorkingPatternCheckBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox workingPatternTB;
        private System.Windows.Forms.TextBox lunchPatternTB;
    }
}