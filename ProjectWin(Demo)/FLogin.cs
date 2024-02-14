using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWin_Demo_
{
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
            pnlSignUp.Hide();
        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            pnlLogin.Hide();
            pnlSignUp.Show();
        }
        private void lblExitSignUp_Click(object sender, EventArgs e)
        {
            
            pnlLogin.Show();
            pnlSignUp.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new FUser();
            form.ShowDialog();
            this.Show();
        }
    }
}
