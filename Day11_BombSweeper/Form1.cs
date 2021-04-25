using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day11_BombSweeper
{
    public partial class Form1 : Form
    {
        Button btn;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.btn == this.button1)
            {
                this.label1.Text = "BOOM";
                this.btn.BackColor = Color.Red;
            }
            else
            {
                this.button1.BackColor = Color.Green;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.btn == this.button2)
            {
                this.label1.Text = "BOOM";
                this.btn.BackColor = Color.Red;
            }
            else
            {
                this.button2.BackColor = Color.Green;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.btn == this.button5)
            {
                this.label1.Text = "BOOM";
                this.btn.BackColor = Color.Red;
            }
            else
            {
                this.button5.BackColor = Color.Green;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int rand = rnd.Next(0, 6);
            Button[] buttons = { this.button1, this.button2, this.button3, this.button4, this.button5, this.button6 };

            if (rand == 1)
                this.button1.Text = rand+"";

            this.btn = buttons[rand];

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.btn == this.button3)
            {
                this.label1.Text = "BOOM";
                this.btn.BackColor = Color.Red;
            }
            else
            {
                this.button3.BackColor = Color.Green;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.btn == this.button4)
            {
                this.label1.Text = "BOOM";
                this.btn.BackColor = Color.Red;
            }
            else
            {
                this.button4.BackColor = Color.Green;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (this.btn == this.button6)
            {
                this.label1.Text = "BOOM";
                this.btn.BackColor = Color.Red;
            }
            else
            {
                this.button6.BackColor = Color.Green;
            }
        }

        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    string[] row0 = { "11/22/1968", "29", "Revolution 9",
        //    "Beatles", "The Beatles [White Album]" };
        //    string[] row1 = { "1960", "6", "Fools Rush In",
        //    "Frank Sinatra", "Nice 'N' Easy" };
        //    string[] row2 = { "11/11/1971", "1", "One of These Days",
        //    "Pink Floyd", "Meddle" };
        //    string[] row3 = { "1988", "7", "Where Is My Mind?",
        //    "Pixies", "Surfer Rosa" };
        //    string[] row4 = { "5/1981", "9", "Can't Find My Mind",
        //    "Cramps", "Psychedelic Jungle" };
        //    string[] row5 = { "6/10/2003", "13",
        //    "Scatterbrain. (As Dead As Leaves.)",
        //    "Radiohead", "Hail to the Thief" };
        //    string[] row6 = { "6/30/1992", "3", "Dress", "P J Harvey", "Dry" };
        //    this.dataGridView1.Rows.Add(row0);
        //    this.dataGridView1.Rows.Add(row1);
        //    this.dataGridView1.Rows.Add(row2);
        //    this.dataGridView1.Rows.Add(row3);
        //    this.dataGridView1.Rows.Add(row4);
        //    this.dataGridView1.Rows.Add(row5);
        //    this.dataGridView1.Rows.Add(row6);

        //    this.dataGridView1.Columns[0].DisplayIndex = 3;
        //    this.dataGridView1.Columns[1].DisplayIndex = 4;
        //    this.dataGridView1.Columns[2].DisplayIndex = 0;
        //    this.dataGridView1.Columns[3].DisplayIndex = 1;
        //    this.dataGridView1.Columns[4].DisplayIndex = 2;
        //}
    }
}
