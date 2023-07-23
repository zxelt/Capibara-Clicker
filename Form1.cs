using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace Capibara_Clicker
{
    public partial class Form1 : Form
    {
        private int point = 0;
        private int level = 0;
        private int Necessarypoints;
        public Form1()
        {
            InitializeComponent();
        }
        private void lvlplus()
        {
            Newlvl.Visible = true;
            level++;
            string lvl = level.ToString();
            Lvl.Text = $"Level: {lvl}";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            point++;
            label1.Text = point.ToString();
            if (point == 10)
            {
                lvlplus();
            }
            else if (point == 100)
            {
                lvlplus();
            }
            else if (point == 1000)
            {
                lvlplus();
            }
            else if (point == 10000)
            {
                lvlplus();
            }
            else if (point == 100000)
            {
                lvlplus();
            }
            else if (point == 1000000)
            {
                Newlvl.Text = "Stop cheating";
                Newlvl.ForeColor = Color.White;
                MessageBox.Show ("Cheat is bad");
            }
            else
            {
                Newlvl.Visible = false;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string lvl = level.ToString();
            Lvl.Text = $"Level {lvl}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Necessarypoints = 100;
            buy();

            label1.Text = point.ToString();
        }

        private void buy()
        {
            if (point >= Necessarypoints)
            {
                MessageBox.Show("Successful purchase !");
                point -= Necessarypoints;
                Capibara.Image = Capibara.ErrorImage;
            }
            else
            {

                Necessarypoints -= point;
                MessageBox.Show($"You don't have enough points you are {Necessarypoints} points short");
            }
        }
        private void buy1()
        {
            if (point >= Necessarypoints)
            {
                MessageBox.Show("Successful purchase !");
                point -= Necessarypoints;
                timer1.Enabled = true;
            }
            else
            {

                Necessarypoints -= point;
                MessageBox.Show($"You don't have enough points you are {Necessarypoints} points short");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            point -= point;
            label1.Text = point.ToString();
            Capibara.Image = Capibara.Image;
            MessageBox.Show("Reset successfully");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Necessarypoints = 10;
            buy1();
            label1.Text = point.ToString();
        }
    }
}
