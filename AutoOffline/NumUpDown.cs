using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using static System.Windows.Forms.DataFormats;
using System.Security.Policy;

namespace AutoOffline
{
    public enum CustomOptions
    {
        Seconds,
        Minutes,
        Hours
    }

    public class NumUpDown : Control
    {
        public event EventHandler? ValueChanged;

        private CustomOptions format = CustomOptions.Seconds;

        private RichTextBox textBox;

        private Button buttonUp;

        private Button buttonDown;

        private const int calendarIconWidth = 34;
        private const int arrowIconWidth = 17;

        private decimal valueLocal;

        private string format_str = "  :";

    //Fields
    //-> Appearance
        private Color skinColor = Color.FromArgb(120, 100, 168);
        private Color textColor = Color.White;
        private Color borderColor = Color.PaleVioletRed;
        private int borderSize = 0;

        //Properties
        public CustomOptions Format
        {
            get { return format; }
            set
            {
                format = value;
                this.Invalidate();
            }
        }

        public Color SkinColor
        {
            get { return skinColor; }
            set
            {
                skinColor = value;
                this.Invalidate();
            }
        }

    public NumUpDown()
        {
            textBox = new RichTextBox();
            valueLocal = 0;
            textBox.KeyPress += TextBox_KeyPress;
            textBox.ScrollBars = RichTextBoxScrollBars.None;
            textBox.BorderStyle = BorderStyle.None;
            textBox.Multiline = false;
            Controls.Add(textBox);
            buttonUp = new Button();
            AddButtonUp();
            buttonDown = new Button();
            AddbuttonDown();
        }

        private void TextBox_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                AddValue(0);
                e.Handled = false;
                ValueChanged?.Invoke(this, e);
            }
            else if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                e.Handled = !(0 > 0);
            }
            else
            {
                e.Handled = true;
            }
        }

        private void AddButtonUp()
        {
            buttonUp.Text = "";
            buttonUp.BackgroundImage = Properties.Resources.arrowUp;
            buttonUp.BackgroundImageLayout = ImageLayout.Zoom;
            buttonUp.Name = "ButtonUp";
            buttonUp.FlatStyle = FlatStyle.Flat;
            buttonUp.FlatAppearance.BorderSize = 0;
            buttonUp.TextAlign = ContentAlignment.TopCenter;
            buttonUp.MouseDown += ButtonUpClick;

            buttonUp.BackColor = Color.FromArgb(100, 80, 148);
            Controls.Add(buttonUp);
        }

        private void AddbuttonDown()
        {
            buttonDown.Text = "";
            buttonDown.BackgroundImage = Properties.Resources.arrowDown;
            buttonDown.BackgroundImageLayout = ImageLayout.Zoom;
            buttonDown.Name = "buttonDown";
            buttonDown.FlatStyle = FlatStyle.Flat;
            buttonDown.FlatAppearance.BorderSize = 0;
            buttonDown.TextAlign = ContentAlignment.TopCenter;
            buttonDown.MouseDown += ButtonDownClick;

            buttonDown.BackColor = Color.FromArgb(100, 80, 148);
            Controls.Add(buttonDown);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (format.ToString() == "Seconds") { format_str = ""; }

            if (valueLocal < 10) { textBox.Text = "0" + valueLocal + format_str; }
            else { textBox.Text = valueLocal + format_str; }

            textBox.BackColor = Color.FromArgb(120, 100, 168);
            textBox.ForeColor = Color.White;

            int buttonHeight = this.Height;
            int buttonWidth = GetIconButtonWidth();

            textBox.Height = this.Height / 2 - 5;

            if (format.ToString() == "Seconds") { textBox.Width = buttonWidth + 5; }

            else { textBox.Width = buttonWidth * 2 + 18; }


            textBox.Location = new Point(buttonWidth / 2 - 6, 4);

            buttonUp.Size = new Size(buttonWidth, buttonHeight / 2);
            buttonDown.Size = buttonUp.Size;
            buttonUp.Location = new Point(0, buttonHeight / 2);
            buttonDown.Location = new Point(buttonWidth, buttonHeight / 2);

            using (Graphics graphics = this.CreateGraphics())
            using (SolidBrush skinBrush = new SolidBrush(skinColor))
            using (Pen penBorder = new Pen(borderColor, borderSize))
            using (SolidBrush openIconBrush = new SolidBrush(Color.FromArgb(50, 64, 64, 64)))
            {
                penBorder.Alignment = PenAlignment.Inset;

                if (format.ToString() == "Seconds") 
                {
                    RectangleF clientArea = new RectangleF(0, 0, buttonWidth * 2, this.Height - 0.5F);
                    graphics.FillRectangle(skinBrush, clientArea);
                }
                else
                {
                    RectangleF clientArea = new RectangleF(0, 0, buttonWidth * 2 + 18, this.Height - 0.5F);
                    graphics.FillRectangle(skinBrush, clientArea);
                }

            }
            base.OnPaint(e);
        }

        public int RepeatDelayMs { get; set; } = 100;
        private void ButtonUpClick(object? sender, MouseEventArgs e)
        {
            int delayMs = 100;

            while ((MouseButtons & MouseButtons.Left) != 0)
            {
                if (AddValue(1))
                {
                    Application.DoEvents();
                    Thread.Sleep(delayMs);
                    delayMs = RepeatDelayMs;
                }

                Application.DoEvents();
            }

            ValueChanged?.Invoke(this, e);
        }

        private void ButtonDownClick(object? sender, MouseEventArgs e)
        {
            int delayMs = 100;

            while ((MouseButtons & MouseButtons.Left) != 0)
            {
                if (AddValue(-1))
                {
                    Application.DoEvents();
                    Thread.Sleep(delayMs);
                    delayMs = RepeatDelayMs;
                }

                Application.DoEvents();
            }

            ValueChanged?.Invoke(this, e);
        }

        private bool AddValue(int value)
        {
            if (format.ToString() == "Seconds") { format_str = ""; }

            else if (string.IsNullOrEmpty(textBox.Text))
            {
                valueLocal = 0;
                textBox.Text = "0" + valueLocal + format_str;
            }
            else if (textBox.TextLength > 6)
            {
                Debug.Print("Too many significant digits for decimal");
                valueLocal = 23;
                textBox.Text = valueLocal + format_str;
            }

            valueLocal += value;

            if (valueLocal < 0)
            {
                valueLocal = 0;
                textBox.Text = "0" + valueLocal + format_str;
                return false;
            }
            else if (valueLocal < 10)
            {
                textBox.Text = "0" + valueLocal + format_str;
            }
            else if (valueLocal > 23 & format.ToString() == "Hours")
            {
                valueLocal = 23;
                textBox.Text = valueLocal + format_str;
                return false;
            }
            else if (valueLocal > 59)
            {
                valueLocal = 59;
                textBox.Text = valueLocal + format_str;
                return false;
            }
            else
            {
                textBox.Text = valueLocal + format_str;
            }

            this.Text = valueLocal.ToString();
            return true;
        }

        //Private methods
        private int GetIconButtonWidth()
        {
            int textWidh = TextRenderer.MeasureText(this.Text, this.Font).Width;
            if (textWidh <= this.Width - (calendarIconWidth + 20))
                return calendarIconWidth;
            else return arrowIconWidth;
        }
    }
}