using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int cnt;
        private void xo_Click(object sender, EventArgs e)
        {
            Label item = (Label)sender;
            //item.Text = "X";
            item.Enabled = false;
            item.Font = new Font("Arial", 35);
            //item.BackColor = Color.BlueViolet;
            cnt++;
            if (cnt % 2==0)
            {
                item.Text = "X";
                item.BackColor = Color.BlueViolet;
            }
            else if (cnt % 2 == 1)
            {
                item.Text = "O";
                item.BackColor = Color.DeepPink;
            }
            if((label1.Text=="O" && label2.Text == "O" && label3.Text == "O") || 
                (label4.Text == "O" && label5.Text == "O" && label6.Text == "O") || (label7.Text == "O" && label8.Text == "O" && label9.Text == "O") || (label1.Text == "O" && label5.Text == "O" && label9.Text == "O") || (label3.Text == "O" && label5.Text == "O" && label7.Text == "O") || (label1.Text == "O" && label4.Text == "O" && label7.Text == "O") || (label2.Text == "O" && label5.Text == "O" && label8.Text == "O") || (label3.Text == "O" && label6.Text == "O" && label9.Text == "O"))
            {
                label10.Font = new Font("Arial", 25);
                label10.Text = "O WIN!";
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label1.Enabled = false;
            }
            if ((label1.Text == "X" && label2.Text == "X" && label3.Text == "X") || (label4.Text == "X" && label5.Text == "X" && label6.Text == "X") || (label7.Text == "X" && label8.Text == "X" && label9.Text == "X") || (label1.Text == "X" && label5.Text == "X" && label9.Text == "X") || (label3.Text == "X" && label5.Text == "X" && label7.Text == "X") || (label1.Text == "X" && label4.Text == "X" && label7.Text == "X") || (label2.Text == "X" && label5.Text == "X" && label8.Text == "X") || (label3.Text == "X" && label6.Text == "X" && label9.Text == "X"))
            {
                label10.Font = new Font("Arial", 25);
                label10.Text = "X WIN!";
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label1.Enabled = false;

            }

            if (cnt==8 && (label10.Text !="X WIN!" || label10.Text != "O WIN!"))
            {
                label10.Text = " Тағы ойнаңдар!";
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            List < Label>llist= new List<Label>();
            llist.Add(label1);
            llist.Add(label2);
            llist.Add(label3);
            llist.Add(label4);
            llist.Add(label5);
            llist.Add(label6);
            llist.Add(label7);
            llist.Add(label8);
            llist.Add(label9);
            llist.Add(label10);
            foreach(Label item in llist)
            {
                item.Text = "";
                item.Enabled = true;
                item.BackColor=Color.DarkGray;
            }


        }
    }
}
