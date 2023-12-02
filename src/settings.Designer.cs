namespace AutoOffline
{
    partial class settings
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
            label2 = new Label();
            comboBoxLan = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            richTextBoxUsr = new RichTextBox();
            label5 = new Label();
            richTextBox2 = new RichTextBox();
            linkLabel1 = new LinkLabel();
            richTextBox3 = new RichTextBox();
            linkLabel2 = new LinkLabel();
            buttonUsr = new Button();
            buttonLan = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(96, 40);
            label2.Name = "label2";
            label2.Size = new Size(143, 42);
            label2.TabIndex = 3;
            label2.Text = "Config";
            // 
            // comboBoxLan
            // 
            comboBoxLan.BackColor = Color.Silver;
            comboBoxLan.DisplayMember = "English";
            comboBoxLan.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxLan.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxLan.ForeColor = Color.Black;
            comboBoxLan.FormattingEnabled = true;
            comboBoxLan.Items.AddRange(new object[] { "English", "German", "Spanish" });
            comboBoxLan.Location = new Point(42, 144);
            comboBoxLan.Name = "comboBoxLan";
            comboBoxLan.Size = new Size(193, 33);
            comboBoxLan.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(81, 109);
            label3.Name = "label3";
            label3.Size = new Size(127, 25);
            label3.TabIndex = 14;
            label3.Text = "Language";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(81, 216);
            label4.Name = "label4";
            label4.Size = new Size(130, 25);
            label4.TabIndex = 16;
            label4.Text = "Username";
            // 
            // richTextBoxUsr
            // 
            richTextBoxUsr.BackColor = Color.Gainsboro;
            richTextBoxUsr.BorderStyle = BorderStyle.None;
            richTextBoxUsr.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBoxUsr.Location = new Point(42, 247);
            richTextBoxUsr.Name = "richTextBoxUsr";
            richTextBoxUsr.Size = new Size(193, 33);
            richTextBoxUsr.TabIndex = 17;
            richTextBoxUsr.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(386, 46);
            label5.Name = "label5";
            label5.Size = new Size(238, 35);
            label5.TabIndex = 19;
            label5.Text = "New Features";
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = Color.Gray;
            richTextBox2.BorderStyle = BorderStyle.None;
            richTextBox2.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBox2.Location = new Point(379, 99);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ScrollBars = RichTextBoxScrollBars.None;
            richTextBox2.Size = new Size(273, 78);
            richTextBox2.TabIndex = 20;
            richTextBox2.Text = "If you want to test out new Features,\nyou can apply on my";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel1.Location = new Point(377, 174);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(167, 23);
            linkLabel1.TabIndex = 21;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Discord Server";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // richTextBox3
            // 
            richTextBox3.BackColor = Color.Gray;
            richTextBox3.BorderStyle = BorderStyle.None;
            richTextBox3.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBox3.Location = new Point(379, 202);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.ScrollBars = RichTextBoxScrollBars.None;
            richTextBox3.Size = new Size(273, 96);
            richTextBox3.TabIndex = 22;
            richTextBox3.Text = "for Beta-Tester.\n\nOr wait until they\nrelease on my";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel2.Location = new Point(377, 300);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(252, 23);
            linkLabel2.TabIndex = 23;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "GitHub for AutoOffline";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // buttonUsr
            // 
            buttonUsr.BackColor = Color.FromArgb(130, 109, 178);
            buttonUsr.FlatStyle = FlatStyle.Flat;
            buttonUsr.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonUsr.ForeColor = Color.Black;
            buttonUsr.Location = new Point(240, 247);
            buttonUsr.Name = "buttonUsr";
            buttonUsr.Size = new Size(53, 33);
            buttonUsr.TabIndex = 24;
            buttonUsr.Text = "Save";
            buttonUsr.UseVisualStyleBackColor = false;
            buttonUsr.Click += buttonUsr_Click;
            // 
            // buttonLan
            // 
            buttonLan.BackColor = Color.FromArgb(130, 109, 178);
            buttonLan.FlatStyle = FlatStyle.Flat;
            buttonLan.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLan.ForeColor = Color.Black;
            buttonLan.Location = new Point(240, 144);
            buttonLan.Name = "buttonLan";
            buttonLan.Size = new Size(53, 33);
            buttonLan.TabIndex = 25;
            buttonLan.Text = "Save";
            buttonLan.UseVisualStyleBackColor = false;
            buttonLan.Click += buttonLan_Click;
            // 
            // settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonLan);
            Controls.Add(buttonUsr);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(richTextBox2);
            Controls.Add(label5);
            Controls.Add(richTextBoxUsr);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboBoxLan);
            Controls.Add(label2);
            Controls.Add(richTextBox3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "settings";
            Text = "settings";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private ComboBox comboBoxLan;
        private Label label3;
        private Label label4;
        private RichTextBox richTextBoxUsr;
        private Label label5;
        private RichTextBox richTextBox2;
        private LinkLabel linkLabel1;
        private RichTextBox richTextBox3;
        private LinkLabel linkLabel2;
        private Button buttonUsr;
        private Button buttonLan;
    }
}