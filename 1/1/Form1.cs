using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
    public partial class Form1 : Form
    {

        public List<Bitmap> galery = new List<Bitmap>();
        public Form1()
        {
            InitializeComponent();
            galery.Add(Properties.Resources.Image1);
            galery.Add(Properties.Resources.Image2);
            galery.Add(Properties.Resources.Image3);
            galery.Add(Properties.Resources.Image4);
            galery.Add(Properties.Resources.Image5);
            galery.Add(Properties.Resources.Image6);
            galery.Add(Properties.Resources.Image7);
            hoverButton1.pictures = galery;
            hoverButtonEllipse1.pictures = galery;
        }

        private void hoverButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
