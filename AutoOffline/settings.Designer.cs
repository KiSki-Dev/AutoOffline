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
            labelCon = new Label();
            comboBoxLan = new ComboBox();
            labelLan = new Label();
            labelUsr = new Label();
            richTextBoxUsr = new RichTextBox();
            labelFea = new Label();
            linkLabel1 = new LinkLabel();
            linkLabelNFeaText = new LinkLabel();
            buttonUsr = new Button();
            buttonLan = new Button();
            labelNFeaText = new Label();
            labelNFeaText2 = new Label();
            labelNFeaText3 = new Label();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // labelCon
            // 
            labelCon.Font = new Font("Verdana", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelCon.ForeColor = Color.White;
            labelCon.Location = new Point(21, 41);
            labelCon.Name = "labelCon";
            labelCon.Size = new Size(251, 68);
            labelCon.TabIndex = 3;
            labelCon.Text = "Config";
            labelCon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBoxLan
            // 
            comboBoxLan.BackColor = Color.Silver;
            comboBoxLan.Cursor = Cursors.Hand;
            comboBoxLan.DisplayMember = "English";
            comboBoxLan.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxLan.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxLan.ForeColor = Color.Black;
            comboBoxLan.FormattingEnabled = true;
            comboBoxLan.Items.AddRange(new object[] { "English", "German", "Russian", "Spanish (Soon)" });
            comboBoxLan.Location = new Point(21, 186);
            comboBoxLan.Name = "comboBoxLan";
            comboBoxLan.Size = new Size(193, 33);
            comboBoxLan.TabIndex = 4;
            // 
            // labelLan
            // 
            labelLan.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelLan.ForeColor = Color.White;
            labelLan.Location = new Point(21, 152);
            labelLan.Name = "labelLan";
            labelLan.Size = new Size(193, 31);
            labelLan.TabIndex = 14;
            labelLan.Text = "Language";
            labelLan.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelUsr
            // 
            labelUsr.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelUsr.ForeColor = Color.White;
            labelUsr.Location = new Point(21, 253);
            labelUsr.Name = "labelUsr";
            labelUsr.Size = new Size(193, 31);
            labelUsr.TabIndex = 16;
            labelUsr.Text = "Username";
            labelUsr.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // richTextBoxUsr
            // 
            richTextBoxUsr.BackColor = Color.Gainsboro;
            richTextBoxUsr.BorderStyle = BorderStyle.None;
            richTextBoxUsr.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBoxUsr.Location = new Point(21, 288);
            richTextBoxUsr.Multiline = false;
            richTextBoxUsr.Name = "richTextBoxUsr";
            richTextBoxUsr.ScrollBars = RichTextBoxScrollBars.None;
            richTextBoxUsr.Size = new Size(193, 33);
            richTextBoxUsr.TabIndex = 17;
            richTextBoxUsr.Text = "";
            // 
            // labelFea
            // 
            labelFea.Font = new Font("Verdana", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelFea.ForeColor = Color.White;
            labelFea.Location = new Point(333, 41);
            labelFea.Name = "labelFea";
            labelFea.Size = new Size(308, 68);
            labelFea.TabIndex = 19;
            labelFea.Text = "New Features";
            labelFea.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel1.Location = new Point(360, 215);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(167, 23);
            linkLabel1.TabIndex = 21;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Discord Server";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // linkLabelNFeaText
            // 
            linkLabelNFeaText.AutoSize = true;
            linkLabelNFeaText.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabelNFeaText.Location = new Point(360, 367);
            linkLabelNFeaText.Name = "linkLabelNFeaText";
            linkLabelNFeaText.Size = new Size(252, 23);
            linkLabelNFeaText.TabIndex = 23;
            linkLabelNFeaText.TabStop = true;
            linkLabelNFeaText.Text = "GitHub for AutoOffline";
            linkLabelNFeaText.LinkClicked += linkLabel2_LinkClicked;
            // 
            // buttonUsr
            // 
            buttonUsr.BackColor = Color.FromArgb(130, 109, 178);
            buttonUsr.Cursor = Cursors.Hand;
            buttonUsr.FlatStyle = FlatStyle.Flat;
            buttonUsr.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonUsr.ForeColor = Color.White;
            buttonUsr.Location = new Point(219, 288);
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
            buttonLan.Cursor = Cursors.Hand;
            buttonLan.FlatStyle = FlatStyle.Flat;
            buttonLan.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLan.ForeColor = Color.White;
            buttonLan.Location = new Point(219, 186);
            buttonLan.Name = "buttonLan";
            buttonLan.Size = new Size(53, 33);
            buttonLan.TabIndex = 25;
            buttonLan.Text = "Save";
            buttonLan.UseVisualStyleBackColor = false;
            buttonLan.Click += buttonLan_Click;
            // 
            // labelNFeaText
            // 
            labelNFeaText.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelNFeaText.ForeColor = Color.White;
            labelNFeaText.Location = new Point(360, 104);
            labelNFeaText.Name = "labelNFeaText";
            labelNFeaText.Size = new Size(292, 111);
            labelNFeaText.TabIndex = 26;
            labelNFeaText.Text = "If you want to test out new Features,\r\nyou can apply on my";
            labelNFeaText.TextAlign = ContentAlignment.BottomLeft;
            // 
            // labelNFeaText2
            // 
            labelNFeaText2.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelNFeaText2.ForeColor = Color.White;
            labelNFeaText2.Location = new Point(360, 238);
            labelNFeaText2.Name = "labelNFeaText2";
            labelNFeaText2.Size = new Size(281, 46);
            labelNFeaText2.TabIndex = 27;
            labelNFeaText2.Text = "for Beta-Tester.";
            // 
            // labelNFeaText3
            // 
            labelNFeaText3.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelNFeaText3.ForeColor = Color.White;
            labelNFeaText3.Location = new Point(360, 281);
            labelNFeaText3.Name = "labelNFeaText3";
            labelNFeaText3.Size = new Size(270, 86);
            labelNFeaText3.TabIndex = 28;
            labelNFeaText3.Text = "Or wait until they\r\nrelease on my";
            labelNFeaText3.TextAlign = ContentAlignment.BottomLeft;
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = Color.FromArgb(35, 35, 40);
            panel1.Location = new Point(303, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(24, 453);
            panel1.TabIndex = 29;
            // 
            // settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Gray;
            ClientSize = new Size(800, 440);
            Controls.Add(panel1);
            Controls.Add(labelNFeaText3);
            Controls.Add(labelNFeaText2);
            Controls.Add(labelNFeaText);
            Controls.Add(buttonLan);
            Controls.Add(buttonUsr);
            Controls.Add(linkLabelNFeaText);
            Controls.Add(linkLabel1);
            Controls.Add(labelFea);
            Controls.Add(richTextBoxUsr);
            Controls.Add(labelUsr);
            Controls.Add(labelLan);
            Controls.Add(comboBoxLan);
            Controls.Add(labelCon);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "settings";
            Text = "settings";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelCon;
        private ComboBox comboBoxLan;
        private Label labelLan;
        private Label labelUsr;
        private RichTextBox richTextBoxUsr;
        private Label labelFea;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabelNFeaText;
        private Button buttonUsr;
        private Button buttonLan;
        private Label labelNFeaText;
        private Label labelNFeaText2;
        private Label labelNFeaText3;
        private Panel panel1;
    }
}