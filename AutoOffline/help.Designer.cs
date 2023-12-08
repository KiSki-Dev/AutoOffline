namespace AutoOffline
{
    partial class help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(help));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            linkLabelDisc = new LinkLabel();
            linkLabelGit = new LinkLabel();
            labelText = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.github;
            pictureBox1.Location = new Point(49, 301);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 48);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.discord_small;
            pictureBox2.Location = new Point(49, 373);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 48);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // linkLabelDisc
            // 
            linkLabelDisc.AutoSize = true;
            linkLabelDisc.Cursor = Cursors.Hand;
            linkLabelDisc.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabelDisc.Location = new Point(113, 385);
            linkLabelDisc.Name = "linkLabelDisc";
            linkLabelDisc.Size = new Size(204, 23);
            linkLabelDisc.TabIndex = 3;
            linkLabelDisc.TabStop = true;
            linkLabelDisc.Text = "My Discord Server";
            linkLabelDisc.LinkClicked += linkLabel1_LinkClicked;
            // 
            // linkLabelGit
            // 
            linkLabelGit.AutoSize = true;
            linkLabelGit.Cursor = Cursors.Hand;
            linkLabelGit.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabelGit.Location = new Point(113, 314);
            linkLabelGit.Name = "linkLabelGit";
            linkLabelGit.Size = new Size(181, 23);
            linkLabelGit.TabIndex = 4;
            linkLabelGit.TabStop = true;
            linkLabelGit.Text = "My GitHub Page";
            linkLabelGit.LinkClicked += linkLabel2_LinkClicked;
            // 
            // labelText
            // 
            labelText.FlatStyle = FlatStyle.Flat;
            labelText.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelText.ForeColor = Color.White;
            labelText.Location = new Point(12, 8);
            labelText.Name = "labelText";
            labelText.Size = new Size(655, 282);
            labelText.TabIndex = 5;
            labelText.Text = resources.GetString("labelText.Text");
            labelText.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // help
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(800, 450);
            Controls.Add(labelText);
            Controls.Add(linkLabelGit);
            Controls.Add(linkLabelDisc);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "help";
            Text = "help";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private LinkLabel linkLabelDisc;
        private LinkLabel linkLabelGit;
        private Label labelText;
    }
}