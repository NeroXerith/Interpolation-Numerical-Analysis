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
    public partial class Landing : Form
    {
        public Landing()
        {
            InitializeComponent();
        }

        private void btn_predefiend_Click(object sender, EventArgs e)
        {
            Pre_D predefined = new Pre_D();
            predefined.Show();
            this.Hide();
        }

        private void btn_userdefined_Click(object sender, EventArgs e)
        {
            User_D userdefined = new User_D();
            userdefined.Show();
            this.Hide();
        }
    }
}
