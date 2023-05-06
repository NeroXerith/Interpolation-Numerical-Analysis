using System;
using System.Collections;
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
    public partial class User_D : Form
    {
         List<double> x_col = new List<double>();
         List<double> y_col = new List<double>();
         int numDataPoints = 0;
        public User_D()
        {
            InitializeComponent();
        }

        private void insertData()
        {
            btn_back.Location = new Point(791, -1);
            try
            {
                int numDataPoints;
                double x = double.Parse(txt_x.Text);
                double y = double.Parse(txt_y.Text);
                try
                {              
                    numDataPoints = Convert.ToInt32(txt_numpts.Text);
                    if (numDataPoints < 3)
                    {
                        MessageBox.Show("Invalid number of points!\n3 or greater than is feasible.", "Invalid Input!");
                        return;
                    }  else {
                        txt_numpts.Enabled = false;
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid input! Please enter a valid integer value.", "Invalid Input!");
                    return;
                }

                Size = new Size(835, 303);
                int index = dataGrid.Rows.Count;
                x_col.Add(x);
                y_col.Add(y);
                dataGrid.Rows.Add(index, x, y);
                txt_x.Clear();
                txt_y.Clear();
                txt_x.Focus();

                if (dataGrid.Rows.Count == numDataPoints+1)
                {
                    txt_pnX.Enabled = true;
                    txt_pnX.Focus();
                    btn_Insert.Enabled = false;
                    txt_x.Enabled = false;
                    txt_y.Enabled = false;
                    txt_numpts.Enabled = false;
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input! Please enter a valid integer value.", "Invalid Input!");
                txt_pnX.Clear();
                txt_x.Clear();
                txt_y.Clear();
            }
        }

        private void resetInputs() {
            Size = new Size(416, 324);
            btn_back.Location = new Point(373, -3);
            x_col.Clear();
            y_col.Clear();
            dataGrid.Rows.Clear();
            txt_numpts.Enabled = true;
            txt_pnX.Enabled = false;
            txt_x.Enabled = true;
            txt_y.Enabled = true;
            btn_Insert.Enabled = true;
            txt_numpts.Clear();
            txt_pnX.Clear();
            txt_x.Clear();
            txt_y.Clear();
        }

        private void calculate() {
            try
            {
                int n = x_col.Count;
                if (n < numDataPoints)
                {
                    throw new ArgumentException("Not enough inputs!");
                }

                dataGrid.Rows.Clear();
                double[] x = new double[n];
                double[] y = new double[n];

                for (int i = 0; i < n; i++)
                {
                    double xn = x_col[i];
                    double yn = y_col[i];

                    x[i] = xn;
                    y[i] = yn;

                    int rowIndex = i + 1;
                    if (i < numDataPoints)
                    {
                        dataGrid.Rows[i].SetValues(rowIndex, xn, yn);
                    }
                    else
                    {
                        dataGrid.Rows.Add(rowIndex, xn, yn);
                    }
                }

                double[] b = new double[n];
                double[,] dividedDifferences = new double[n, n];

                for (int i = 0; i < n; i++)
                {
                    dividedDifferences[i, 0] = y[i];
                }

                for (int j = 1; j < n; j++)
                {
                    for (int i = j; i < n; i++)
                    {
                        dividedDifferences[i, j] = (dividedDifferences[i, j - 1] - dividedDifferences[i - 1, j - 1]) / (x[i] - x[i - j]);
                    }
                }

                for (int j = 0; j < n; j++)
                {
                    b[j] = dividedDifferences[j, j];
                }

                double pnX = double.Parse(txt_pnX.Text);
                double calculated = b[0];

                for (int j = 1; j < n; j++)
                {
                    double term = b[j];

                    for (int i = 0; i < j; i++)
                    {
                        term *= (pnX - x[i]);
                    }
                    calculated += term;
                }       
                
                MessageBox.Show($"CALCULATION RESULT : \t\n\nPn({pnX}) = {calculated} ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_Insert_Click(object sender, EventArgs e)
        {
            insertData();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            resetInputs();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calculate();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Landing portal = new Landing();
            portal.Show();
            this.Hide();
        }

        private void User_D_Load(object sender, EventArgs e)
        {
          
        }
    }
}
