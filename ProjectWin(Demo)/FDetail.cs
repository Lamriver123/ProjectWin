using ProjectWin_Demo_.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ProjectWin_Demo_
{
    public partial class FDetail : Form
    {
        public FDetail()
        {
            InitializeComponent();

        }
        List<string> imgList = new List<string>() { "1", "2", "3" };
        int curr = 0;
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (curr < 2)
                curr++;
            else
                curr = 0;
            //Bitmap bitmap;// = new Bitmap(Application.StartupPath + "\\Resources\\"  + imgList[curr] + ".jpg");
            //bitmap = new Bitmap("C: \\Users\\User\\Desktop\\ProjectWin\\ProjectWin\\ProjectWin(Demo)\\Resources\\1.jpg");
            pctProduct.Image = new Bitmap("D:\\lapTrinhWinhdow\\a\\ProjectWin\\ProjectWin(Demo)\\Resources\\" + imgList[curr] + ".jpg");
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            if (curr > 0)
                curr--;
            else
                curr = 2;
            pctProduct.Image = new Bitmap("D:\\lapTrinhWinhdow\\a\\ProjectWin\\ProjectWin(Demo)\\Resources\\" + imgList[curr] + ".jpg");
        }
    }
}