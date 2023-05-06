using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Machine_problem3
{
    public partial class Pre_D : Form
    {
        public Pre_D()
        {
            InitializeComponent();
        }

        private void Pre_D_Load(object sender, EventArgs e)
        {
            /* PRE DEFINED POINTS VALUE BASED ON STOCKS DATA
            Source: https://www.investagrams.com/Chart/PSE:ECP */
            dataGrid.Rows.Add("January", "1", "6.90");
            dataGrid.Rows.Add("February", "2", "6.80");
            dataGrid.Rows.Add("March", "3", "6.60");
            dataGrid.Rows.Add("April", "4", "6.40");
            dataGrid.Rows.Add("May", "5", "6.19");
            dataGrid.Rows.Add("June", "6", "6");
            dataGrid.Rows.Add("July", "7", "5.31");
            dataGrid.Rows.Add("August", "8", "5.30");
            dataGrid.Rows.Add("September", "9", "5.5");
            dataGrid.Rows.Add("October", "10", "4.55");
            dataGrid.Rows.Add("November", "11", "4.60");
            dataGrid.Rows.Add("December", "12", "4.20");

        }

        private void Calculate() {
            //Initialize x and y points data set using arrays (x, y)
            double[] x = {1,2,3,4,5,6,7,8,9,10,11,12};
            double[] y = {6.90, 6.80, 6.60, 6.40, 6.19,6, 5.31, 5.30, 5.5, 4.55, 4.60, 4.20};

            int n = y.Length;
            double[,] dividedDifference = new double[n, n];
            for (int i = 0; i < n; i++)
            {
                dividedDifference[i, 0] = y[i];
            }

            for (int j = 1; j < n; j++)
            {
                for (int i = 0; i < n - j; i++)
                {
                    dividedDifference[i, j] = (dividedDifference[i + 1, j - 1] - dividedDifference[i, j - 1]) / (x[i + j] - x[i]);
                }
            }

            double pnX = double.Parse(txt_xValue.Text);
            double calculated = dividedDifference[0, 0];
            double[] solve = new double[n];
            solve[0] = 1;
            for (int i = 1; i < n; i++)
            {
                solve[i] = solve[i - 1] * (pnX - x[i - 1]);
                calculated += dividedDifference[0, i] * solve[i];
            }
            calculated = Math.Round(calculated, 4);

            MessageBox.Show($"CALCULATION RESULT : \t\n\nPn({pnX}) = {calculated} ");
            if (isToggled)
            {
                btn_toggle.Text = "Show Data ▽";
                Size = new Size(399, 303);
                label1.Location = new Point(139, 124);
                txt_xValue.Location = new Point(86, 152);
                btn_back.Location = new Point(681, -3);
                btn_tsubmit.Visible = false;
                btn_treset.Visible = false;
                dataGrid.Visible = false;
                btn_submit.Visible = true;
                btn_reset.Visible = true;
                linkLabel1.Visible = false;
                isToggled = false;
            }
            txt_xValue.Clear();
        }
        private void btn_submit_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        Boolean isToggled = false;
        private void btn_toggle_Click(object sender, EventArgs e)
        {
            if (!isToggled)
            {
                btn_toggle.Text = "HIDE DATA △";
                Size = new Size(725, 384);
                label1.Location = new Point(134, 143);
                txt_xValue.Location = new Point(81, 171);
                btn_submit.Visible = false;
                btn_reset.Visible = false;
                btn_treset.Visible = true;
                btn_tsubmit.Visible = true;
                btn_back.Location = new Point(681, -3);
                dataGrid.Visible = true;
                linkLabel1.Visible = true;
                dataGrid.Location = new Point(350, 17);
                isToggled = true;
            } else
            {
                btn_toggle.Text = "SHOW DATA ▽";
                label1.Location = new Point(139, 124);
                txt_xValue.Location = new Point(86, 152);
                btn_treset.Visible = false;
                btn_tsubmit.Visible = false;
                btn_submit.Visible = true;
                btn_reset.Visible = true;
                btn_back.Location = new Point(343, -3);
                Size = new Size(399, 303);
                dataGrid.Visible = false;
                linkLabel1.Visible = false;
                isToggled = false;
            }
            
        }

        private void btn_back_MouseHover(object sender, EventArgs e)
        {
            btn_back.ForeColor = Color.White;
        }

        private void btn_back_MouseLeave(object sender, EventArgs e)
        {
            btn_back.ForeColor = Color.DimGray;
        }

        private void btn_tsubmit_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_xValue.Clear();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.investagrams.com/Chart/PSE:ECP");
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Landing portal = new Landing();
            portal.Show();
            this.Hide();
        }
    }
}
