using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleApp;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;

namespace Test_SampleApp
{
    [TestClass]
    public class Test_RandomShapeGenerator
    {
        #region Variables and Constants for Testing
        private int canvasWidth = 640;
        private int canvasHeight = 480;
        private const string file00 = "TestImage00.jpg";
        private const string file01 = "TestImage01.jpg";
        private const string file02 = "TestImage02.jpg";
        #endregion

        #region Test Methods
        [TestMethod]
        public void Test_GetRandomColor()
        {
            Form frmTest = new Form();
            Panel panCanvas = new Panel();
            panCanvas.Width = canvasWidth;
            panCanvas.Height = canvasHeight;
            frmTest.Controls.Add(panCanvas);
            RandomShapeGenerator shapeGenerator = new RandomShapeGenerator(panCanvas);

            MethodInfo randomColorMethod = GetRandomColorMethod(shapeGenerator);
            Color color01 = (Color)randomColorMethod.Invoke(shapeGenerator, null);
            Color color02 = (Color)randomColorMethod.Invoke(shapeGenerator, null);
            Assert.AreNotEqual(color01, color02, "Test_GetRandomColor: Ensure that colors are not the same.");
        }

        [TestMethod]
        public void Test_GetRandomHeight()
        {
            Form frmTest = new Form();
            Panel panCanvas = new Panel();
            panCanvas.Width = canvasWidth;
            panCanvas.Height = canvasHeight;
            frmTest.Controls.Add(panCanvas);
            RandomShapeGenerator shapeGenerator = new RandomShapeGenerator(panCanvas);

            MethodInfo randomHeightMethod = GetRandomHeightMethod(shapeGenerator);
            int height01 = (int)randomHeightMethod.Invoke(shapeGenerator, null);
            int height02 = (int)randomHeightMethod.Invoke(shapeGenerator, null);
            Assert.AreNotEqual(height01, height02, "Test_GetRandomHeight: Ensure that heights are not the same.");
            SetCanvasSize(frmTest);
            Assert.IsTrue(height01 <= canvasHeight, "Test_GetRandomHeight: Ensure that height01 is not greater than the canvas height.");
            Assert.IsTrue(height02 <= canvasHeight, "Test_GetRandomHeight: Ensure that height02 is not greater than the canvas height.");
        }

        [TestMethod]
        public void Test_GetRandomPenWidth()
        {
            Form frmTest = new Form();
            Panel panCanvas = new Panel();
            panCanvas.Width = canvasWidth;
            panCanvas.Height = canvasHeight;
            frmTest.Controls.Add(panCanvas);
            RandomShapeGenerator shapeGenerator = new RandomShapeGenerator(panCanvas);

            MethodInfo randomPenWidthMethod = GetRandomPenWidthMethod(shapeGenerator);
            int penWidth01 = (int)randomPenWidthMethod.Invoke(shapeGenerator, null);
            int penWidth02 = (int)randomPenWidthMethod.Invoke(shapeGenerator, null);
            // It is very possible that both pen widths are the same so if they are, lets try a few more times.
            int numOfAttempts = 0;
            while(penWidth01==penWidth02 && numOfAttempts < 5)
            {
                numOfAttempts++;
                penWidth02 = (int)randomPenWidthMethod.Invoke(shapeGenerator, null);
            }

            Assert.AreNotEqual(penWidth01, penWidth02, "Test_GetRandomPenWidth: Ensure that pen widths are not the same.");
        }

        [TestMethod]
        public void Test_GetRandomPoint()
        {
            Form frmTest = new Form();
            Panel panCanvas = new Panel();
            panCanvas.Width = canvasWidth;
            panCanvas.Height = canvasHeight;
            frmTest.Controls.Add(panCanvas);
            RandomShapeGenerator shapeGenerator = new RandomShapeGenerator(panCanvas);

            MethodInfo randomPointMethod = GetRandomPointMethod(shapeGenerator);
            Point point01 = (Point)randomPointMethod.Invoke(shapeGenerator, null);
            Point point02 = (Point)randomPointMethod.Invoke(shapeGenerator, null);
            Assert.AreNotEqual(point01, point02, "Test_GetRandomPoint: Ensure that points are not the same.");
            SetCanvasSize(frmTest);
            Assert.IsTrue(point01.X <= canvasWidth, "Test_GetRandomPoint: Ensure that point01.X is not greater than the canvas width.");
            Assert.IsTrue(point01.Y <= canvasHeight, "Test_GetRandomPoint: Ensure that point01.Y is not greater than the canvas height.");
            Assert.IsTrue(point02.X <= canvasWidth, "Test_GetRandomPoint: Ensure that point02.X is not greater than the canvas width.");
            Assert.IsTrue(point02.Y <= canvasHeight, "Test_GetRandomPoint: Ensure that point02.Y is not greater than the canvas height.");
        }

        [TestMethod]
        public void Test_GetRandomRadius()
        {
            Form frmTest = new Form();
            Panel panCanvas = new Panel();
            panCanvas.Width = canvasWidth;
            panCanvas.Height = canvasHeight;
            frmTest.Controls.Add(panCanvas);
            RandomShapeGenerator shapeGenerator = new RandomShapeGenerator(panCanvas);

            MethodInfo randomRadiusMethod = GetRandomRadiusMethod(shapeGenerator);
            int radius01 = (int)randomRadiusMethod.Invoke(shapeGenerator, null);
            int radius02 = (int)randomRadiusMethod.Invoke(shapeGenerator, null);
            Assert.AreNotEqual(radius01, radius02, "Test_GetRandomRadius: Ensure that radii are not the same.");
            SetCanvasSize(frmTest);
            Assert.IsTrue(radius01 <= (canvasWidth < canvasHeight ? canvasWidth : canvasHeight), "Test_GetRandomRadius: Ensure that radius01 is less than the minimum of canvas height and width.");
            Assert.IsTrue(radius02 <= (canvasWidth < canvasHeight ? canvasWidth : canvasHeight), "Test_GetRandomRadius: Ensure that radius02 is less than the minimum of canvas height and width.");
        }

        [TestMethod]
        public void Test_GetRandomShape()
        {
            Form frmTest = new Form();
            Panel panCanvas = new Panel();
            panCanvas.Width = canvasWidth;
            panCanvas.Height = canvasHeight;
            frmTest.Controls.Add(panCanvas);
            RandomShapeGenerator shapeGenerator = new RandomShapeGenerator(panCanvas);

            MethodInfo randomShapeMethod = GetRandomShapeMethod(shapeGenerator);
            DrawShapes shape01 = (DrawShapes)randomShapeMethod.Invoke(shapeGenerator, null);
            DrawShapes shape02 = (DrawShapes)randomShapeMethod.Invoke(shapeGenerator, null);
            // It is very possible that both shapes are the same so if they are, lets try a few more times.
            int numOfAttempts = 0;
            while (shape01 == shape02 && numOfAttempts < 5)
            {
                numOfAttempts++;
                shape02 = (DrawShapes)randomShapeMethod.Invoke(shapeGenerator, null);
            }

            Assert.AreNotEqual(shape01, shape02, "Test_GetRandomShape: Ensure that shapes are not the same.");
        }

        [TestMethod]
        public void Test_GetRandomWidth()
        {
            Form frmTest = new Form();
            Panel panCanvas = new Panel();
            panCanvas.Width = canvasWidth;
            panCanvas.Height = canvasHeight;
            frmTest.Controls.Add(panCanvas);
            RandomShapeGenerator shapeGenerator = new RandomShapeGenerator(panCanvas);

            MethodInfo randomWidthMethod = GetRandomWidthMethod(shapeGenerator);
            int width01 = (int)randomWidthMethod.Invoke(shapeGenerator, null);
            int width02 = (int)randomWidthMethod.Invoke(shapeGenerator, null);
            Assert.AreNotEqual(width01, width02, "Test_GetRandomWidth: Ensure that widths are not the same.");
            SetCanvasSize(frmTest);
            Assert.IsTrue(width01 < canvasWidth, "Test_GetRandomWidth: Ensure that width01 is not greater than the canvas width.");
            Assert.IsTrue(width02 < canvasWidth, "Test_GetRandomWidth: Ensure that width02 is not greater than the canvas width.");
        }

        [TestMethod]
        public void Test_SaveCanvasToFile()
        {
            Assert.IsTrue(RemoveTestImages(file00), "Test_SaveCanvasToFile: Ensure that test file00 does not exist.");
            Assert.IsTrue(RemoveTestImages(file01), "Test_SaveCanvasToFile: Ensure that test file01 does not exist.");
            Assert.IsTrue(RemoveTestImages(file02), "Test_SaveCanvasToFile: Ensure that test file02 does not exist.");

            Form frmTest = new Form();
            Panel panCanvas = new Panel();
            panCanvas.Width = canvasWidth;
            panCanvas.Height = canvasHeight;
            frmTest.Controls.Add(panCanvas);
            RandomShapeGenerator shapeGenerator = new RandomShapeGenerator(panCanvas);

            int numOfShapesToDraw = 25;

            shapeGenerator.SaveCanvasToFile(file00);
            string file00Md5 = GetFileMd5Hash(file00);

            GenerateRandomArt(shapeGenerator, numOfShapesToDraw);
            shapeGenerator.SaveCanvasToFile(file01);
            string file01Md5 = GetFileMd5Hash(file01);

            shapeGenerator.ClearCanvas();

            GenerateRandomArt(shapeGenerator, numOfShapesToDraw);
            shapeGenerator.SaveCanvasToFile(file02);
            string file02Md5 = GetFileMd5Hash(file02);

            Assert.AreNotEqual(file01Md5, file00Md5, "Test_SaveCanvasToFile: Ensure that test file01 is not a blank file.");
            Assert.AreNotEqual(file02Md5, file00Md5, "Test_SaveCanvasToFile: Ensure that test file02 is not a blank file.");
            Assert.AreNotEqual(file02Md5, file01Md5, "Test_SaveCanvasToFile: Ensure that test file01 is not the same as test file02.");

            Assert.IsTrue(RemoveTestImages(file00), "Test_SaveCanvasToFile: Ensure that test file00 does not exist.");
            Assert.IsTrue(RemoveTestImages(file01), "Test_SaveCanvasToFile: Ensure that test file01 does not exist.");
            Assert.IsTrue(RemoveTestImages(file02), "Test_SaveCanvasToFile: Ensure that test file02 does not exist.");
        }
        #endregion

        #region Private Methods to expose private methods in RandomShapeGenerator
        private MethodInfo GetRandomColorMethod(RandomShapeGenerator randomShapeGenerator)
        {
            return randomShapeGenerator.GetType().GetMethod("GetRandomColor",
                BindingFlags.NonPublic | BindingFlags.Instance, null, new Type[] { }, null);
        }

        private MethodInfo GetRandomHeightMethod(RandomShapeGenerator randomShapeGenerator)
        {
            return randomShapeGenerator.GetType().GetMethod("GetRandomHeight",
                BindingFlags.NonPublic | BindingFlags.Instance, null, new Type[] { }, null);
        }

        private MethodInfo GetRandomPenWidthMethod(RandomShapeGenerator randomShapeGenerator)
        {
            return randomShapeGenerator.GetType().GetMethod("GetRandomPenWidth",
                BindingFlags.NonPublic | BindingFlags.Instance, null, new Type[] { }, null);
        }

        private MethodInfo GetRandomPointMethod(RandomShapeGenerator randomShapeGenerator)
        {
            return randomShapeGenerator.GetType().GetMethod("GetRandomPoint",
                BindingFlags.NonPublic | BindingFlags.Instance, null, new Type[] { }, null);
        }

        private MethodInfo GetRandomRadiusMethod(RandomShapeGenerator randomShapeGenerator)
        {
            return randomShapeGenerator.GetType().GetMethod("GetRandomRadius",
                BindingFlags.NonPublic | BindingFlags.Instance, null, new Type[] { }, null);
        }

        private MethodInfo GetRandomShapeMethod(RandomShapeGenerator randomShapeGenerator)
        {
            return randomShapeGenerator.GetType().GetMethod("GetRandomShape",
                BindingFlags.NonPublic | BindingFlags.Instance, null, new Type[] { }, null);
        }

        private MethodInfo GetRandomWidthMethod(RandomShapeGenerator randomShapeGenerator)
        {
            return randomShapeGenerator.GetType().GetMethod("GetRandomWidth",
                BindingFlags.NonPublic | BindingFlags.Instance, null, new Type[] { }, null);
        }
        #endregion

        #region Private Helper Methods
        /// <summary>
        /// GenerateRandomArt will draw the number of random shapes specified by numberOfShapesToDraw
        /// </summary>
        /// <param name="shapeGenerator"></param>
        /// <param name="numberOfShapesToDraw"></param>
        private void GenerateRandomArt(RandomShapeGenerator shapeGenerator, int numberOfShapesToDraw)
        {
            for (int i = 0; i < numberOfShapesToDraw; i++)
            {
                shapeGenerator.DrawRandomShape();
            }
        }

        /// <summary>
        /// GetFileMd5Hash will get the MD5 checksum for a file. This method is used in test 
        /// procedures to check if files are the same.
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        private string GetFileMd5Hash(string fileName)
        {
            byte[] bytes;

            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(fileName))
                {
                    bytes = md5.ComputeHash(stream);
                }
            }

            StringBuilder result = new StringBuilder(bytes.Length * 2);

            for (int i = 0; i < bytes.Length; i++)
                result.Append(bytes[i].ToString("X2"));

            return result.ToString();
        }

        /// <summary>
        /// RemoveTestImages is used by test methods to remove files created during testing.
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        private bool RemoveTestImages(string fileName)
        {
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            if (!File.Exists(fileName))
            {
                return true;
            }
            return false;
        }

        private void SetCanvasSize(Form frm)
        {
            canvasWidth = Screen.FromControl(frm).Bounds.Width;
            canvasHeight = Screen.FromControl(frm).Bounds.Height;
        }
        #endregion
    }
}