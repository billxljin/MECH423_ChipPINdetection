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
using Emgu.CV.Shape;



namespace function_testing
{
    public partial class CV_Function_testing : Form
    {
        public CV_Function_testing()
        {
            InitializeComponent();
            this.btnPauseOrResume.Click += new EventHandler(btnPauseOrResume_Click);
        }

        VideoCapture capWebcam;
        bool blnCapturingInProcess = false;

        private void CV_Function_testing_Load(object sender, EventArgs e)
        {
            try
            {
                capWebcam = new VideoCapture(0); 
                capWebcam.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.XiLensFocusDistance, 4.0);
                capWebcam.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameHeight,1080.0);
                capWebcam.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameWidth,1920.0);

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
        } // CV_Function_testing_Load


        private void btnPauseOrResume_Click(object sender, EventArgs e)
        {
            if (blnCapturingInProcess == true)
            {                    // if we are currently processing an image, user just choose pause, so . . .
                Application.Idle -= processFrameAndUpdateGUI;       // remove the process image function from the application's list of tasks
                blnCapturingInProcess = false;                      // update flag variable
                btnPauseOrResume.Text = " Resume ";                 // update button text

            }
            else
            {                                                       // else if we are not currently processing an image, user just choose resume, so . . .
                Application.Idle += processFrameAndUpdateGUI;       // add the process image function to the application's list of tasks
                blnCapturingInProcess = true;                       // update flag variable
                btnPauseOrResume.Text = " Pause ";                  // new button will offer pause option
            }
        }//btnPauseOrResume_Click

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

            int FrameWidth = Convert.ToInt16(capWebcam.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameWidth));
            int FrameHeight =Convert.ToInt16(capWebcam.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameHeight));

            int diver = 3;
            int Width = 640;//(FrameWidth / diver);
            int Height = 360;//(FrameHeight /diver);

            Mat [,] pictureBlock = new Mat[3,3];

            for (int j = 0; j < diver; j++) // j height 
            {
                for (int i = 0; i < diver; i++) // i width
                {
                   // 1920 1080
                   //The drawing area is restricted to a rectangle beginning at (x,y), with width w and height h.
                   Rectangle roi = new Rectangle(Width * i, Height * j, Width, Height);  // area of interest Rectangle    
                   pictureBlock[i, j] = new Mat(imgOriginal, roi);
                    SelectAndShowOnImageBox(i, j, pictureBlock[i, j]);
                }
            }

            ibOriginal.Image = imgOriginal;          
            textBox_imageSize.AppendText(imgOriginal.Size.ToString());
            textBox_imageSize.AppendText(FrameHeight.ToString());
            textBox_imageSize.AppendText(FrameWidth.ToString());

            //Application.Idle -= processFrameAndUpdateGUI;
        } // processFrameAndUpdateGUI


        // 
        public void SelectAndShowOnImageBox(int i, int j, Mat pictureBlock)
        {
            if (j == 0)
            {
                switch (i)
                {
                    case 0: imageBox1_1.Image = pictureBlock; break;
                    case 1: imageBox1_2.Image = pictureBlock; ; break;
                    case 2: imageBox1_3.Image = pictureBlock; ; break;
                }
            }
            else if (j == 1)
            {
                switch (i)
                {
                    case 0: imageBox2_1.Image = pictureBlock; break;
                    case 1: imageBox2_2.Image = pictureBlock; ; break;
                    case 2: imageBox2_3.Image = pictureBlock; ; break;
                }
            }
            else if (j == 2)
            {
                switch (i)
                {
                    case 0: imageBox3_1.Image = pictureBlock; break;
                    case 1: imageBox3_2.Image = pictureBlock; ; break;
                    case 2: imageBox3_3.Image = pictureBlock; ; break;
                }
            }
        } //


    } // class
}// namespace
