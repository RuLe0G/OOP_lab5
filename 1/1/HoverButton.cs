using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using _1.Properties;

namespace _1
{
    class HoverButton : Button
    {
        private Color color = Color.SkyBlue;
        private int i = 0;
        private string txt = "";
        private StringFormat stringFormat;
        private bool txtb = false;
        public List<Bitmap> pictures = new List<Bitmap>();
        //private Bitmap[] img = new Bitmap[7] { Resources.Image1, Resources.Image2, Resources.Image3, Resources.Image4, Resources.Image5, Resources.Image6, Resources.Image7 };
        // private string[] str = new string[7] { "Картинка 1", "Картинка 2", "Картинка 3", "Картинка 4", "Картинка 5", "Картинка 6", "Картинка 7"};
        public HoverButton() : base()
        {
            ForeColor = Color.White;
            Font = new Font("Microsoft YaHei UI",
             20.25F,
             FontStyle.Bold,
             GraphicsUnit.Point,
             0);
        }




        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            txtb = true;
            txt = "Картинка " + Convert.ToString(i + 1);
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            i += 1;
            if (i == pictures.Count)
                i = 0;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            txtb = false;
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            // получение картинки из ресурсов
            //Bitmap bitmap = null;

            //        bitmap = pictures[i];

            if (txtb == false)
            {
                txt = "";
            } else
                txt = "Картинка " + Convert.ToString(i + 1);
            // отрисовка картинки в точке (0,0)
            pe.Graphics.DrawImage(pictures[i], 0, 0, Size.Width, Size.Height);

            stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;


            pe.Graphics.DrawString(txt, Font, Brushes.Aqua, ClientRectangle, stringFormat);

        }

    }
}
