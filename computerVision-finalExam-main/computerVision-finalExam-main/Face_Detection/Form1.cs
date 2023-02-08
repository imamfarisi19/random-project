using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;

namespace Face_Detection
{
    public partial class Form1 : Form
    {
        Image<Bgr, byte> imgInput;
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imgInput = new Image<Bgr, byte>(dialog.FileName);
                    pictureBox1.Image = imgInput.ToBitmap();
                }
                else
                {
                    throw new Exception("No file selected");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void detectFaceHaarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (imgInput == null)
                {
                    throw new Exception("Please select an image");
                }

                DetectFaceHaar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DetectFaceHaar()
        {
            try
            {
                string facePath = Path.GetFullPath(@"../../data-open-cv/haarcascade_frontalface_default.xml");
                string eyePath = Path.GetFullPath(@"../../data-open-cv/haarcascade_eye.xml");

                CascadeClassifier classifierFace = new CascadeClassifier(facePath);
                CascadeClassifier classifierEye = new CascadeClassifier(eyePath);

                var imgGray = imgInput.Convert<Gray, byte>().Clone();
                Rectangle [] faces = classifierFace.DetectMultiScale(imgGray,1.1,4);
                foreach (var face in faces)
                {
                    imgInput.Draw(face, new Bgr(0, 0, 255), 2);
                    imgGray.ROI = face;
                    Rectangle[] eyes =  classifierEye.DetectMultiScale(imgGray, 1.1, 4);
                    foreach (var eye in eyes)
                    {
                        var e = eye;
                        e.X += face.X;
                        e.Y += face.Y;
                        imgInput.Draw(e, new Bgr(0, 255, 0), 2);
                    }
                }
                pictureBox1.Image = imgInput.ToBitmap();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void DetectFaceLBP()
        {
            try
            {
                string facePath = Path.GetFullPath(@"../../data-open-cv/lbpcascade_frontalface.xml");

                CascadeClassifier classifierFace = new CascadeClassifier(facePath);

                var imgGray = imgInput.Convert<Gray, byte>().Clone();
                Rectangle[] faces = classifierFace.DetectMultiScale(imgGray, 1.1, 4);
                foreach (var face in faces)
                {
                    imgInput.Draw(face, new Bgr(255,0,0), 2);
                }
                pictureBox1.Image = imgInput.ToBitmap();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void detectFaceLBPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (imgInput == null)
                {
                    throw new Exception("Please select an image");
                }

                DetectFaceLBP();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

      private void Form1_Load(object sender, EventArgs e)
      {

      }
   }
}
