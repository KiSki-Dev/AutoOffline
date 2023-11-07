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
            panel2 = new Panel();
            labelError = new Label();
            labelErrorMessage = new Label();
            labelConDown = new Label();
            buttonFNSH = new Button();
            comboBoxSec = new ComboBox();
            richTextBox3 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            richTextBox1 = new RichTextBox();
            richTextBoxSec = new RichTextBox();
            comboBoxMin = new ComboBox();
            comboBoxHr = new ComboBox();
            comboBoxDay = new ComboBox();
            timerBasic = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(658, -3);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 478);
            panel2.TabIndex = 12;
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.BackColor = Color.Red;
            labelError.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelError.ForeColor = Color.White;
            labelError.Location = new Point(267, 257);
            labelError.Name = "labelError";
            labelError.Size = new Size(71, 23);
            labelError.TabIndex = 34;
            labelError.Text = "Error:";
            labelError.Visible = false;
            // 
            // labelErrorMessage
            // 
            labelErrorMessage.AutoSize = true;
            labelErrorMessage.BackColor = Color.Red;
            labelErrorMessage.Font = new Font("Verdana", 15F, FontStyle.Bold, GraphicsUnit.Point);
            labelErrorMessage.ForeColor = Color.White;
            labelErrorMessage.Location = new Point(216, 280);
            labelErrorMessage.Name = "labelErrorMessage";
            labelErrorMessage.Size = new Size(177, 25);
            labelErrorMessage.TabIndex = 33;
            labelErrorMessage.Text = "Time cant be 0";
            labelErrorMessage.Visible = false;
            // 
            // labelConDown
            // 
            labelConDown.AutoSize = true;
            labelConDown.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelConDown.Location = new Point(25, 409);
            labelConDown.Name = "labelConDown";
            labelConDown.Size = new Size(77, 23);
            labelConDown.TabIndex = 32;
            labelConDown.Text = "label1";
            labelConDown.Visible = false;
            // 
            // buttonFNSH
            // 
            buttonFNSH.BackColor = Color.FromArgb(130, 109, 178);
            buttonFNSH.FlatStyle = FlatStyle.Flat;
            buttonFNSH.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonFNSH.ForeColor = Color.White;
            buttonFNSH.Location = new Point(226, 318);
            buttonFNSH.Name = "buttonFNSH";
            buttonFNSH.Size = new Size(159, 80);
            buttonFNSH.TabIndex = 21;
            buttonFNSH.Text = "Start Shutdown";
            buttonFNSH.UseVisualStyleBackColor = false;
            buttonFNSH.Click += buttonFNSH_Click;
            // 
            // comboBoxSec
            // 
            comboBoxSec.BackColor = Color.Gray;
            comboBoxSec.DisplayMember = "10";
            comboBoxSec.FlatStyle = FlatStyle.Flat;
            comboBoxSec.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxSec.ForeColor = Color.White;
            comboBoxSec.FormattingEnabled = true;
            comboBoxSec.Items.AddRange(new object[] { "0", "1", "3", "5", "8", "10", "20", "30", "40", "50", "60" });
            comboBoxSec.Location = new Point(100, 83);
            comboBoxSec.Name = "comboBoxSec";
            comboBoxSec.RightToLeft = RightToLeft.No;
            comboBoxSec.Size = new Size(152, 31);
            comboBoxSec.TabIndex = 37;
            comboBoxSec.Text = "0";
            // 
            // richTextBox3
            // 
            richTextBox3.BackColor = Color.Gray;
            richTextBox3.BorderStyle = BorderStyle.None;
            richTextBox3.Cursor = Cursors.Hand;
            richTextBox3.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBox3.ForeColor = Color.Black;
            richTextBox3.Location = new Point(377, 135);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.ReadOnly = true;
            richTextBox3.RightToLeft = RightToLeft.No;
            richTextBox3.ScrollBars = RichTextBoxScrollBars.None;
            richTextBox3.Size = new Size(100, 28);
            richTextBox3.TabIndex = 49;
            richTextBox3.Text = "Days";
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = Color.Gray;
            richTextBox2.BorderStyle = BorderStyle.None;
            richTextBox2.Cursor = Cursors.Hand;
            richTextBox2.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBox2.ForeColor = Color.Black;
            richTextBox2.Location = new Point(123, 135);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ReadOnly = true;
            richTextBox2.RightToLeft = RightToLeft.No;
            richTextBox2.ScrollBars = RichTextBoxScrollBars.None;
            richTextBox2.Size = new Size(100, 28);
            richTextBox2.TabIndex = 48;
            richTextBox2.Text = "Hours";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.Gray;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Cursor = Cursors.Hand;
            richTextBox1.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBox1.ForeColor = Color.Black;
            richTextBox1.Location = new Point(377, 49);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.RightToLeft = RightToLeft.No;
            richTextBox1.ScrollBars = RichTextBoxScrollBars.None;
            richTextBox1.Size = new Size(100, 28);
            richTextBox1.TabIndex = 43;
            richTextBox1.Text = "Minutes";
            // 
            // richTextBoxSec
            // 
            richTextBoxSec.BackColor = Color.Gray;
            richTextBoxSec.BorderStyle = BorderStyle.None;
            richTextBoxSec.Cursor = Cursors.Hand;
            richTextBoxSec.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBoxSec.ForeColor = Color.Black;
            richTextBoxSec.Location = new Point(123, 49);
            richTextBoxSec.Name = "richTextBoxSec";
            richTextBoxSec.ReadOnly = true;
            richTextBoxSec.RightToLeft = RightToLeft.No;
            richTextBoxSec.ScrollBars = RichTextBoxScrollBars.None;
            richTextBoxSec.Size = new Size(100, 28);
            richTextBoxSec.TabIndex = 40;
            richTextBoxSec.Text = "Seconds";
            // 
            // comboBoxMin
            // 
            comboBoxMin.BackColor = Color.Gray;
            comboBoxMin.DisplayMember = "10";
            comboBoxMin.FlatStyle = FlatStyle.Flat;
            comboBoxMin.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxMin.ForeColor = Color.White;
            comboBoxMin.FormattingEnabled = true;
            comboBoxMin.Items.AddRange(new object[] { "0", "1", "2", "3", "5", "8", "10", "15", "20", "25", "30", "40", "45", "50", "60" });
            comboBoxMin.Location = new Point(350, 83);
            comboBoxMin.Name = "comboBoxMin";
            comboBoxMin.RightToLeft = RightToLeft.No;
            comboBoxMin.Size = new Size(152, 31);
            comboBoxMin.TabIndex = 50;
            comboBoxMin.Text = "0";
            // 
            // comboBoxHr
            // 
            comboBoxHr.BackColor = Color.Gray;
            comboBoxHr.DisplayMember = "10";
            comboBoxHr.FlatStyle = FlatStyle.Flat;
            comboBoxHr.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxHr.ForeColor = Color.White;
            comboBoxHr.FormattingEnabled = true;
            comboBoxHr.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "12", "15", "18", "20", "24" });
            comboBoxHr.Location = new Point(100, 167);
            comboBoxHr.Name = "comboBoxHr";
            comboBoxHr.RightToLeft = RightToLeft.No;
            comboBoxHr.Size = new Size(152, 31);
            comboBoxHr.TabIndex = 51;
            comboBoxHr.Text = "0";
            // 
            // comboBoxDay
            // 
            comboBoxDay.BackColor = Color.Gray;
            comboBoxDay.DisplayMember = "10";
            comboBoxDay.FlatStyle = FlatStyle.Flat;
            comboBoxDay.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxDay.ForeColor = Color.White;
            comboBoxDay.FormattingEnabled = true;
            comboBoxDay.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "10", "15", "30" });
            comboBoxDay.Location = new Point(350, 167);
            comboBoxDay.Name = "comboBoxDay";
            comboBoxDay.RightToLeft = RightToLeft.No;
            comboBoxDay.Size = new Size(152, 31);
            comboBoxDay.TabIndex = 52;
            comboBoxDay.Text = "0";
            // 
            // timerBasic
            // 
            timerBasic.Enabled = true;
            timerBasic.Interval = 1000;
            timerBasic.Tick += timerBasic_Tick;
            // 
            // basic
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxDay);
            Controls.Add(comboBoxHr);
            Controls.Add(comboBoxMin);
            Controls.Add(richTextBox3);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(richTextBoxSec);
            Controls.Add(comboBoxSec);
            Controls.Add(panel2);
            Controls.Add(labelError);
            Controls.Add(buttonFNSH);
            Controls.Add(labelErrorMessage);
            Controls.Add(labelConDown);
            FormBorderStyle = FormBorderStyle.None;
            Name = "basic";
            Text = "advanced";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label labelError;
        private Label labelErrorMessage;
        private Label labelConDown;
        private Button buttonFNSH;
        private ComboBox comboBoxSec;
        private RichTextBox richTextBox3;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBoxSec;
        private ComboBox comboBoxMin;
        private ComboBox comboBoxHr;
        private ComboBox comboBoxDay;
        private System.Windows.Forms.Timer timerBasic;
    }
}