using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Font =new Font("Arial", 11);
            button2.ForeColor = Color.Red;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            textBox2.Text = rnd.Next(1, 1000).ToString();
            textBox3.Text = rnd.Next(1, 1000).ToString();
            textBox4.Text = rnd.Next(1, 1000).ToString();
            checkBox1.Checked = false;
            checkBox2.Checked = true;
            checkBox3.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (object objekt in panel1.Controls)
            {
                if (objekt is TextBox)
                {
                    (objekt as TextBox).Text = "";
                }
                if (objekt is CheckBox)
                {
                    (objekt as CheckBox).Checked = false;
                }
                if (objekt is Button)
                {
                    (objekt as Button).Visible = true;
                    (objekt as Button).Font = new Font("Microsoft Sans Serif",8);
                    (objekt as Button).ForeColor=Color.Black;
                 (objekt as Button).Enabled = true;
                }
            }
        }

        private void panel1_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            this.Text = "CHANGE";
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            this.Text = "Program";
        }

        private void button4_VisibleChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
        }

        private void button3_VisibleChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
        }

        private void button2_VisibleChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
        }
    }
    }
    


