using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace my_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int msecs = Convert.ToInt32(miniseconds.Text);
            int secs = Convert.ToInt32(seconds.Text);
            int mins = Convert.ToInt32(minutes.Text);
            int hrs = Convert.ToInt32(hours.Text);
            
            
            

            msecs = msecs + 1;
            miniseconds.Text = msecs.ToString();

            if (msecs >= 60)
            {
                miniseconds.Text = "00";
                secs= secs + 1;
                seconds.Text = secs.ToString();

            }
            else if (secs >= 60)
            {
                seconds.Text = "00";
                mins = mins + 1;
                minutes.Text = mins.ToString();
            }
            else if (mins >= 60)
            {
                minutes.Text = "00";
                hrs = hrs + 1;
                hours.Text = hrs.ToString();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled=false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true ;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            miniseconds.Text = "00";
            seconds.Text = "00";
            minutes.Text = "00";
            hours.Text = "00";
            timer1.Enabled = false;
        }
    }
}
