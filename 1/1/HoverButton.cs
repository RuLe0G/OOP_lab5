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
        private int i = 1;
        private string txt;
        private StringFormat stringFormat;
        private bool txtb = false;

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
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (i == 7)
                i = 0;
            i += 1;
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
            Bitmap bitmap = null;

            switch (i)
            {
                case 1:
                    bitmap = new Bitmap(Resources.Image1);
                    txt = "Картинка 1";
                    break;
                case 2:
                    bitmap = new Bitmap(Resources.Image2);
                    txt = "Картинка 2";
                    break;
                case 3:
                    bitmap = new Bitmap(Resources.Image3);
                    txt = "Картинка 3";
                    break;
                case 4:
                    bitmap = new Bitmap(Resources.Image4);
                    txt = "Картинка 4";
                    break;
                case 5:
                    bitmap = new Bitmap(Resources.Image5);
                    txt = "Картинка 5";
                    break;
                case 6:
                    bitmap = new Bitmap(Resources.Image6);
                    txt = "Картинка 6";
                    break;
                case 7:
                    bitmap = new Bitmap(Resources.Image7);
                    txt = "Картинка 7";
                    break;
            }
            if (txtb == false)
            {
                txt = "";
            }
            // отрисовка картинки в точке (0,0)
            pe.Graphics.DrawImage(bitmap, 0, 0, 10, Size.Height);

            stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;


            pe.Graphics.DrawString(txt, Font, Brushes.Aqua, ClientRectangle, stringFormat);

        }

    }
}
