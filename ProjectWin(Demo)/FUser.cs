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
    public partial class FUser : Form
    {
        private Form activeForm = null;

        public FUser()
        {
            InitializeComponent();
            openChildForm(new FHome());
            btnRegister.Hide();
        }
        
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            openChildForm(new FHome());
        }

        private void pictureBoxCart_Click(object sender, EventArgs e)
        {
            openChildForm(new FCart());
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            openChildForm(new FInfo());
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            openChildForm(new FProductCatalog());
        }

        private void btnMyProduct_Click(object sender, EventArgs e)
        {
            openChildForm(new FMyProduct());
        }
    }
}
