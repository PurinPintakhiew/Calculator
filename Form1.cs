using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class cal : Form
    {
        public double num = 0;
        private char op;
        private bool clear;
        public cal()
        {
            InitializeComponent();
        }

        private void cal_Load(object sender, EventArgs e)
        {

        }

        private void btnC_Click(object sender, EventArgs e)
        {
            t1.Text = String.Empty;
            num = 0;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            chkClear();
            t1.Text = t1.Text + "1"; 
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            chkClear();
            t1.Text = t1.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            chkClear();
            t1.Text = t1.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            chkClear();
            t1.Text = t1.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            chkClear();
            t1.Text = t1.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            chkClear();
            t1.Text = t1.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            chkClear();
            t1.Text = t1.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            chkClear();
            t1.Text = t1.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            chkClear();
            t1.Text = t1.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            chkClear();
            t1.Text = t1.Text + "0";
        }

        private void cal_KeyPress(object sender, KeyPressEventArgs e)
        {
            chkClear();
            if ("+-x/".IndexOf(e.KeyChar) >= 0)
            {
                if (op != '\0') { compute(); }
                op = e.KeyChar;
                num = Convert.ToDouble(t1.Text);
            }
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                t1.Text = t1.Text + e.KeyChar;
            }
            if (e.KeyChar == '\b') if(t1.TextLength > 0) t1.Text = t1.Text.Remove(t1.TextLength-1,1);


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(op != '\0') { compute(); } 
            op = '+';
            num = Convert.ToDouble(t1.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (op != '\0') { compute(); }
            op = '-';
            num = Convert.ToDouble(t1.Text);
           
            
        }

        private void blnMultiply_Click(object sender, EventArgs e)
        {
            if (op != '\0') { compute(); }
            op = 'x';
            num = Convert.ToDouble(t1.Text);
           
           
        }

        private void btnDivition_Click(object sender, EventArgs e)
        {
            if (op != '\0') { compute(); }
            op = '/';
            num = Convert.ToDouble(t1.Text);
          
            
        }

        private void btnPoin_Click(object sender, EventArgs e)
        {
            t1.Text = t1.Text + ".";
        }

        private void btnEqaul_Click(object sender, EventArgs e)
        {
            compute();

        }

        private void chkClear()
        {

            if (op != '\0')
            {
                if (!clear)
                {
                    t1.Clear();
                    clear = true;          
                }
            }
        }

        private void blnCut_Click(object sender, EventArgs e)
        {
            if (t1.TextLength > 0) t1.Text = t1.Text.Remove(t1.TextLength - 1, 1);
        }
        private void compute()
        {
            switch (op)
            {
                case '+':
                    t1.Text = (num + Convert.ToDouble(t1.Text)).ToString();
                    break;
                case '-':
                    t1.Text = (num - Convert.ToDouble(t1.Text)).ToString();
                    break;
                case 'x':
                    t1.Text = (num * Convert.ToDouble(t1.Text)).ToString();
                    break;
                case '/':
                    t1.Text = (num / Convert.ToDouble(t1.Text)).ToString();
                    break;
            }
            clear = false;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
