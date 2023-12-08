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
            SuspendLayout();
            // 
            // labelCon
            // 
            labelCon.Font = new Font("Verdana", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelCon.ForeColor = Color.White;
            labelCon.Location = new Point(31, 40);
            labelCon.Name = "labelCon";
            labelCon.Size = new Size(251, 53);
            labelCon.TabIndex = 3;
            labelCon.Text = "Config";
            labelCon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBoxLan
            // 
            comboBoxLan.BackColor = Color.Silver;
            comboBoxLan.DisplayMember = "English";
            comboBoxLan.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxLan.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxLan.ForeColor = Color.Black;
            comboBoxLan.FormattingEnabled = true;
            comboBoxLan.Items.AddRange(new object[] { "English", "German", "Russian", "Spanish (Soon)" });
            comboBoxLan.Location = new Point(31, 185);
            comboBoxLan.Name = "comboBoxLan";
            comboBoxLan.Size = new Size(193, 33);
            comboBoxLan.TabIndex = 4;
            // 
            // labelLan
            // 
            labelLan.AutoSize = true;
            labelLan.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelLan.ForeColor = Color.White;
            labelLan.Location = new Point(31, 144);
            labelLan.Name = "labelLan";
            labelLan.Size = new Size(127, 25);
            labelLan.TabIndex = 14;
            labelLan.Text = "Language";
            // 
            // labelUsr
            // 
            labelUsr.AutoSize = true;
            labelUsr.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelUsr.ForeColor = Color.White;
            labelUsr.Location = new Point(31, 250);
            labelUsr.Name = "labelUsr";
            labelUsr.Size = new Size(130, 25);
            labelUsr.TabIndex = 16;
            labelUsr.Text = "Username";
            // 
            // richTextBoxUsr
            // 
            richTextBoxUsr.BackColor = Color.Gainsboro;
            richTextBoxUsr.BorderStyle = BorderStyle.None;
            richTextBoxUsr.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBoxUsr.Location = new Point(31, 287);
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
            labelFea.Location = new Point(329, 49);
            labelFea.Name = "labelFea";
            labelFea.Size = new Size(308, 69);
            labelFea.TabIndex = 19;
            labelFea.Text = "New Features";
            labelFea.TextAlign = ContentAlignment.TopCenter;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel1.Location = new Point(356, 214);
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
            linkLabelNFeaText.Location = new Point(356, 366);
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
            buttonUsr.FlatStyle = FlatStyle.Flat;
            buttonUsr.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonUsr.ForeColor = Color.White;
            buttonUsr.Location = new Point(229, 287);
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
            buttonLan.ForeColor = Color.White;
            buttonLan.Location = new Point(229, 185);
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
            labelNFeaText.Location = new Point(356, 103);
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
            labelNFeaText2.Location = new Point(356, 237);
            labelNFeaText2.Name = "labelNFeaText2";
            labelNFeaText2.Size = new Size(281, 46);
            labelNFeaText2.TabIndex = 27;
            labelNFeaText2.Text = "for Beta-Tester.";
            // 
            // labelNFeaText3
            // 
            labelNFeaText3.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelNFeaText3.ForeColor = Color.White;
            labelNFeaText3.Location = new Point(356, 280);
            labelNFeaText3.Name = "labelNFeaText3";
            labelNFeaText3.Size = new Size(270, 86);
            labelNFeaText3.TabIndex = 28;
            labelNFeaText3.Text = "Or wait until they\r\nrelease on my";
            labelNFeaText3.TextAlign = ContentAlignment.BottomLeft;
            // 
            // settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(800, 450);
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
    }
}