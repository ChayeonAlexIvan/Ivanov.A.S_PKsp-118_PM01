using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        private string name;
        public Form1()
        {
            InitializeComponent();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
               
                webBrowser1.Navigate("about:blank");
                name = openFileDialog1.FileName;
                webBrowser1.Navigate(name);
                this.Size = new Size(820, 500);
                label1.Visible = true;
                label2.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                button1.Visible = true;
                toolStripStatusLabel1.Visible = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text);

            if ( ((y == 0.5) || (y == 0)) && (x == Math.Asin(y)))
            {
                MessageBox.Show("Точка на границе");
                toolStripStatusLabel1.Text = "Точка на границе";
            }
            else if (x < Math.PI && ((y < Math.Sin(x) && Math.Sin(x) < 0.5) || ((y < 0.5 && y > 0) && (Math.Sin(x) > 0.5))))
            {
                MessageBox.Show("Точка входит в закрашенную область область");
                toolStripStatusLabel1.Text = "Точка входит в закрашенную область область";
            }
            else
            {
                MessageBox.Show("Точка не входит в закрашенную область");
                toolStripStatusLabel1.Text = "Точка не входит в закрашенную область";
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }
    }
}
