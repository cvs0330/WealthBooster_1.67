using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public static class ControlExtensions
{
    public static void SetRoundedRegion(this Control control, int radius)
    {
        control.Paint += (sender, e) =>
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                RectangleF buttonRect = new RectangleF(0, 0, control.Width - 1, control.Height - 1);
                path.AddRoundRect(buttonRect, radius);

                using (Pen pen = new Pen(control.ForeColor))
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.DrawPath(pen, path);
                }
            }
        };

        control.Region = new Region(RoundRect(control.ClientRectangle, radius));
        control.Invalidate();
    }

    private static GraphicsPath RoundRect(RectangleF rectangle, float radius)
    {
        float diameter = radius * 2;
        SizeF size = new SizeF(diameter, diameter);
        RectangleF arcRect = new RectangleF(rectangle.Location, size);

        GraphicsPath path = new GraphicsPath();
        path.AddArc(arcRect, 180, 90);
        arcRect.X = rectangle.Right - diameter;
        path.AddArc(arcRect, 270, 90);
        arcRect.Y = rectangle.Bottom - diameter;
        path.AddArc(arcRect, 0, 90);
        arcRect.X = rectangle.Left;
        path.AddArc(arcRect, 90, 90);
        path.CloseFigure();

        return path;
    }

    private static void AddRoundRect(this GraphicsPath path, RectangleF rectangle, float radius)
    {
        float diameter = radius * 2;
        SizeF size = new SizeF(diameter, diameter);
        RectangleF arcRect = new RectangleF(rectangle.Location, size);

        path.AddArc(arcRect, 180, 90);
        arcRect.X = rectangle.Right - diameter;
        path.AddArc(arcRect, 270, 90);
        arcRect.Y = rectangle.Bottom - diameter;
        path.AddArc(arcRect, 0, 90);
        arcRect.X = rectangle.Left;
        path.AddArc(arcRect, 90, 90);
        path.CloseFigure();
    }
}
