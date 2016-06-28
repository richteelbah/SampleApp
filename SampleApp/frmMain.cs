using System;
using System.Drawing;
using System.Windows.Forms;

namespace SampleApp
{
    public enum DrawShapes
    {
        Circle,
        Square,
        Rectangle,
        Line,
        Triangle,
        Ellipse
    }

    public partial class frmMain : Form
    {drdy
        #region Variables
        private Control drawingControl;
        private Random rndr = new Random();
        private Bitmap bmap;
        #endregion

        #region Event Handlers and Initialization
        public frmMain()
        {
            InitializeComponent();
            drawingControl = panDrawing;
            bmap = new Bitmap(Screen.FromControl(this).Bounds.Width, Screen.FromControl(this).Bounds.Height);
            cmdClear_Click(null, null);
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            using (Graphics g = Graphics.FromImage(bmap))
            {
                g.Clear(this.BackColor);
            }
            drawingControl.Invalidate();
        }

        private void cmdRandom_Click(object sender, EventArgs e)
        {
            int penWidth = GetRandomPenWidth();
            Color penColor = GetRandomColor();

            Point startPoint = GetRandomPoint(drawingControl);
            int radius = GetRandomRadius(drawingControl);
            Rectangle drawingBounds = new Rectangle();
            DrawShapes shape = GetRandomShape();

            using (Pen pen = new Pen(penColor, penWidth))
            //using (Graphics g = Graphics.FromHwnd(drawingControl.Handle))
            using (Graphics g = Graphics.FromImage(bmap))
            {
                switch (shape)
                {
                    case DrawShapes.Circle:
                        drawingBounds.X = startPoint.X - radius;
                        drawingBounds.Y = startPoint.Y - radius;
                        drawingBounds.Size = new Size(radius * 2, radius * 2);
                        g.DrawEllipse(pen, drawingBounds);
                        AppendDebugMessage("Circle " + PointToString(startPoint) + " r=" + radius.ToString());
                        break;
                    case DrawShapes.Ellipse:
                        drawingBounds.X = startPoint.X - radius;
                        drawingBounds.Y = startPoint.Y - radius;
                        drawingBounds.Size = new Size(GetRandomWidth(drawingControl), GetRandomHeight(drawingControl));
                        g.DrawEllipse(pen, drawingBounds);
                        AppendDebugMessage("Ellipse " + PointToString(drawingBounds.Location) + " w=" + drawingBounds.Width.ToString() + " h=" + drawingBounds.Height.ToString());
                        break;
                    case DrawShapes.Line:
                        Point endPoint = GetRandomPoint(drawingControl);
                        g.DrawLine(pen, startPoint, endPoint);
                        AppendDebugMessage("Line " + PointToString(startPoint) + " to " + PointToString(endPoint));
                        break;
                    case DrawShapes.Rectangle:
                        drawingBounds.Location = startPoint;
                        drawingBounds.Width = GetRandomWidth(drawingControl);
                        drawingBounds.Height = GetRandomHeight(drawingControl);
                        g.DrawRectangle(pen, drawingBounds);
                        AppendDebugMessage("Rectangle " + PointToString(drawingBounds.Location) + " w=" + drawingBounds.Width.ToString() + " h=" + drawingBounds.Height.ToString());
                        break;
                    case DrawShapes.Square:
                        drawingBounds.X = startPoint.X - radius;
                        drawingBounds.Y = startPoint.Y - radius;
                        drawingBounds.Size = new Size(radius * 2, radius * 2);
                        g.DrawRectangle(pen, drawingBounds);
                        AppendDebugMessage("Square " + PointToString(drawingBounds.Location) + " w=" + drawingBounds.Width.ToString() + " h=" + drawingBounds.Height.ToString());
                        break;
                    case DrawShapes.Triangle:
                        Point pointB = GetRandomPoint(drawingControl);
                        Point pointC = GetRandomPoint(drawingControl);
                        g.DrawLine(pen, startPoint, pointB);
                        g.DrawLine(pen, pointB, pointC);
                        g.DrawLine(pen, pointC, startPoint);
                        AppendDebugMessage("Triangle Point A " + PointToString(startPoint) + " Point B " + PointToString(startPoint) + " Point C " + PointToString(startPoint));
                        break;
                    default:
                        break;
                }
            }
            drawingControl.Invalidate();
        }

        private void cmdRefresh_Click(object sender, EventArgs e)
        {
            drawingControl.Invalidate();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                bmap.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }
        private void panDrawing_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bmap, Point.Empty);
        }
        #endregion

        #region private methods
        private void AppendDebugMessage(string msgTxt)
        {
            if(txtDebug.Text.Length > 0)
            {
                txtDebug.AppendText("\n");
            }
            txtDebug.AppendText(msgTxt);
        }

        private Color GetRandomColor()
        {
            int red = rndr.Next(0, 255);
            int green = rndr.Next(0, 255);
            int blue = rndr.Next(0, 255);

            Color retVal = Color.FromArgb(red, green, blue);

            return retVal;
        }

        private int GetRandomHeight(Control ctrl)
        {
            int retVal = ctrl.Height;

            retVal = rndr.Next(1, retVal);

            return retVal;
        }

        private int GetRandomPenWidth()
        {
            return rndr.Next(1, 5);
        }

        private Point GetRandomPoint(Control ctrl)
        {
            Point retVal = new Point();

            retVal.X = rndr.Next(0, ctrl.Width);
            retVal.Y = rndr.Next(0, ctrl.Height);

            return retVal;
        }

        private int GetRandomRadius(Control ctrl)
        {
            int retVal = ctrl.Width < ctrl.Height ? ctrl.Width : ctrl.Height;

            retVal = rndr.Next(1, retVal);

            return retVal;
        }

        private DrawShapes GetRandomShape()
        {
            Array values = Enum.GetValues(typeof(DrawShapes));
            DrawShapes retVal = (DrawShapes)values.GetValue(rndr.Next(values.Length));

            return retVal;
        }

        private int GetRandomWidth(Control ctrl)
        {
            int retVal = ctrl.Width;

            retVal = rndr.Next(1, retVal);

            return retVal;
        }
        private string PointToString(Point p)
        {
            return "(" + p.X.ToString() + ", " + p.Y.ToString() + ")";
        }
        #endregion
    }
}
