namespace AutoOffline
{
    partial class basic
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
            timerBasic = new System.Windows.Forms.Timer(components);
            labelError = new Label();
            labelErrorMessage = new Label();
            labelCdown = new Label();
            tbDay = new RichTextBox();
            tbHr = new RichTextBox();
            tbMin = new RichTextBox();
            tbSec = new RichTextBox();
            buttonFNSH = new Button();
            labelSec = new Label();
            labelMin = new Label();
            labelHr = new Label();
            labelDay = new Label();
            SuspendLayout();
            // 
            // timerBasic
            // 
            timerBasic.Enabled = true;
            timerBasic.Interval = 1000;
            timerBasic.Tick += timerBasic_Tick;
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.BackColor = Color.Red;
            labelError.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelError.ForeColor = Color.White;
            labelError.Location = new Point(505, 252);
            labelError.Name = "labelError";
            labelError.Size = new Size(71, 23);
            labelError.TabIndex = 30;
            labelError.Text = "Error:";
            labelError.Visible = false;
            // 
            // labelErrorMessage
            // 
            labelErrorMessage.AutoSize = true;
            labelErrorMessage.BackColor = Color.Red;
            labelErrorMessage.Font = new Font("Verdana", 15F, FontStyle.Bold, GraphicsUnit.Point);
            labelErrorMessage.ForeColor = Color.White;
            labelErrorMessage.Location = new Point(454, 275);
            labelErrorMessage.Name = "labelErrorMessage";
            labelErrorMessage.Size = new Size(177, 25);
            labelErrorMessage.TabIndex = 29;
            labelErrorMessage.Text = "Time cant be 0";
            labelErrorMessage.Visible = false;
            // 
            // labelCdown
            // 
            labelCdown.AutoSize = true;
            labelCdown.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelCdown.Location = new Point(553, 63);
            labelCdown.Name = "labelCdown";
            labelCdown.Size = new Size(77, 23);
            labelCdown.TabIndex = 28;
            labelCdown.Text = "label1";
            labelCdown.Visible = false;
            // 
            // tbDay
            // 
            tbDay.BackColor = Color.DarkGray;
            tbDay.BorderStyle = BorderStyle.None;
            tbDay.Cursor = Cursors.IBeam;
            tbDay.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            tbDay.ForeColor = Color.White;
            tbDay.Location = new Point(237, 265);
            tbDay.Name = "tbDay";
            tbDay.RightToLeft = RightToLeft.No;
            tbDay.ScrollBars = RichTextBoxScrollBars.None;
            tbDay.Size = new Size(168, 32);
            tbDay.TabIndex = 27;
            tbDay.Text = "0";
            // 
            // tbHr
            // 
            tbHr.BackColor = Color.DarkGray;
            tbHr.BorderStyle = BorderStyle.None;
            tbHr.Cursor = Cursors.IBeam;
            tbHr.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            tbHr.ForeColor = Color.White;
            tbHr.Location = new Point(38, 265);
            tbHr.Name = "tbHr";
            tbHr.RightToLeft = RightToLeft.No;
            tbHr.ScrollBars = RichTextBoxScrollBars.None;
            tbHr.Size = new Size(163, 32);
            tbHr.TabIndex = 26;
            tbHr.Text = "0";
            // 
            // tbMin
            // 
            tbMin.BackColor = Color.DarkGray;
            tbMin.BorderStyle = BorderStyle.None;
            tbMin.Cursor = Cursors.IBeam;
            tbMin.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            tbMin.ForeColor = Color.White;
            tbMin.Location = new Point(237, 125);
            tbMin.Name = "tbMin";
            tbMin.RightToLeft = RightToLeft.No;
            tbMin.ScrollBars = RichTextBoxScrollBars.None;
            tbMin.Size = new Size(168, 32);
            tbMin.TabIndex = 25;
            tbMin.Text = "0";
            // 
            // tbSec
            // 
            tbSec.BackColor = Color.DarkGray;
            tbSec.BorderStyle = BorderStyle.None;
            tbSec.Cursor = Cursors.IBeam;
            tbSec.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            tbSec.ForeColor = Color.White;
            tbSec.Location = new Point(38, 125);
            tbSec.Name = "tbSec";
            tbSec.RightToLeft = RightToLeft.No;
            tbSec.ScrollBars = RichTextBoxScrollBars.None;
            tbSec.Size = new Size(163, 32);
            tbSec.TabIndex = 24;
            tbSec.Text = "0";
            // 
            // buttonFNSH
            // 
            buttonFNSH.BackColor = Color.FromArgb(130, 109, 178);
            buttonFNSH.FlatStyle = FlatStyle.Flat;
            buttonFNSH.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonFNSH.ForeColor = Color.White;
            buttonFNSH.Location = new Point(459, 166);
            buttonFNSH.Name = "buttonFNSH";
            buttonFNSH.Size = new Size(181, 83);
            buttonFNSH.TabIndex = 21;
            buttonFNSH.Text = "Start Shutdown";
            buttonFNSH.UseVisualStyleBackColor = false;
            buttonFNSH.Click += buttonFNSH_Click_1;
            // 
            // labelSec
            // 
            labelSec.AutoSize = true;
            labelSec.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelSec.ForeColor = Color.White;
            labelSec.Location = new Point(59, 97);
            labelSec.Name = "labelSec";
            labelSec.Size = new Size(109, 25);
            labelSec.TabIndex = 33;
            labelSec.Text = "Seconds";
            // 
            // labelMin
            // 
            labelMin.AutoSize = true;
            labelMin.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelMin.ForeColor = Color.White;
            labelMin.Location = new Point(265, 97);
            labelMin.Name = "labelMin";
            labelMin.Size = new Size(105, 25);
            labelMin.TabIndex = 34;
            labelMin.Text = "Minutes";
            // 
            // labelHr
            // 
            labelHr.AutoSize = true;
            labelHr.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelHr.ForeColor = Color.White;
            labelHr.Location = new Point(59, 237);
            labelHr.Name = "labelHr";
            labelHr.Size = new Size(81, 25);
            labelHr.TabIndex = 35;
            labelHr.Text = "Hours";
            // 
            // labelDay
            // 
            labelDay.AutoSize = true;
            labelDay.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelDay.ForeColor = Color.White;
            labelDay.Location = new Point(265, 237);
            labelDay.Name = "labelDay";
            labelDay.Size = new Size(69, 25);
            labelDay.TabIndex = 36;
            labelDay.Text = "Days";
            // 
            // basic
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(800, 450);
            Controls.Add(labelDay);
            Controls.Add(labelHr);
            Controls.Add(labelMin);
            Controls.Add(labelSec);
            Controls.Add(labelError);
            Controls.Add(labelErrorMessage);
            Controls.Add(labelCdown);
            Controls.Add(tbDay);
            Controls.Add(tbHr);
            Controls.Add(tbMin);
            Controls.Add(tbSec);
            Controls.Add(buttonFNSH);
            FormBorderStyle = FormBorderStyle.None;
            Name = "basic";
            Text = "advanced";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer timerBasic;
        private Label labelError;
        private Label labelErrorMessage;
        private Label labelCdown;
        private RichTextBox tbDay;
        private RichTextBox tbHr;
        private RichTextBox tbMin;
        private RichTextBox tbSec;
        private Button buttonFNSH;
        private Label labelSec;
        private Label labelMin;
        private Label labelHr;
        private Label labelDay;
    }
}