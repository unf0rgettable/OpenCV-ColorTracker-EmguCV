using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;
using Emgu.CV.CvEnum;
using Emgu.CV.VideoSurveillance;

namespace ControlWC
{
    public partial class Form1 : Form
    {
        //Ссылка для захвата видео с камеры
        private Capture cap;        
        //Детектор объектов
        private HaarCascade haar;

        //Для хранения каналов HSV
        private int h_plane, s_plane, v_plane;
        //Для хранения шага HSV
        private int h_shag, s_shag, v_shag;

        int x_Screen, y_Screen;
        int x_Cam = 480, y_Cam = 640;
        double x_Koeficent, y_Koeficent;

        Point nullPoint;



        public Form1()
        {
            nullPoint = new Point(0, 0);
            InitializeComponent();
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.StartPosition = FormStartPosition.CenterScreen;

            Rectangle screen = Screen.PrimaryScreen.Bounds;
            x_Screen = screen.Width;
            y_Screen = screen.Height;
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBoxWC_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Загрузка данных с TrackBar=============================
            labelH.Text = "H " + trackBar1.Value + " to " + trackBar1.Value + h_shag;
            labelS.Text = "S " + trackBar2.Value + " to " + trackBar2.Value + s_shag;
            labelV.Text = "V " + trackBar3.Value + " to " + trackBar3.Value + v_shag;
            h_plane = trackBar1.Value;
            s_plane = trackBar2.Value;
            v_plane = trackBar3.Value;

            h_shag = Convert.ToInt32(textBoxH.Text);
            s_shag = Convert.ToInt32(textBoxS.Text);
            v_shag = Convert.ToInt32(textBoxV.Text);
            //=======================================================

            //Получение камеры по индексу
            cap = new Capture(0);
            pictureBoxWC.Size = new Size(cap.Width, cap.Height);
            pictureBoxWC.Location = new Point(0, 0);
            pictureBoxBMP.Size = new Size(cap.Width, cap.Height);
            pictureBoxBMP.Location = new Point(cap.Width, 0);
            //Получение размерности камеры
            label2.Text = Convert.ToString(cap.Width) + "x" + Convert.ToString(cap.Height);
            x_Cam = cap.Width;
            y_Cam = cap.Height;

            x_Koeficent = (double)x_Screen / x_Cam;
            y_Koeficent = (double)y_Screen / y_Cam;
            //Подключение файла для поиска лица
            //haar = new HaarCascade("haarcascade_frontalface_default.xml");
            haar = new HaarCascade("haarcascade_frontalface_default.xml");

        }

        private void LBCams_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            trackBar1.Maximum = 256 - h_shag;
            trackBar2.Maximum = 256 - s_shag;
            trackBar3.Maximum = 256 - v_shag;
            using (Image<Bgr, byte> nextFrame = cap.QueryFrame())
            {
                if (nextFrame != null)
                {
                    nextFrame.Flip(FLIP.HORIZONTAL);
                    //Получение черно белой картинки для лица
                    Image<Gray, byte> grayframe = nextFrame.Convert<Gray, byte>();

                    grayframe.SmoothGaussian(3);

                    //Получение черно белой картинки для Маркера
                    Image<Gray, byte> grayframe2 = nextFrame.Convert<Gray, byte>();

                    grayframe2.SmoothGaussian(3);

                    //Получение картинка в формате HSV
                    Image<Hsv, byte> HSV = nextFrame.Convert<Hsv, byte>();

                    HSV.SmoothGaussian(3);

                    //Если нажат флажок включить окна для настройки цвета
                    if (checkBoxWindows.Checked)
                    {
                        //разбитие hsv на три части H S V
                        Image<Gray, byte>[] channels = HSV.Split();
                        try
                        {
                            CvInvoke.cvInRangeS(channels[0], new Gray(h_plane).MCvScalar, new Gray(h_plane + h_shag).MCvScalar, channels[0]);
                            CvInvoke.cvInRangeS(channels[1], new Gray(s_plane).MCvScalar, new Gray(s_plane + s_shag).MCvScalar, channels[1]);
                            CvInvoke.cvInRangeS(channels[2], new Gray(v_plane).MCvScalar, new Gray(v_plane + v_shag).MCvScalar, channels[2]);
                            //--------------------------------

                            pictureBoxH.Image = channels[0].ToBitmap();
                            pictureBoxS.Image = channels[1].ToBitmap();
                            pictureBoxV.Image = channels[2].ToBitmap();

                            //Сбор всех каналов воедино побитовой И

                            if (checkBoxS.Checked && checkBoxV.Checked)
                                channels[0] = channels[0] & channels[1] & channels[2];
                            else if (checkBoxS.Checked)
                                channels[0] = channels[0] & channels[1];
                            else if (checkBoxV.Checked)
                                channels[0] = channels[0] & channels[2];

                            pictureBoxBMP.Image = channels[0].ToBitmap();
                        }
                        finally
                        {
                            channels[0].Dispose();     
                            channels[1].Dispose();
                            channels[2].Dispose();
                        }
                    }
                    else
                    {
                        if(checkBoxS.Checked && checkBoxV.Checked)
                            CvInvoke.cvInRangeS(HSV, new MCvScalar(h_plane, s_plane, v_plane), new MCvScalar(h_plane + h_shag, s_plane + s_shag, v_plane + v_shag), grayframe2);
                        else if(checkBoxS.Checked)
                            CvInvoke.cvInRangeS(HSV, new MCvScalar(h_plane, s_plane, 0), new MCvScalar(h_plane + h_shag, s_plane + s_shag, 256), grayframe2);
                        else if(checkBoxV.Checked)
                            CvInvoke.cvInRangeS(HSV, new MCvScalar(h_plane, 0, v_plane), new MCvScalar(h_plane + h_shag, 256, v_plane + v_shag), grayframe2);
                        else
                            CvInvoke.cvInRangeS(HSV, new MCvScalar(h_plane, 0, 0), new MCvScalar(h_plane + h_shag, 256, 256), grayframe2);


                        //grayframe2 = grayframe2.Canny(new Gray(90), new Gray(100));

                        grayframe2 = grayframe2.Canny(new Gray(90), new Gray(100));

                        pictureBoxBMP.Image = grayframe2.ToBitmap();
                        
                        Contour<Point> contour_points = grayframe2.FindContours(/*ChainApproxNone*/CHAIN_APPROX_METHOD.CV_LINK_RUNS, RETR_TYPE.CV_RETR_CCOMP);

                        

                        if (contour_points != null)
                        {
                            
                            contour_points.GetConvexHull(ORIENTATION.CV_COUNTER_CLOCKWISE);

                            label2.Text = "" + contour_points.Count();

                            Rectangle Rect = contour_points.BoundingRectangle;

                            Graphics gr = pictureBoxBMP.CreateGraphics();
                            gr.DrawRectangle(new Pen(Brushes.Red), Rect);

                            //Позиция на экране
                            if (checkBox1.Checked)
                            {
                                int X = (int)((Rect.X + Rect.Width / 2)  * x_Koeficent);
                                int Y = (int)((Rect.Y + Rect.Height / 2)  * y_Koeficent);

                                //От случайных смещений
                                Point point = new Point(x_Screen - X, Y);
                                if (Math.Abs(point.X - nullPoint.X) < 3 && Math.Abs(point.Y - nullPoint.Y) < 3)
                                {
                                    nullPoint = point;
                                }
                                else
                                {
                                    Cursor.Position = point;
                                    nullPoint = point;
                                }


                            }
                        }
                    }


                    if (checkBox2.Checked)
                    {
                        var faces = grayframe.DetectHaarCascade(haar, 1.1, 3, HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(nextFrame.Width / 15, nextFrame.Height / 15))[0];

                        label1.Text = "Обнаружено лиц: " + faces.Length;
                        foreach (var face in faces)
                        {
                            nextFrame.Draw(face.rect, new Bgr(0, double.MaxValue, 0), 3);
                        }
                        pictureBoxWC.Image = nextFrame.ToBitmap();
                    }

                }
            }
        }

        private void TextBoxH_TextChanged(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            labelH.Text = "H " + trackBar1.Value + " to " + (trackBar1.Value + h_shag);
            h_plane = trackBar1.Value;

            
            
        }

        private void TrackBar2_Scroll(object sender, EventArgs e)
        {
            labelS.Text = "S " + trackBar2.Value + " to " + (trackBar2.Value + s_shag);
            s_plane = trackBar2.Value;
        }

        private void TrackBar3_Scroll(object sender, EventArgs e)
        {
            labelV.Text = "V " + trackBar3.Value + " to " + (trackBar3.Value + v_shag);
            v_plane = trackBar3.Value;
        }
    }
}
