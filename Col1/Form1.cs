using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Col1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double p1;
            Double p2;
            Double p3;
            Double w;

            p1 = 2.0;
            p1 = !radioButton2.Checked ? p1 : 3.0;
            p1 = !radioButton3.Checked ? p1 : 3.5;
            p1 = !radioButton4.Checked ? p1 : 4.0;
            p1 = !radioButton5.Checked ? p1 : 4.5;
            p1 = !radioButton6.Checked ? p1 : 5.0;

            p2 = 2.0;
            p2 = !radioButton8.Checked ? p2 : 3.0;
            p2 = !radioButton9.Checked ? p2 : 3.5;
            p2 = !radioButton10.Checked ? p2 : 4.0;
            p2 = !radioButton11.Checked ? p2 : 4.5;
            p2 = !radioButton12.Checked ? p2 : 5.0;

            p3 = 2.0;
            p3 = !radioButton14.Checked ? p3 : 3.0;
            p3 = !radioButton15.Checked ? p3 : 3.5;
            p3 = !radioButton16.Checked ? p3 : 4.0;
            p3 = !radioButton17.Checked ? p3 : 4.5;
            p3 = !radioButton18.Checked ? p3 : 5.0;

            if(p1 == 2 || p2 == 2 || p3 == 2)
            {
                MessageBox.Show("Nie mozna wyliczyć średniej","Masz nie zaliczony jeden przedmiot");
                return;
            }

            if (
                textBox1.Text == ""
                || textBox2.Text == ""
                || textBox3.Text == "")
            {
                MessageBox.Show("Nie podełeś danych studentów");
                return;
            }

            w = (p1 + p2 + p3) / 3;

            textBox4.Text = w.ToString("0.00");
            textBox5.Text = w > 4.01 ? "TAK" : "NIE";

            MessageBox.Show(
                "Student: " + textBox1.Text + " " + textBox2.Text + " o nr " + textBox3.Text
                + "\n"+"Posiada średnią: " + w.ToString("0.00")
                + "\n" + "I " + ( w > 4.01 ? "" : "nie ")+"dostał stypendium",
                "Ocenia i Stypendium"
           );

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            radioButton8.Checked = false;
            radioButton9.Checked = false;
            radioButton10.Checked = false;
            radioButton11.Checked = false;
            radioButton12.Checked = false;
            radioButton13.Checked = false;
            radioButton14.Checked = false;
            radioButton15.Checked = false;
            radioButton16.Checked = false;
            radioButton17.Checked = false;
            radioButton18.Checked = false;
        }

    }
}
