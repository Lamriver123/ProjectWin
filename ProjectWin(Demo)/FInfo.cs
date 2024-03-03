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
    public partial class FInfo : Form
    {
        public FInfo()
        {
            InitializeComponent();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            btnInfo.ForeColor = Color.DarkCyan;
            btnHistory.ForeColor = Color.Black;
            btnRevenue.ForeColor = Color.Black;
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            btnInfo.ForeColor = Color.Black;
            btnHistory.ForeColor = Color.DarkCyan;
            btnRevenue.ForeColor = Color.Black;
        }

        private void btnRevenue_Click(object sender, EventArgs e)
        {
            btnInfo.ForeColor = Color.Black;
            btnHistory.ForeColor = Color.Black;
            btnRevenue.ForeColor = Color.DarkCyan;
        }
    }
}
