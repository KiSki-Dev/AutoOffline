namespace AutoOffline
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            buttonHome = new Button();
            panelMenuBack = new Panel();
            textBoxSTDI = new TextBox();
            pictureBoxLogo = new PictureBox();
            buttonExit = new Button();
            buttonHelp = new Button();
            buttonSettings = new Button();
            buttonBasic = new Button();
            buttonAdvanced = new Button();
            panelHeader = new Panel();
            buttonStopSTD = new Button();
            labelCountdown = new Label();
            panelMain = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            panelMenuBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // buttonHome
            // 
            buttonHome.AutoSize = true;
            buttonHome.BackColor = Color.FromArgb(130, 42, 200);
            buttonHome.Cursor = Cursors.Hand;
            buttonHome.FlatAppearance.BorderSize = 0;
            buttonHome.FlatStyle = FlatStyle.Flat;
            buttonHome.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonHome.ForeColor = Color.White;
            buttonHome.Location = new Point(-1, 155);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new Size(162, 37);
            buttonHome.TabIndex = 0;
            buttonHome.Text = "Home";
            buttonHome.UseVisualStyleBackColor = false;
            buttonHome.Click += buttonHome_Click;
            // 
            // panelMenuBack
            // 
            panelMenuBack.BackColor = Color.FromArgb(35, 35, 40);
            panelMenuBack.Controls.Add(textBoxSTDI);
            panelMenuBack.Controls.Add(pictureBoxLogo);
            panelMenuBack.Controls.Add(buttonExit);
            panelMenuBack.Controls.Add(buttonHelp);
            panelMenuBack.Controls.Add(buttonSettings);
            panelMenuBack.Controls.Add(buttonBasic);
            panelMenuBack.Controls.Add(buttonAdvanced);
            panelMenuBack.Dock = DockStyle.Left;
            panelMenuBack.Location = new Point(0, 0);
            panelMenuBack.Name = "panelMenuBack";
            panelMenuBack.Size = new Size(162, 461);
            panelMenuBack.TabIndex = 1;
            // 
            // textBoxSTDI
            // 
            textBoxSTDI.BackColor = Color.FromArgb(64, 64, 64);
            textBoxSTDI.BorderStyle = BorderStyle.None;
            textBoxSTDI.Location = new Point(0, 0);
            textBoxSTDI.Name = "textBoxSTDI";
            textBoxSTDI.ReadOnly = true;
            textBoxSTDI.Size = new Size(10, 16);
            textBoxSTDI.TabIndex = 5;
            textBoxSTDI.Visible = false;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Cursor = Cursors.Hand;
            pictureBoxLogo.Image = Properties.Resources.LogoAutoOfflineC;
            pictureBoxLogo.Location = new Point(18, 10);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(130, 135);
            pictureBoxLogo.TabIndex = 9;
            pictureBoxLogo.TabStop = false;
            pictureBoxLogo.Click += pictureBoxLogo_Click;
            // 
            // buttonExit
            // 
            buttonExit.AutoSize = true;
            buttonExit.BackColor = Color.FromArgb(130, 42, 200);
            buttonExit.Cursor = Cursors.Hand;
            buttonExit.FlatAppearance.BorderSize = 0;
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.Font = new Font("Verdana", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonExit.ForeColor = Color.White;
            buttonExit.Location = new Point(-1, 415);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(162, 32);
            buttonExit.TabIndex = 8;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.AutoSize = true;
            buttonHelp.BackColor = Color.FromArgb(130, 42, 200);
            buttonHelp.Cursor = Cursors.Hand;
            buttonHelp.FlatAppearance.BorderSize = 0;
            buttonHelp.FlatStyle = FlatStyle.Flat;
            buttonHelp.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonHelp.ForeColor = Color.White;
            buttonHelp.Location = new Point(-1, 355);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(162, 37);
            buttonHelp.TabIndex = 7;
            buttonHelp.Text = "Help";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonSettings
            // 
            buttonSettings.AutoSize = true;
            buttonSettings.BackColor = Color.FromArgb(130, 42, 200);
            buttonSettings.Cursor = Cursors.Hand;
            buttonSettings.FlatAppearance.BorderSize = 0;
            buttonSettings.FlatStyle = FlatStyle.Flat;
            buttonSettings.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSettings.ForeColor = Color.White;
            buttonSettings.Location = new Point(-1, 305);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Size = new Size(162, 37);
            buttonSettings.TabIndex = 6;
            buttonSettings.Text = "Settings";
            buttonSettings.UseVisualStyleBackColor = false;
            buttonSettings.Click += buttonSettings_Click;
            // 
            // buttonBasic
            // 
            buttonBasic.AutoSize = true;
            buttonBasic.BackColor = Color.FromArgb(130, 42, 200);
            buttonBasic.Cursor = Cursors.Hand;
            buttonBasic.FlatAppearance.BorderSize = 0;
            buttonBasic.FlatStyle = FlatStyle.Flat;
            buttonBasic.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonBasic.ForeColor = Color.White;
            buttonBasic.Location = new Point(-1, 205);
            buttonBasic.Name = "buttonBasic";
            buttonBasic.Size = new Size(162, 37);
            buttonBasic.TabIndex = 4;
            buttonBasic.Text = "Basic";
            buttonBasic.UseVisualStyleBackColor = false;
            buttonBasic.Click += buttonBasic_Click;
            // 
            // buttonAdvanced
            // 
            buttonAdvanced.AutoSize = true;
            buttonAdvanced.BackColor = Color.FromArgb(130, 42, 200);
            buttonAdvanced.Cursor = Cursors.Hand;
            buttonAdvanced.FlatAppearance.BorderSize = 0;
            buttonAdvanced.FlatStyle = FlatStyle.Flat;
            buttonAdvanced.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAdvanced.ForeColor = Color.White;
            buttonAdvanced.Location = new Point(-1, 255);
            buttonAdvanced.Name = "buttonAdvanced";
            buttonAdvanced.Size = new Size(162, 37);
            buttonAdvanced.TabIndex = 5;
            buttonAdvanced.Text = "Advanced";
            buttonAdvanced.UseVisualStyleBackColor = false;
            buttonAdvanced.Click += buttonAdvanced_Click;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(35, 35, 40);
            panelHeader.Controls.Add(buttonStopSTD);
            panelHeader.Controls.Add(labelCountdown);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(162, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(653, 30);
            panelHeader.TabIndex = 2;
            // 
            // buttonStopSTD
            // 
            buttonStopSTD.AutoSize = true;
            buttonStopSTD.BackColor = Color.FromArgb(130, 42, 200);
            buttonStopSTD.Cursor = Cursors.Hand;
            buttonStopSTD.FlatAppearance.BorderSize = 0;
            buttonStopSTD.FlatStyle = FlatStyle.Flat;
            buttonStopSTD.Font = new Font("Verdana", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonStopSTD.ForeColor = Color.White;
            buttonStopSTD.Location = new Point(493, -2);
            buttonStopSTD.Name = "buttonStopSTD";
            buttonStopSTD.Size = new Size(166, 33);
            buttonStopSTD.TabIndex = 4;
            buttonStopSTD.Text = "Stop Shutdown";
            buttonStopSTD.UseVisualStyleBackColor = false;
            buttonStopSTD.Click += buttonStopSTD_Click;
            // 
            // labelCountdown
            // 
            labelCountdown.AutoSize = true;
            labelCountdown.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelCountdown.ForeColor = Color.White;
            labelCountdown.Location = new Point(16, 4);
            labelCountdown.Name = "labelCountdown";
            labelCountdown.Size = new Size(203, 23);
            labelCountdown.TabIndex = 0;
            labelCountdown.Text = "Shutdown not set";
            // 
            // panelMain
            // 
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(162, 30);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(653, 431);
            panelMain.TabIndex = 3;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(815, 461);
            Controls.Add(panelMain);
            Controls.Add(panelHeader);
            Controls.Add(buttonHome);
            Controls.Add(panelMenuBack);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AutoOffline";
            panelMenuBack.ResumeLayout(false);
            panelMenuBack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonHome;
        private Panel panelMenuBack;
        private Panel panelHeader;
        private Panel panelMain;
        private Button buttonBasic;
        private Button buttonSettings;
        private Button buttonAdvanced;
        private Button buttonHelp;
        private Button buttonExit;
        private PictureBox pictureBoxLogo;
        private Button buttonStopSTD;
        private Label labelCountdown;
        private TextBox textBoxSTDI;
        private System.Windows.Forms.Timer timer1;
    }
}