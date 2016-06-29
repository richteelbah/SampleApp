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

    public class RandomShapeGenerator
    {
        private Control _drawingControl;
        private Random rndr = new Random();
        private Bitmap _bmap;

        public Control DrawingControl
        {
            get
            {
                return _drawingControl;
            }

            set
            {
                _drawingControl = value;
            }
        }

        public Bitmap Bmap
        {
            get
            {
                return _bmap;
            }

            set
            {
                _bmap = value;
            }
        }

        public RandomShapeGenerator(Control canvas)
        {
            _drawingControl = canvas;
            _bmap = new Bitmap(Screen.FromControl(_drawingControl.FindForm()).Bounds.Width, Screen.FromControl(_drawingControl.FindForm()).Bounds.Height);
        }

        #region Public Methods
        public void ClearCanvas()
        {
            using (Graphics g = Graphics.FromImage(_bmap))
            {
                g.Clear(_drawingControl.FindForm().BackColor);
            }
            _drawingControl.Invalidate();
        }

        public string DrawRandomShape()
        {
            string retVal = string.Empty;

            int penWidth = GetRandomPenWidth();
            Color penColor = GetRandomColor();

            Point startPoint = GetRandomPoint();
            int radius = GetRandomRadius();
            Rectangle drawingBounds = new Rectangle();
            DrawShapes shape = GetRandomShape();

            using (Pen pen = new Pen(penColor, penWidth))
            using (Graphics g = Graphics.FromImage(_bmap))
            {
                switch (shape)
                {
                    case DrawShapes.Circle:
                        drawingBounds.X = startPoint.X - radius;
                        drawingBounds.Y = startPoint.Y - radius;
                        drawingBounds.Size = new Size(radius * 2, radius * 2);
                        g.DrawEllipse(pen, drawingBounds);
                        retVal = "Circle " + PointToString(startPoint) + " r=" + radius.ToString();
                        break;
                    case DrawShapes.Ellipse:
                        drawingBounds.X = startPoint.X - radius;
                        drawingBounds.Y = startPoint.Y - radius;
                        drawingBounds.Size = new Size(GetRandomWidth(), GetRandomHeight());
                        g.DrawEllipse(pen, drawingBounds);
                        retVal = "Ellipse " + PointToString(drawingBounds.Location) + " w=" + drawingBounds.Width.ToString() + " h=" + drawingBounds.Height.ToString();
                        break;
                    case DrawShapes.Line:
                        Point endPoint = GetRandomPoint();
                        g.DrawLine(pen, startPoint, endPoint);
                        retVal = "Line " + PointToString(startPoint) + " to " + PointToString(endPoint);
                        break;
                    case DrawShapes.Rectangle:
                        drawingBounds.Location = startPoint;
                        drawingBounds.Width = GetRandomWidth();
                        drawingBounds.Height = GetRandomHeight();
                        g.DrawRectangle(pen, drawingBounds);
                        retVal = "Rectangle " + PointToString(drawingBounds.Location) + " w=" + drawingBounds.Width.ToString() + " h=" + drawingBounds.Height.ToString();
                        break;
                    case DrawShapes.Square:
                        drawingBounds.X = startPoint.X - radius;
                        drawingBounds.Y = startPoint.Y - radius;
                        drawingBounds.Size = new Size(radius * 2, radius * 2);
                        g.DrawRectangle(pen, drawingBounds);
                        retVal = "Square " + PointToString(drawingBounds.Location) + " w=" + drawingBounds.Width.ToString() + " h=" + drawingBounds.Height.ToString();
                        break;
                    case DrawShapes.Triangle:
                        Point pointB = GetRandomPoint();
                        Point pointC = GetRandomPoint();
                        g.DrawLine(pen, startPoint, pointB);
                        g.DrawLine(pen, pointB, pointC);
                        g.DrawLine(pen, pointC, startPoint);
                        retVal = "Triangle Point A " + PointToString(startPoint) + " Point B " + PointToString(startPoint) + " Point C " + PointToString(startPoint);
                        break;
                    default:
                        break;
                }
            }
            _drawingControl.Invalidate();

            return retVal;
        }

        public void RefreshCanvas()
        {
            _drawingControl.Invalidate();
        }

        public void SaveCanvasToFile(string fileName)
        {
            SaveCanvasToFile(fileName, System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        public void SaveCanvasToFile(string fileName, System.Drawing.Imaging.ImageFormat imageFormat)
        {
            _bmap.Save(fileName, imageFormat);
        }
        #endregion

        #region Private Methods
        private Color GetRandomColor()
        {
            int red = rndr.Next(0, 255);
            int green = rndr.Next(0, 255);
            int blue = rndr.Next(0, 255);

            Color retVal = Color.FromArgb(red, green, blue);

            return retVal;
        }

        private int GetRandomHeight()
        {
            int retVal = _bmap.Height;

            retVal = rndr.Next(1, retVal);

            return retVal;
        }

        private int GetRandomPenWidth()
        {
            return rndr.Next(1, 5);
        }

        private Point GetRandomPoint()
        {
            Point retVal = new Point();

            retVal.X = rndr.Next(0, _bmap.Width);
            retVal.Y = rndr.Next(0, _bmap.Height);

            return retVal;
        }

        private int GetRandomRadius()
        {
            int retVal = _bmap.Width < _bmap.Height ? _bmap.Width : _bmap.Height;

            retVal = rndr.Next(1, retVal);

            return retVal;
        }

        private DrawShapes GetRandomShape()
        {
            Array values = Enum.GetValues(typeof(DrawShapes));
            DrawShapes retVal = (DrawShapes)values.GetValue(rndr.Next(values.Length));

            return retVal;
        }

        private int GetRandomWidth()
        {
            int retVal = _bmap.Width;

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
