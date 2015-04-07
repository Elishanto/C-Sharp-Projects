using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            num("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            num("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            num("3");
        }
        private void button6_Click(object sender, EventArgs e)
        {
            num("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            num("5");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            num("6");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            num("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            num("8");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            num("9");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            num("0");
        }
        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
            else
            {

            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label1_Changed(object sender, EventArgs e)
        {
            
        }
        double a;
        double b;
        int choice;
        private void umn_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            choice = 1;
        }

        private void del_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            choice = 2;
        }
        private void plus_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            choice = 3;
        }

        private void min_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            choice = 4;
        }
        String result;
        private async void equals_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null && textBox1.Text != "")
            {
                b = Convert.ToDouble(textBox1.Text);
            }
            else
            {

            }
            if (choice == 1)
            {
                result = Convert.ToString(a * b);
                textBox1.Text = result;
            }
            else if (choice == 2)
            {
                result = Convert.ToString(a / b);
                textBox1.Text = result;
            }
            else if (choice == 3)
            {
                result = Convert.ToString(a + b);
                textBox1.Text = result;
            }
            else if (choice == 4)
            {
                result = Convert.ToString(a - b);
                textBox1.Text = result;
            }
            else if (textBox1.Text == "7355608")
            {
                pictureBox1.Enabled = true;
                pictureBox1.Visible = true;
                await Task.Delay(3000);
                pictureBox1.Enabled = false;
                pictureBox1.Visible = false;
                addEgg();
            }
            else if (textBox1.Text == "1337")
            {
                this.Hide();
                Admin f2 = new Admin();
                f2.Show();
            }
            else
            {
                
            }
        }
        private void num(String a)
        {
            if (textBox1.Text == result)
            {
                textBox1.Text = "";
                textBox1.Text += a;
            }
            else
            {
                textBox1.Text += a;
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        private void addEgg()
        {
            string response = SendRequest("http://elishanto.ru/addEgg.php");
        }
        private string SendRequest(string url)
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    return client.DownloadString(new Uri(url));
                }
            }
            catch (WebException ex)
            {
                MessageBox.Show("Error while receiving data from the server:\n" + ex.Message, "Something broke.. :(", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return null;
            }
        }
    }
}
