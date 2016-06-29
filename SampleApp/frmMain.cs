using System;
using System.Drawing;
using System.Windows.Forms;

namespace SampleApp
{
    public partial class frmMain : Form
    {
        private RandomShapeGenerator shapeGenerator;
        public frmMain()
        {
            InitializeComponent();

            shapeGenerator = new RandomShapeGenerator(panDrawing);
            AutoScrollMinSize = Screen.FromControl(this).Bounds.Size;
            cmdClear_Click(null, null);
        }

        #region Event Handlers
        private void cmdClear_Click(object sender, EventArgs e)
        {
            shapeGenerator.ClearCanvas();
        }

        private void cmdHideDebug_Click(object sender, EventArgs e)
        {
            cmdHideDebug.Text = Properties.Resources.debugHide;

            txtDebug.Visible = !txtDebug.Visible;

            if (!txtDebug.Visible)
            {
                cmdHideDebug.Text = Properties.Resources.debugShow;
            }
        }

        private void cmdRandom_Click(object sender, EventArgs e)
        {
            AppendDebugMessage(shapeGenerator.DrawRandomShape());
        }

        private void cmdRefresh_Click(object sender, EventArgs e)
        {
            shapeGenerator.RefreshCanvas();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                shapeGenerator.SaveCanvasToFile(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }

        private void panDrawing_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(shapeGenerator.Bmap, Point.Empty);
        }
        #endregion

        private void AppendDebugMessage(string msgTxt)
        {
            if (txtDebug.Text.Length > 0)
            {
                txtDebug.AppendText("\n");
            }
            txtDebug.AppendText(msgTxt);
        }
    }
}
