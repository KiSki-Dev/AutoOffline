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
            richTextBoxWelcome = new RichTextBox();
            richTextBox1 = new RichTextBox();
            richTextBox3 = new RichTextBox();
            panel1 = new Panel();
            button4h = new Button();
            button2h = new Button();
            button1h = new Button();
            button30m = new Button();
            button10m = new Button();
            button5m = new Button();
            panel2 = new Panel();
            timerPre = new System.Windows.Forms.Timer(components);
            labelCdown = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBoxWelcome
            // 
            richTextBoxWelcome.BackColor = Color.Gray;
            richTextBoxWelcome.BorderStyle = BorderStyle.None;
            richTextBoxWelcome.Cursor = Cursors.Help;
            richTextBoxWelcome.Font = new Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBoxWelcome.ForeColor = Color.White;
            richTextBoxWelcome.Location = new Point(27, 22);
            richTextBoxWelcome.Multiline = false;
            richTextBoxWelcome.Name = "richTextBoxWelcome";
            richTextBoxWelcome.ReadOnly = true;
            richTextBoxWelcome.Size = new Size(464, 47);
            richTextBoxWelcome.TabIndex = 0;
            richTextBoxWelcome.Text = "Hello, User!";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.Gray;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Cursor = Cursors.Help;
            richTextBox1.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBox1.ForeColor = Color.White;
            richTextBox1.Location = new Point(38, 71);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.ScrollBars = RichTextBoxScrollBars.None;
            richTextBox1.Size = new Size(368, 347);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // richTextBox3
            // 
            richTextBox3.BackColor = Color.Gray;
            richTextBox3.BorderStyle = BorderStyle.None;
            richTextBox3.Cursor = Cursors.Hand;
            richTextBox3.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBox3.ForeColor = Color.White;
            richTextBox3.Location = new Point(491, 118);
            richTextBox3.Multiline = false;
            richTextBox3.Name = "richTextBox3";
            richTextBox3.ReadOnly = true;
            richTextBox3.Size = new Size(106, 30);
            richTextBox3.TabIndex = 3;
            richTextBox3.Text = "Presets";
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
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(658, -3);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 478);
            panel2.TabIndex = 5;
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
            // home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(800, 450);
            Controls.Add(labelCdown);
            Controls.Add(panel2);
            Controls.Add(richTextBox3);
            Controls.Add(richTextBox1);
            Controls.Add(richTextBoxWelcome);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "home";
            Text = "home";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBoxWelcome;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox3;
        private Panel panel1;
        private Panel panel2;
        private Button button5m;
        private Button button30m;
        private Button button10m;
        private Button button4h;
        private Button button2h;
        private Button button1h;
        private System.Windows.Forms.Timer timerPre;
        private Label labelCdown;
    }
}