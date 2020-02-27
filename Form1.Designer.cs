namespace AlarmClock
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.Clock = new System.Windows.Forms.TextBox();
            this.Day = new System.Windows.Forms.TextBox();
            this.Date = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MinDown = new System.Windows.Forms.Button();
            this.HourUp = new System.Windows.Forms.Button();
            this.MinUp = new System.Windows.Forms.Button();
            this.HourDown = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Clock
            // 
            this.Clock.BackColor = System.Drawing.SystemColors.WindowText;
            this.Clock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Clock.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clock.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Clock.Location = new System.Drawing.Point(-12, 0);
            this.Clock.Multiline = true;
            this.Clock.Name = "Clock";
            this.Clock.Size = new System.Drawing.Size(800, 127);
            this.Clock.TabIndex = 0;
            this.Clock.Text = "00:00";
            this.Clock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Clock.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Day
            // 
            this.Day.BackColor = System.Drawing.Color.Black;
            this.Day.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Day.Font = new System.Drawing.Font("Microsoft Sans Serif", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Day.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Day.Location = new System.Drawing.Point(380, 131);
            this.Day.Multiline = true;
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(388, 58);
            this.Day.TabIndex = 1;
            this.Day.Text = "MONDAY";
            this.Day.TextChanged += new System.EventHandler(this.Day_TextChanged);
            // 
            // Date
            // 
            this.Date.BackColor = System.Drawing.SystemColors.WindowText;
            this.Date.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Date.Font = new System.Drawing.Font("Tw Cen MT", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Date.Location = new System.Drawing.Point(183, 133);
            this.Date.Multiline = true;
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(152, 58);
            this.Date.TabIndex = 2;
            this.Date.Text = "JAN 27";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(183, 294);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 57);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "00:00";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(183, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Set Alarm:";
            // 
            // MinDown
            // 
            this.MinDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinDown.Location = new System.Drawing.Point(252, 357);
            this.MinDown.Name = "MinDown";
            this.MinDown.Size = new System.Drawing.Size(43, 23);
            this.MinDown.TabIndex = 11;
            this.MinDown.Text = "˅";
            this.MinDown.UseVisualStyleBackColor = true;
            this.MinDown.Click += new System.EventHandler(this.MinDown_Click);
            // 
            // HourUp
            // 
            this.HourUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HourUp.Location = new System.Drawing.Point(188, 265);
            this.HourUp.Name = "HourUp";
            this.HourUp.Size = new System.Drawing.Size(43, 23);
            this.HourUp.TabIndex = 5;
            this.HourUp.Text = "˄";
            this.HourUp.UseVisualStyleBackColor = true;
            this.HourUp.Click += new System.EventHandler(this.HourUp_Click);
            // 
            // MinUp
            // 
            this.MinUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinUp.Location = new System.Drawing.Point(252, 265);
            this.MinUp.Name = "MinUp";
            this.MinUp.Size = new System.Drawing.Size(43, 23);
            this.MinUp.TabIndex = 12;
            this.MinUp.Text = "˄";
            this.MinUp.UseVisualStyleBackColor = true;
            this.MinUp.Click += new System.EventHandler(this.MinUp_Click);
            // 
            // HourDown
            // 
            this.HourDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HourDown.Location = new System.Drawing.Point(188, 357);
            this.HourDown.Name = "HourDown";
            this.HourDown.Size = new System.Drawing.Size(43, 23);
            this.HourDown.TabIndex = 13;
            this.HourDown.Text = "˅";
            this.HourDown.UseVisualStyleBackColor = true;
            this.HourDown.Click += new System.EventHandler(this.HourDown_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(312, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 28);
            this.button1.TabIndex = 14;
            this.button1.Text = "Set";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.WindowText;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(380, 255);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(187, 43);
            this.textBox2.TabIndex = 15;
            this.textBox2.Text = "Alarm Set To:";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.WindowText;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(380, 293);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(187, 87);
            this.textBox3.TabIndex = 16;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.HourDown);
            this.Controls.Add(this.MinUp);
            this.Controls.Add(this.MinDown);
            this.Controls.Add(this.HourUp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Day);
            this.Controls.Add(this.Clock);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Clock;
        private System.Windows.Forms.TextBox Day;
        private System.Windows.Forms.TextBox Date;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MinDown;
        private System.Windows.Forms.Button HourUp;
        private System.Windows.Forms.Button MinUp;
        private System.Windows.Forms.Button HourDown;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}

