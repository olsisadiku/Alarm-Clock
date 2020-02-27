using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace AlarmClock
{
    public partial class Form1 : Form
    {
        string[] months;
        string[] day;
        public Form1()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();
            months = new string[] { "JAN", "FEB", "MAR","APR","MAY","JUN","JUL","AUG","SEP","OCT","NOV","DEC"};
            day = new string[] { "SUNDAY", "MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY", "SATURDAY" };
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            number = 1;
            number2 = 0;
            textBox1.Text = String.Format("0{0}:0{1}", number, number2);

            var date1 = DateTime.Now;
            if (date1.Second < 10 || date1.Minute < 10 || date1.Hour < 10)
            {
                if (date1.Second < 10 && date1.Minute > 9 && date1.Hour >9)
                {
                    Clock.Text = String.Format("{0}:{1}:0{2}", date1.Hour, date1.Minute, date1.Second);
                }
                if (date1.Minute < 10 && date1.Second >9 && date1.Hour > 9)
                {
                    Clock.Text = String.Format("{0}:0{1}:{2}", date1.Hour, date1.Minute, date1.Second);
                }
                if (date1.Minute < 10 && date1.Second < 10 && date1.Hour>9)
                {
                    Clock.Text = String.Format("{0}:0{1}:0{2}", date1.Hour, date1.Minute, date1.Second);
                }
                if (date1.Minute < 10 && date1.Second < 10 && date1.Hour < 10)
                {
                    Clock.Text = String.Format("0{0}:0{1}:0{2}", date1.Hour, date1.Minute, date1.Second);
                }
                if (date1.Minute < 10 && date1.Hour < 10 && date1.Second > 9)
                {
                    Clock.Text = String.Format("0{0}:0{1}:{2}", date1.Hour, date1.Minute, date1.Second);
                }
                if (date1.Hour < 10 && date1.Second > 9 && date1.Minute >9)
                {
                    Clock.Text = String.Format("0{0}:{1}:{2}", date1.Hour, date1.Minute, date1.Second);
                }
                if (date1.Hour < 10 && date1.Second < 10 && date1.Minute >9)
                {
                    Clock.Text = String.Format("0{0}:{1}:0{2}", date1.Hour, date1.Minute, date1.Second);
                }

            }
            else
            {
                Clock.Text = String.Format("{0}:{1}:{2}", date1.Hour, date1.Minute, date1.Second);
            }
            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = (950);
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            var date1 = DateTime.Now;
            if (date1.Second < 10 || date1.Minute < 10 || date1.Hour < 10)
            {
                if (date1.Second < 10 && date1.Minute > 9 && date1.Hour > 9)
                {
                    Clock.Text = String.Format("{0}:{1}:0{2}", date1.Hour, date1.Minute, date1.Second);
                }
                if (date1.Minute < 10 && date1.Second > 9 && date1.Hour > 9)
                {
                    Clock.Text = String.Format("{0}:0{1}:{2}", date1.Hour, date1.Minute, date1.Second);
                }
                if (date1.Minute < 10 && date1.Second < 10 && date1.Hour > 9)
                {
                    Clock.Text = String.Format("{0}:0{1}:0{2}", date1.Hour, date1.Minute, date1.Second);
                }
                if (date1.Minute < 10 && date1.Second < 10 && date1.Hour < 10)
                {
                    Clock.Text = String.Format("0{0}:0{1}:0{2}", date1.Hour, date1.Minute, date1.Second);
                }
                if (date1.Minute < 10 && date1.Hour < 10 && date1.Second > 9)
                {
                    Clock.Text = String.Format("0{0}:0{1}:{2}", date1.Hour, date1.Minute, date1.Second);
                }
                if (date1.Hour < 10 && date1.Second > 9 && date1.Minute > 9)
                {
                    Clock.Text = String.Format("0{0}:{1}:{2}", date1.Hour, date1.Minute, date1.Second);
                }
                if (date1.Hour < 10 && date1.Second < 10 && date1.Minute > 9)
                {
                    Clock.Text = String.Format("0{0}:{1}:0{2}", date1.Hour, date1.Minute, date1.Second);
                }

            }
            else
            {
                Clock.Text = String.Format("{0}:{1}:{2}", date1.Hour, date1.Minute, date1.Second);
            }
            if (date1.Hour == hour_setter && date1.Minute == minute_setter && date1.Second == 0)
            {
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=FU1svpfSErg");
            }
            Date.Text = String.Format("{0} {1}", months[date1.Month-1], date1.Day);
            Day.Text = date1.DayOfWeek.ToString().ToUpper();

        }
        int number;
        int number2;
        private void HourUp_Click(object sender, EventArgs e)
        {
            number++;
            if (number > 24)
            {
                number = 0;
            }
            if (number < 1)
            {
                number = 1;
            }
            if (number < 10)
            {
                textBox1.Text = String.Format("0{0}:{1}", number, number2);
            }
            if(number<10 && number2 < 10)
            {
                textBox1.Text = String.Format("0{0}:0{1}", number, number2);
            }
            if (number2 < 10 && number >= 10)
            {
                textBox1.Text = String.Format("{0}:0{1}", number, number2);
            }
                if (number2 > 9 && number > 9)
                {
                    textBox1.Text = String.Format("{0}:{1}", number, number2);
                }

            
        }

        private void HourDown_Click(object sender, EventArgs e)
        {
            number--;
            if (number < 1)
            {
                number = 1;
            }
            if (number < 10)
            {
                textBox1.Text = String.Format("0{0}:{1}", number, number2);
            }
            if (number < 10 && number2 < 10)
            {
                textBox1.Text = String.Format("0{0}:0{1}", number, number2);
            }
            if (number2 < 10 && number >= 10)
            {
                textBox1.Text = String.Format("{0}:0{1}", number, number2);

            }
            if (number2 > 9 && number > 9)
            {
                textBox1.Text = String.Format("{0}:{1}", number, number2);
            }



        }

        private void MinUp_Click(object sender, EventArgs e)
        {
            number2++;
            if(number2 > 59)
            {
                number++;
                number2 = 0;
            }
            if (number2 < 10)
            {
                textBox1.Text = String.Format("{0}:0{1}", number, number2);
            }
            if (number2 < 10 && number < 10)
            {
                textBox1.Text = String.Format("0{0}:0{1}", number, number2);
            }
            if (number < 10 && number2 >= 10)
            {
                textBox1.Text = String.Format("0{0}:{1}", number, number2);

            }
            if (number2 > 9 && number > 9)
            {
                textBox1.Text = String.Format("{0}:{1}", number, number2);
            }
        }

        private void MinDown_Click(object sender, EventArgs e)
        {
            number2--;
            if (number2 < 0)
            {
                number2 = 0;
            }
            if (number2 < 10)
            {
                textBox1.Text = String.Format("{0}:0{1}", number, number2);
            }
            if (number < 10 && number2 < 10)
            {
                textBox1.Text = String.Format("0{0}:0{1}", number, number2);
            }
            if (number < 10 && number2 >= 10)
            {
                textBox1.Text = String.Format("{0}:0{1}", number, number2);

            }
            if (number2 > 9 && number > 9)
            {
                textBox1.Text = String.Format("{0}:{1}", number, number2);
            }
        }
        int hour_setter;
        int minute_setter;
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hour_setter = number;
            minute_setter = number2;
            textBox3.Text = textBox1.Text;

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Day_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
