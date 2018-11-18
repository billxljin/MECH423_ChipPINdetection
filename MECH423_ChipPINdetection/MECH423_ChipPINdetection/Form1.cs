using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu.CV;                  //
using Emgu.CV.CvEnum;           // usual Emgu CV imports
using Emgu.CV.Structure;        //
using Emgu.CV.UI;               //
using Emgu.CV.Util;


namespace RedBallTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        VideoCapture capWebcam;
        bool blnCapturingInProcess = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                capWebcam = new VideoCapture(1);
                capWebcam.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.XiLensFocusDistance,1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("unable to read from webcam, error: " + Environment.NewLine + Environment.NewLine +
                                ex.Message + Environment.NewLine + Environment.NewLine +
                                "exiting program");
                Environment.Exit(0);
                return;
            }
            Application.Idle += processFrameAndUpdateGUI;       // add process image function to the application's list of tasks
            blnCapturingInProcess = true;
        }


        private void btnPauseOrResume_Click(object sender, EventArgs e)
        {
            if (blnCapturingInProcess == true)
            {                    // if we are currently processing an image, user just choose pause, so . . .
                Application.Idle -= processFrameAndUpdateGUI;       // remove the process image function from the application's list of tasks
                blnCapturingInProcess = false;                      // update flag variable
                btnPauseOrResume.Text = " Resume ";                 // update button text
            }
            else
            {                                                // else if we are not currently processing an image, user just choose resume, so . . .
                Application.Idle += processFrameAndUpdateGUI;       // add the process image function to the application's list of tasks
                blnCapturingInProcess = true;                       // update flag variable
                btnPauseOrResume.Text = " Pause ";                  // new button will offer pause option
            }
        }


        



        void processFrameAndUpdateGUI(object sender, EventArgs arg)
        {
                
            
            Mat imgOriginal;

            imgOriginal = capWebcam.QueryFrame(); // CvInvoke.Imread("chip_7.jpg"); // A Bgr image frame and pass one frame to a Mat varible //CvInvoke.Imread("chip_6.jpg");

            if (imgOriginal == null)
            {
                MessageBox.Show("unable to read from webcam" + Environment.NewLine + Environment.NewLine +
                                "exiting program");
                Environment.Exit(0);
                return;
            }

            /*  Mat Constructor (Size, DepthType, Int32) 
             *  DepthType:Mat element type;  Int32: channels
             * A RGB image is consist of 3 channels data.
             * HSV色系中指的是色调H，饱和度S，亮度V三个通道
            */
            textBox_imageSize.Text = imgOriginal.Size.ToString();
            Mat imgHSV        = new Mat(imgOriginal.Size, DepthType.Cv8U, 3); 
            Mat imgThreshLow  = new Mat(imgOriginal.Size, DepthType.Cv8U, 1); 
            Mat imgThreshHigh = new Mat(imgOriginal.Size, DepthType.Cv8U, 1); 
            Mat imgThresh     = new Mat(imgOriginal.Size, DepthType.Cv8U, 1);
            

            CvInvoke.CvtColor(imgOriginal, imgHSV, ColorConversion.Bgr2Hsv); // bgr to --- >H  S V

            CvInvoke.InRange(imgHSV, new ScalarArray(new MCvScalar(0, 0, 100)),   new ScalarArray(new MCvScalar(255, 130, 255)),  imgThreshLow);
            CvInvoke.InRange(imgHSV, new ScalarArray(new MCvScalar(120, 200, 10)), new ScalarArray(new MCvScalar(135, 255, 15)), imgThreshHigh);
            CvInvoke.Add(imgThreshLow, imgThreshHigh, imgThresh);

            //testing
            ibOriginal.Image = imgOriginal;

            ibHSV.Image = imgHSV;


            ibThreshlow.Image = imgThreshLow;
            ibThreshhigh.Image = imgThreshHigh;
            CvInvoke.GaussianBlur(imgThresh, imgThresh, new Size(3, 3), 0);
            ibGussian.Image = imgThresh;
            //
   

            Mat structuringElement = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new Size(5, 1), new Point(-1, -1));
            Mat structuringElement2 = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new Size(10, 10), new Point(-1, -1));


            CvInvoke.Erode(imgThresh, imgThresh, structuringElement, new Point(-1, -1), 1, BorderType.Default, new MCvScalar(0, 0, 0));
            ibAfterDandErosion.Image = imgThresh;

            CvInvoke.Dilate(imgThresh, imgThresh, structuringElement2, new Point(-1, -1), 1, BorderType.Default, new MCvScalar(0, 0, 0));
            ibAfterDilation.Image = imgThresh;

            CvInvoke.GaussianBlur(imgThresh, imgThresh, new Size(9, 9), 0);
            ibGussian.Image = imgThresh;

            List<Triangle2DF> triangleList = new List<Triangle2DF>();
            List<RotatedRect> boxList = new List<RotatedRect>(); //a box is a rotated rectangle



            // ---------------------------------------------------------------------------------------
            // #region Canny and edge detection 
            double cannyThreshold = 3;
            double cannyThresholdLinking = 9;
            UMat cannyEdges = new UMat();
            CvInvoke.Canny(imgThresh, cannyEdges, cannyThreshold, cannyThresholdLinking,3);

            LineSegment2D[] lines = CvInvoke.HoughLinesP(
               cannyEdges,
               1, //Distance resolution in pixel-related units
               Math.PI / 45.0, //Angle resolution measured in radians.
               20, //threshold
               30, //min Line width
               10); //gap between lines

            //--------------------------------------------------------------------------------------------
            // find counters and then find retangular
            using (VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint())
            {
                CvInvoke.FindContours(cannyEdges, contours, null, RetrType.List, ChainApproxMethod.ChainApproxSimple);
                int count = contours.Size;
                for (int i = 0; i < count; i++)
                {
                    using (VectorOfPoint contour = contours[i])
                    using (VectorOfPoint approxContour = new VectorOfPoint())
                    {
                        CvInvoke.ApproxPolyDP(contour, approxContour, CvInvoke.ArcLength(contour, true) * 0.05, true);
                        if (CvInvoke.ContourArea(approxContour, false) > 250) //only consider contours with area greater than 250
                        {
                            if (approxContour.Size == 3) //The contour has 3 vertices, it is a triangle
                            {
                                Point[] pts = approxContour.ToArray();
                                triangleList.Add(new Triangle2DF(
                                   pts[0],
                                   pts[1],
                                   pts[2]
                                   ));
                            }
                            else if (approxContour.Size == 4) //The contour has 4 vertices.
                            {
                                #region determine if all the angles in the contour are within [80, 100] degree
                                bool isRectangle = true;
                                Point[] pts = approxContour.ToArray();
                                LineSegment2D[] edges = PointCollection.PolyLine(pts, true);

                                for (int j = 0; j < edges.Length; j++)
                                {
                                    double angle = Math.Abs(
                                       edges[(j + 1) % edges.Length].GetExteriorAngleDegree(edges[j]));
                                    if (angle < 80 || angle > 100)
                                    {
                                        isRectangle = false;
                                        break;
                                    }
                                }
                                #endregion

                                if (isRectangle) boxList.Add(CvInvoke.MinAreaRect(approxContour));
                            }
                        }
                    }
                }
            }

            Image<Bgr, Byte> img = new Image<Bgr, byte>("chip_7.jpg");

            #region draw triangles and rectangles
            Image<Bgr, Byte> triangleRectangleImage = img.CopyBlank();
            foreach (Triangle2DF triangle in triangleList)
                triangleRectangleImage.Draw(triangle, new Bgr(Color.DarkBlue), 2);
            foreach (RotatedRect box in boxList)
                triangleRectangleImage.Draw(box, new Bgr(Color.DarkOrange), 2);

            //triangleRectangleImageBox.Image = imgThresh;
            triangleRectangleImageBox.Image = triangleRectangleImage;
            #endregion


            ibThresh.Image = imgThresh;


        }
    }// end class
}// end namespace

/*
            CircleF[] circles = CvInvoke.HoughCircles(imgThresh, HoughType.Gradient, 2.0, imgThresh.Rows / 4, 100, 50, 10, 400);

            foreach (CircleF circle in circles)
            {
                if (txtXYRadius.Text != "")
                {                         // if we are not on the first line in the text box
                    txtXYRadius.AppendText(Environment.NewLine);         // then insert a new line char
                }

                txtXYRadius.AppendText("ball position x = " + circle.Center.X.ToString().PadLeft(4) + ", y = " + circle.Center.Y.ToString().PadLeft(4) + ", radius = " + circle.Radius.ToString("###.000").PadLeft(7));
                txtXYRadius.ScrollToCaret();             // scroll down in text box so most recent line added (at the bottom) will be shown

                CvInvoke.Circle(imgOriginal, new Point((int)circle.Center.X, (int)circle.Center.Y), (int)circle.Radius, new MCvScalar(0, 0, 255), 2);
                CvInvoke.Circle(imgOriginal, new Point((int)circle.Center.X, (int)circle.Center.Y), 3, new MCvScalar(0, 255, 0), -1);
            }
*/