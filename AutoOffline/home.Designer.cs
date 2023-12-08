namespace AutoOffline
{
    partial class home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            panel1 = new Panel();
            button4h = new Button();
            button2h = new Button();
            button1h = new Button();
            button30m = new Button();
            button10m = new Button();
            button5m = new Button();
            timerPre = new System.Windows.Forms.Timer(components);
            labelCdown = new Label();
            labelInfo = new Label();
            labelWelcome = new Label();
            labelPre = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(button4h);
            panel1.Controls.Add(button2h);
            panel1.Controls.Add(button1h);
            panel1.Controls.Add(button30m);
            panel1.Controls.Add(button10m);
            panel1.Controls.Add(button5m);
            panel1.Location = new Point(444, 149);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 269);
            panel1.TabIndex = 4;
            // 
            // button4h
            // 
            button4h.BackColor = Color.FromArgb(130, 109, 178);
            button4h.FlatStyle = FlatStyle.Flat;
            button4h.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4h.ForeColor = Color.White;
            button4h.Location = new Point(15, 221);
            button4h.Name = "button4h";
            button4h.Size = new Size(170, 26);
            button4h.TabIndex = 5;
            button4h.Text = "4 Hour";
            button4h.UseVisualStyleBackColor = false;
            button4h.Click += button4h_Click;
            // 
            // button2h
            // 
            button2h.BackColor = Color.FromArgb(130, 109, 178);
            button2h.FlatStyle = FlatStyle.Flat;
            button2h.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2h.ForeColor = Color.White;
            button2h.Location = new Point(15, 179);
            button2h.Name = "button2h";
            button2h.Size = new Size(170, 26);
            button2h.TabIndex = 4;
            button2h.Text = "2 Hour";
            button2h.UseVisualStyleBackColor = false;
            button2h.Click += button2h_Click;
            // 
            // button1h
            // 
            button1h.BackColor = Color.FromArgb(130, 109, 178);
            button1h.FlatStyle = FlatStyle.Flat;
            button1h.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1h.ForeColor = Color.White;
            button1h.Location = new Point(15, 137);
            button1h.Name = "button1h";
            button1h.Size = new Size(170, 26);
            button1h.TabIndex = 3;
            button1h.Text = "1 Hour";
            button1h.UseVisualStyleBackColor = false;
            button1h.Click += button1h_Click;
            // 
            // button30m
            // 
            button30m.BackColor = Color.FromArgb(130, 109, 178);
            button30m.FlatStyle = FlatStyle.Flat;
            button30m.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button30m.ForeColor = Color.White;
            button30m.Location = new Point(15, 95);
            button30m.Name = "button30m";
            button30m.Size = new Size(170, 26);
            button30m.TabIndex = 2;
            button30m.Text = "30 Minutes";
            button30m.UseVisualStyleBackColor = false;
            button30m.Click += button30m_Click;
            // 
            // button10m
            // 
            button10m.BackColor = Color.FromArgb(130, 109, 178);
            button10m.FlatStyle = FlatStyle.Flat;
            button10m.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button10m.ForeColor = Color.White;
            button10m.Location = new Point(15, 53);
            button10m.Name = "button10m";
            button10m.Size = new Size(170, 26);
            button10m.TabIndex = 1;
            button10m.Text = "10 Minutes";
            button10m.UseVisualStyleBackColor = false;
            button10m.Click += button10m_Click;
            // 
            // button5m
            // 
            button5m.BackColor = Color.FromArgb(130, 109, 178);
            button5m.FlatStyle = FlatStyle.Flat;
            button5m.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button5m.ForeColor = Color.White;
            button5m.Location = new Point(15, 11);
            button5m.Name = "button5m";
            button5m.Size = new Size(170, 26);
            button5m.TabIndex = 0;
            button5m.Text = "5 Minutes";
            button5m.UseVisualStyleBackColor = false;
            button5m.Click += button5m_Click;
            // 
            // timerPre
            // 
            timerPre.Enabled = true;
            timerPre.Interval = 1000;
            timerPre.Tick += timerPre_Tick;
            // 
            // labelCdown
            // 
            labelCdown.AutoSize = true;
            labelCdown.BackColor = Color.Gray;
            labelCdown.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelCdown.ForeColor = Color.Gray;
            labelCdown.Location = new Point(441, 421);
            labelCdown.Name = "labelCdown";
            labelCdown.Size = new Size(203, 23);
            labelCdown.TabIndex = 6;
            labelCdown.Text = "Shutdown not set";
            labelCdown.Visible = false;
            // 
            // labelInfo
            // 
            labelInfo.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelInfo.ForeColor = Color.White;
            labelInfo.Location = new Point(27, 71);
            labelInfo.Name = "labelInfo";
            labelInfo.RightToLeft = RightToLeft.No;
            labelInfo.Size = new Size(408, 373);
            labelInfo.TabIndex = 7;
            labelInfo.Text = resources.GetString("labelInfo.Text");
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.FlatStyle = FlatStyle.Flat;
            labelWelcome.Font = new Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelWelcome.ForeColor = Color.White;
            labelWelcome.Location = new Point(27, 22);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(227, 38);
            labelWelcome.TabIndex = 8;
            labelWelcome.Text = "Hello, User!";
            // 
            // labelPre
            // 
            labelPre.AutoSize = true;
            labelPre.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelPre.ForeColor = Color.White;
            labelPre.Location = new Point(478, 118);
            labelPre.Name = "labelPre";
            labelPre.Size = new Size(114, 29);
            labelPre.TabIndex = 9;
            labelPre.Text = "Presets";
            labelPre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(800, 450);
            Controls.Add(labelPre);
            Controls.Add(labelWelcome);
            Controls.Add(labelInfo);
            Controls.Add(labelCdown);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "home";
            Text = "home";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Button button5m;
        private Button button30m;
        private Button button10m;
        private Button button4h;
        private Button button2h;
        private Button button1h;
        private System.Windows.Forms.Timer timerPre;
        private Label labelCdown;
        private Label labelInfo;
        private Label labelWelcome;
        private Label labelPre;
    }
}