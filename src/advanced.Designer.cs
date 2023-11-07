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
            richTextBoxSec = new RichTextBox();
            richTextBox1 = new RichTextBox();
            panel2 = new Panel();
            tbSec = new RichTextBox();
            tbMin = new RichTextBox();
            tbHr = new RichTextBox();
            tbDay = new RichTextBox();
            labelCdown = new Label();
            labelErrorMessage = new Label();
            labelError = new Label();
            richTextBox2 = new RichTextBox();
            richTextBox3 = new RichTextBox();
            timerAdv = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // buttonFNSH
            // 
            buttonFNSH.BackColor = Color.FromArgb(130, 109, 178);
            buttonFNSH.FlatStyle = FlatStyle.Flat;
            buttonFNSH.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonFNSH.ForeColor = Color.White;
            buttonFNSH.Location = new Point(454, 179);
            buttonFNSH.Name = "buttonFNSH";
            buttonFNSH.Size = new Size(159, 80);
            buttonFNSH.TabIndex = 5;
            buttonFNSH.Text = "Start Shutdown";
            buttonFNSH.UseVisualStyleBackColor = false;
            buttonFNSH.Click += buttonFNSH_Click;
            // 
            // richTextBoxSec
            // 
            richTextBoxSec.BackColor = Color.Gray;
            richTextBoxSec.BorderStyle = BorderStyle.None;
            richTextBoxSec.Cursor = Cursors.Hand;
            richTextBoxSec.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBoxSec.ForeColor = Color.Black;
            richTextBoxSec.Location = new Point(63, 92);
            richTextBoxSec.Name = "richTextBoxSec";
            richTextBoxSec.ReadOnly = true;
            richTextBoxSec.RightToLeft = RightToLeft.No;
            richTextBoxSec.ScrollBars = RichTextBoxScrollBars.None;
            richTextBoxSec.Size = new Size(100, 28);
            richTextBoxSec.TabIndex = 7;
            richTextBoxSec.Text = "Seconds";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.Gray;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Cursor = Cursors.Hand;
            richTextBox1.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBox1.ForeColor = Color.Black;
            richTextBox1.Location = new Point(268, 92);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.RightToLeft = RightToLeft.No;
            richTextBox1.ScrollBars = RichTextBoxScrollBars.None;
            richTextBox1.Size = new Size(100, 28);
            richTextBox1.TabIndex = 8;
            richTextBox1.Text = "Minutes";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(653, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 478);
            panel2.TabIndex = 11;
            // 
            // tbSec
            // 
            tbSec.BackColor = Color.DarkGray;
            tbSec.BorderStyle = BorderStyle.None;
            tbSec.Cursor = Cursors.IBeam;
            tbSec.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            tbSec.ForeColor = Color.White;
            tbSec.Location = new Point(38, 126);
            tbSec.Name = "tbSec";
            tbSec.RightToLeft = RightToLeft.No;
            tbSec.ScrollBars = RichTextBoxScrollBars.None;
            tbSec.Size = new Size(163, 32);
            tbSec.TabIndex = 12;
            tbSec.Text = "0";
            // 
            // tbMin
            // 
            tbMin.BackColor = Color.DarkGray;
            tbMin.BorderStyle = BorderStyle.None;
            tbMin.Cursor = Cursors.IBeam;
            tbMin.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            tbMin.ForeColor = Color.White;
            tbMin.Location = new Point(237, 126);
            tbMin.Name = "tbMin";
            tbMin.RightToLeft = RightToLeft.No;
            tbMin.ScrollBars = RichTextBoxScrollBars.None;
            tbMin.Size = new Size(168, 32);
            tbMin.TabIndex = 13;
            tbMin.Text = "0";
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
            tbHr.TabIndex = 14;
            tbHr.Text = "0";
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
            tbDay.TabIndex = 15;
            tbDay.Text = "0";
            // 
            // labelCdown
            // 
            labelCdown.AutoSize = true;
            labelCdown.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelCdown.Location = new Point(431, 60);
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
            labelErrorMessage.Location = new Point(445, 293);
            labelErrorMessage.Name = "labelErrorMessage";
            labelErrorMessage.Size = new Size(177, 25);
            labelErrorMessage.TabIndex = 17;
            labelErrorMessage.Text = "Time cant be 0";
            labelErrorMessage.Visible = false;
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.BackColor = Color.Red;
            labelError.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelError.ForeColor = Color.White;
            labelError.Location = new Point(496, 270);
            labelError.Name = "labelError";
            labelError.Size = new Size(71, 23);
            labelError.TabIndex = 18;
            labelError.Text = "Error:";
            labelError.Visible = false;
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = Color.Gray;
            richTextBox2.BorderStyle = BorderStyle.None;
            richTextBox2.Cursor = Cursors.Hand;
            richTextBox2.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBox2.ForeColor = Color.Black;
            richTextBox2.Location = new Point(63, 231);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ReadOnly = true;
            richTextBox2.RightToLeft = RightToLeft.No;
            richTextBox2.ScrollBars = RichTextBoxScrollBars.None;
            richTextBox2.Size = new Size(100, 28);
            richTextBox2.TabIndex = 19;
            richTextBox2.Text = "Hours";
            // 
            // richTextBox3
            // 
            richTextBox3.BackColor = Color.Gray;
            richTextBox3.BorderStyle = BorderStyle.None;
            richTextBox3.Cursor = Cursors.Hand;
            richTextBox3.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBox3.ForeColor = Color.Black;
            richTextBox3.Location = new Point(268, 231);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.ReadOnly = true;
            richTextBox3.RightToLeft = RightToLeft.No;
            richTextBox3.ScrollBars = RichTextBoxScrollBars.None;
            richTextBox3.Size = new Size(100, 28);
            richTextBox3.TabIndex = 20;
            richTextBox3.Text = "Days";
            // 
            // timerAdv
            // 
            timerAdv.Enabled = true;
            timerAdv.Interval = 1000;
            timerAdv.Tick += timerAdv_Tick_1;
            // 
            // advanced
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox3);
            Controls.Add(richTextBox2);
            Controls.Add(labelError);
            Controls.Add(labelErrorMessage);
            Controls.Add(labelCdown);
            Controls.Add(tbDay);
            Controls.Add(tbHr);
            Controls.Add(tbMin);
            Controls.Add(tbSec);
            Controls.Add(panel2);
            Controls.Add(richTextBox1);
            Controls.Add(richTextBoxSec);
            Controls.Add(buttonFNSH);
            FormBorderStyle = FormBorderStyle.None;
            Name = "advanced";
            Text = "basic";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonFNSH;
        private RichTextBox richTextBoxSec;
        private RichTextBox richTextBox1;
        private Panel panel2;
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
    }
}