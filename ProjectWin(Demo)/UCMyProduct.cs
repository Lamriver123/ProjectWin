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
    public partial class UCMyProduct : UserControl
    {
        public UCMyProduct()
        {
            InitializeComponent();
        }

        private void pcbDelete_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.BackColor = Color.Linen;
        }

        private void pcbDelete_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            this.BackColor = Color.Bisque;
        }
    }
}
