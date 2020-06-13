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
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.hoverButton1 = new _1.HoverButton();
            this.hoverButtonEllipse1 = new _1.HoverButtonEllipse();
            this.SuspendLayout();
            // 
            // hoverButton1
            // 
            this.hoverButton1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoverButton1.ForeColor = System.Drawing.Color.White;
            this.hoverButton1.Location = new System.Drawing.Point(13, 12);
            this.hoverButton1.Name = "hoverButton1";
            this.hoverButton1.Size = new System.Drawing.Size(382, 426);
            this.hoverButton1.TabIndex = 2;
            this.hoverButton1.Text = "hoverButton1";
            this.hoverButton1.UseVisualStyleBackColor = true;
            this.hoverButton1.Click += new System.EventHandler(this.hoverButton1_Click);
            // 
            // hoverButtonEllipse1
            // 
            this.hoverButtonEllipse1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoverButtonEllipse1.ForeColor = System.Drawing.Color.White;
            this.hoverButtonEllipse1.Location = new System.Drawing.Point(411, 12);
            this.hoverButtonEllipse1.Name = "hoverButtonEllipse1";
            this.hoverButtonEllipse1.Size = new System.Drawing.Size(377, 426);
            this.hoverButtonEllipse1.TabIndex = 1;
            this.hoverButtonEllipse1.Text = "hoverButtonEllipse1";
            this.hoverButtonEllipse1.UseVisualStyleBackColor = true;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hoverButton1);
            this.Controls.Add(this.hoverButtonEllipse1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private HoverButtonEllipse hoverButtonEllipse1;
        private HoverButton hoverButton1;
    }
}

