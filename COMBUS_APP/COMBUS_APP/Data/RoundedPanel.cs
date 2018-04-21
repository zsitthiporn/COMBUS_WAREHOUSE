﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Runtime.InteropServices;

namespace COMBUS_APP.Data
{
    class RoundedPanel : Panel
    {
        GraphicsPath GetRoundPath(RectangleF Rect, int radius)
        {
            float r2 = radius / 2f;
            GraphicsPath GraphPath = new GraphicsPath();

            GraphPath.AddArc(Rect.X, Rect.Y, radius, radius, 180, 90);
            GraphPath.AddLine(Rect.X + r2, Rect.Y, Rect.Width - r2, Rect.Y);
            GraphPath.AddArc(Rect.X + Rect.Width - radius, Rect.Y, radius, radius, 270, 90);
            GraphPath.AddLine(Rect.Width, Rect.Y + r2, Rect.Width, Rect.Height - r2);
            GraphPath.AddArc(Rect.X + Rect.Width - radius,
                                Rect.Y + Rect.Height - radius, radius, radius, 0, 90);
            GraphPath.AddLine(Rect.Width - r2, Rect.Height, Rect.X + r2, Rect.Height);
            GraphPath.AddArc(Rect.X, Rect.Y + Rect.Height - radius, radius, radius, 90, 90);
            GraphPath.AddLine(Rect.X, Rect.Height - r2, Rect.X, Rect.Y + r2);

            GraphPath.CloseFigure();
            return GraphPath;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            RectangleF Rect = new RectangleF(0, 0, this.Width, this.Height);
            GraphicsPath GraphPath = GetRoundPath(Rect, 10);
            this.Region = new Region(GraphPath);

            //color line
            //using (Pen pen = new Pen(Color.CadetBlue, 1.75f))
            //{
            //    pen.Alignment = PenAlignment.Inset;
            //    e.Graphics.DrawPath(pen, GraphPath);
            //}
        }
    }
    class RoundedButton : Button
    {
        GraphicsPath GetRoundPath(RectangleF Rect, int radius)
        {
            float r2 = radius / 2f;
            GraphicsPath GraphPath = new GraphicsPath();

            GraphPath.AddArc(Rect.X, Rect.Y, radius, radius, 180, 90);
            GraphPath.AddLine(Rect.X + r2, Rect.Y, Rect.Width - r2, Rect.Y);
            GraphPath.AddArc(Rect.X + Rect.Width - radius, Rect.Y, radius, radius, 270, 90);
            GraphPath.AddLine(Rect.Width, Rect.Y + r2, Rect.Width, Rect.Height - r2);
            GraphPath.AddArc(Rect.X + Rect.Width - radius,
                                Rect.Y + Rect.Height - radius, radius, radius, 0, 90);
            GraphPath.AddLine(Rect.Width - r2, Rect.Height, Rect.X + r2, Rect.Height);
            GraphPath.AddArc(Rect.X, Rect.Y + Rect.Height - radius, radius, radius, 90, 90);
            GraphPath.AddLine(Rect.X, Rect.Height - r2, Rect.X, Rect.Y + r2);

            GraphPath.CloseFigure();
            return GraphPath;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            RectangleF Rect = new RectangleF(0, 0, this.Width, this.Height);
            GraphicsPath GraphPath = GetRoundPath(Rect, 10);
            this.Region = new Region(GraphPath);

            //color line
            //using (Pen pen = new Pen(Color.CadetBlue, 1.75f))
            //{
            //    pen.Alignment = PenAlignment.Inset;
            //    e.Graphics.DrawPath(pen, GraphPath);
            //}
        }
    }
    //class RoundedTextBox : TextBox
    //{
    //    GraphicsPath GetRoundPath(RectangleF Rect, int radius)
    //    {
    //        float r2 = radius / 2f;
    //        GraphicsPath GraphPath = new GraphicsPath();

    //        GraphPath.AddArc(Rect.X, Rect.Y, radius, radius, 180, 90);
    //        GraphPath.AddArc(Rect.X + Rect.Width - radius, Rect.Y, radius, radius, 270, 90);
    //        GraphPath.AddArc(Rect.X + Rect.Width - radius,
    //                            Rect.Y + Rect.Height - radius, radius, radius, 0, 90);
    //        GraphPath.AddArc(Rect.X, Rect.Y + Rect.Height - radius, radius, radius, 90, 90);

    //        GraphPath.CloseFigure();
    //        return GraphPath;
    //    }

    //    protected override void OnPaint(PaintEventArgs e)
    //    {
    //        base.OnPaint(e);
    //        RectangleF Rect = new RectangleF(0, 0, this.Width, this.Height);
    //        GraphicsPath GraphPath = GetRoundPath(Rect, 30);
    //        this.Region = new Region(GraphPath);

    //        //using (Pen pen = new Pen(Color.CadetBlue, 1.75f))
    //        //{
    //        //    pen.Alignment = PenAlignment.Inset;
    //        //    e.Graphics.DrawPath(pen, GraphPath);
    //        //}



    //        //GraphicsPath GraphPath = new GraphicsPath();
    //        //GraphPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
    //        //this.Region = new Region(GraphPath);
    //        //base.OnPaint(e);
    //    }

    //}
    class RoundedProgressBar : ProgressBar
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x04;
                return cp;
            }
        }
    }

    class GradientPanel : Panel
    {
        public Color ColorTop { get; set; }
        public Color ColorBottom { get; set; }
        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush lgb = new LinearGradientBrush(this.ClientRectangle, this.ColorTop, this.ColorBottom, 90F);
            Graphics g = e.Graphics;
            g.FillRectangle(lgb, this.ClientRectangle);
            base.OnPaint(e);
        }
    }
}