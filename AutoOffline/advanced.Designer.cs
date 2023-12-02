namespace AutoOffline
{
    partial class advanced
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
            components = new System.ComponentModel.Container();
            buttonFNSH = new Button();
            labelCdown = new Label();
            labelErrorMessage = new Label();
            labelError = new Label();
            timerAdv = new System.Windows.Forms.Timer(components);
            DatePicker1 = new DatePicker();
            dateOn = new Label();
            numUpDownHr = new NumUpDown();
            numUpDownMin = new NumUpDown();
            numUpDownSec = new NumUpDown();
            SuspendLayout();
            // 
            // buttonFNSH
            // 
            buttonFNSH.BackColor = Color.FromArgb(130, 109, 178);
            buttonFNSH.FlatStyle = FlatStyle.Flat;
            buttonFNSH.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonFNSH.ForeColor = Color.White;
            buttonFNSH.Location = new Point(420, 169);
            buttonFNSH.Name = "buttonFNSH";
            buttonFNSH.Size = new Size(160, 80);
            buttonFNSH.TabIndex = 5;
            buttonFNSH.Text = "Start Shutdown";
            buttonFNSH.UseVisualStyleBackColor = false;
            buttonFNSH.Click += buttonFNSH_Click;
            // 
            // labelCdown
            // 
            labelCdown.AutoSize = true;
            labelCdown.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelCdown.Location = new Point(31, 9);
            labelCdown.Name = "labelCdown";
            labelCdown.Size = new Size(77, 23);
            labelCdown.TabIndex = 16;
            labelCdown.Text = "label1";
            labelCdown.Visible = false;
            // 
            // labelErrorMessage
            // 
            labelErrorMessage.AutoSize = true;
            labelErrorMessage.BackColor = Color.Red;
            labelErrorMessage.Font = new Font("Verdana", 15F, FontStyle.Bold, GraphicsUnit.Point);
            labelErrorMessage.ForeColor = Color.White;
            labelErrorMessage.Location = new Point(405, 282);
            labelErrorMessage.Name = "labelErrorMessage";
            labelErrorMessage.Size = new Size(191, 50);
            labelErrorMessage.TabIndex = 17;
            labelErrorMessage.Text = "Time cannot be \r\nin the past\r\n";
            labelErrorMessage.TextAlign = ContentAlignment.MiddleCenter;
            labelErrorMessage.Visible = false;
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.BackColor = Color.Red;
            labelError.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelError.ForeColor = Color.White;
            labelError.Location = new Point(461, 257);
            labelError.Name = "labelError";
            labelError.RightToLeft = RightToLeft.No;
            labelError.Size = new Size(78, 25);
            labelError.TabIndex = 18;
            labelError.Text = "Error:";
            labelError.TextAlign = ContentAlignment.MiddleCenter;
            labelError.Visible = false;
            // 
            // timerAdv
            // 
            timerAdv.Enabled = true;
            timerAdv.Interval = 1000;
            timerAdv.Tick += timerAdv_Tick_1;
            // 
            // DatePicker1
            // 
            DatePicker1.BorderColor = Color.MediumVioletRed;
            DatePicker1.BorderSize = 0;
            DatePicker1.CalendarFont = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            DatePicker1.CalendarForeColor = Color.White;
            DatePicker1.CalendarMonthBackground = Color.White;
            DatePicker1.CalendarTitleBackColor = Color.White;
            DatePicker1.CalendarTitleForeColor = Color.White;
            DatePicker1.CalendarTrailingForeColor = Color.White;
            DatePicker1.CustomFormat = "dd.MM.yyyy";
            DatePicker1.Font = new Font("Verdana", 21F, FontStyle.Bold, GraphicsUnit.Point);
            DatePicker1.Format = DateTimePickerFormat.Short;
            DatePicker1.Location = new Point(45, 151);
            DatePicker1.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            DatePicker1.MinDate = new DateTime(2023, 12, 1, 21, 42, 23, 931);
            DatePicker1.MinimumSize = new Size(0, 35);
            DatePicker1.Name = "DatePicker1";
            DatePicker1.Size = new Size(292, 42);
            DatePicker1.SkinColor = Color.MediumSlateBlue;
            DatePicker1.TabIndex = 23;
            DatePicker1.TextColor = Color.White;
            DatePicker1.Value = new DateTime(2023, 12, 1, 21, 42, 23, 932);
            DatePicker1.ValueChanged += DatePicker1_ValueChanged;
            // 
            // dateOn
            // 
            dateOn.AutoSize = true;
            dateOn.Font = new Font("Verdana", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            dateOn.ForeColor = Color.White;
            dateOn.Location = new Point(14, 47);
            dateOn.Name = "dateOn";
            dateOn.Size = new Size(90, 35);
            dateOn.TabIndex = 29;
            dateOn.Text = "Date";
            // 
            // numUpDownHr
            // 
            numUpDownHr.BackColor = Color.Gray;
            numUpDownHr.Font = new Font("Verdana", 21F, FontStyle.Bold, GraphicsUnit.Point);
            numUpDownHr.Format = CustomOptions.Hours;
            numUpDownHr.Location = new Point(55, 233);
            numUpDownHr.MinimumSize = new Size(0, 35);
            numUpDownHr.Name = "numUpDownHr";
            numUpDownHr.RepeatDelayMs = 160;
            numUpDownHr.Size = new Size(89, 85);
            numUpDownHr.SkinColor = Color.MediumSlateBlue;
            numUpDownHr.TabIndex = 30;
            numUpDownHr.Text = "0";
            numUpDownHr.TextChanged += numUpDownHr_TextChanged;
            // 
            // numUpDownMin
            // 
            numUpDownMin.BackColor = Color.Gray;
            numUpDownMin.Font = new Font("Verdana", 21F, FontStyle.Bold, GraphicsUnit.Point);
            numUpDownMin.Format = CustomOptions.Minutes;
            numUpDownMin.Location = new Point(141, 233);
            numUpDownMin.MinimumSize = new Size(0, 35);
            numUpDownMin.Name = "numUpDownMin";
            numUpDownMin.RepeatDelayMs = 110;
            numUpDownMin.Size = new Size(89, 85);
            numUpDownMin.SkinColor = Color.MediumSlateBlue;
            numUpDownMin.TabIndex = 31;
            numUpDownMin.Text = "0";
            numUpDownMin.TextChanged += numUpDownMin_TextChanged;
            // 
            // numUpDownSec
            // 
            numUpDownSec.BackColor = Color.Gray;
            numUpDownSec.Font = new Font("Verdana", 21F, FontStyle.Bold, GraphicsUnit.Point);
            numUpDownSec.Format = CustomOptions.Seconds;
            numUpDownSec.Location = new Point(227, 233);
            numUpDownSec.MinimumSize = new Size(0, 35);
            numUpDownSec.Name = "numUpDownSec";
            numUpDownSec.RepeatDelayMs = 110;
            numUpDownSec.Size = new Size(89, 85);
            numUpDownSec.SkinColor = Color.MediumSlateBlue;
            numUpDownSec.TabIndex = 32;
            numUpDownSec.Text = "0";
            numUpDownSec.TextChanged += numUpDownSec_TextChanged;
            // 
            // advanced
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(800, 450);
            Controls.Add(numUpDownSec);
            Controls.Add(numUpDownMin);
            Controls.Add(numUpDownHr);
            Controls.Add(dateOn);
            Controls.Add(DatePicker1);
            Controls.Add(labelError);
            Controls.Add(labelErrorMessage);
            Controls.Add(labelCdown);
            Controls.Add(buttonFNSH);
            FormBorderStyle = FormBorderStyle.None;
            Name = "advanced";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonFNSH;
        private RichTextBox richTextBoxSec;
        private RichTextBox tbSec;
        private RichTextBox tbMin;
        private RichTextBox tbHr;
        private RichTextBox tbDay;
        private Label labelCdown;
        private Label labelErrorMessage;
        private Label labelError;
        private RichTextBox richTextBox3;
        private RichTextBox richTextBox2;
        private System.Windows.Forms.Timer timerAdv;
        private DatePicker DatePicker1;
        private NumUpDown numUpDownHr;
        private NumUpDown numUpDownMin;
        private NumUpDown numUpDownSec;
        private Label dateOn;
    }
}