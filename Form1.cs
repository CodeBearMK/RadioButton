using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButton
{
    public partial class Form1 : Form
    {
        int Res = 0, N1, N2;

        public Form1()
        {
            InitializeComponent();
        }

        private void rdb1_CheckedChanged(object sender, EventArgs e)
        {
            lblOp.Text = "+";
            ClsTextBox();
        }

        private void rdb2_CheckedChanged(object sender, EventArgs e)
        {
            lblOp.Text = "-";
            ClsTextBox();
        }

        private void rdb3_CheckedChanged(object sender, EventArgs e)
        {
            lblOp.Text = "*";
            ClsTextBox();
        }

        private void rdb4_CheckedChanged(object sender, EventArgs e)
        {
            lblOp.Text = "/";
            ClsTextBox();
        }

        private void ClsTextBox()
        {
            txtN1.Text = "";
            txtN2.Text = "";
            lblAns.Text = "";
        }


        private void btnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                N1 = int.Parse(txtN1.Text);
                N2 = int.Parse(txtN2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("請輸入數值！", "錯誤訊息", MessageBoxButtons.OK);
                return;
            }

            if (lblOp.Text == "+") Res = N1 + N2;
            if (lblOp.Text == "-") Res = N1 - N2;
            if (lblOp.Text == "*") Res = N1 * N2;
            if (lblOp.Text == "/")
            {
                if (N2 == 0)
                {
                    MessageBox.Show("除數不能為零", "錯誤訊息", MessageBoxButtons.OK);
                    return;
                }
                Res = N1 / N2;
            }
            lblAns.Text = Res.ToString();
        }
    }
}
