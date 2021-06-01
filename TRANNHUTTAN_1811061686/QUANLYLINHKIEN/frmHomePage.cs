using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using QUANLYLINHKIEN.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace QUANLYLINHKIEN
{
    public partial class frmHomePage : Form
    {
        public frmHomePage()
        {
            InitializeComponent();
            LoadHotProduct();
        }
        QLLKDB context = new QLLKDB();
        private void LoadHotProduct()
        {
            var list = context.LINHKIENs.Select(p => p.HINHANH).ToList();
            Random rd = new Random();
            for (int i = 0; i < 30; i++)
            {
                int index = rd.Next(0, list.Count);
                Image img = ByteToImage(list[index]);
                imgSlider.Images.Add(img);
                Thread.Sleep(10);
            }

        }
        private Image ByteToImage(byte[] bytedata)
        {
            using (MemoryStream ms = new MemoryStream(bytedata))
            {
                return Image.FromStream(ms);
            }
        }
    }
}