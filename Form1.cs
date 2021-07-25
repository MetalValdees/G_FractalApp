using System;
using System.Drawing;
using System.Windows.Forms;

namespace G_FractalApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
        }

        // Глобальные переменные
        int PointX1, PointY1, PointX2, PointY2, PointX3, PointY3, PointX4, PointY4;
        int Steps = 1000, Delay = 1000;

        Bitmap bmp = new Bitmap(501, 501);

        Random rnd = new Random(DateTime.Now.Millisecond);

        // Ввод в TextBox только цифры
        private void Point1X_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void Point1Y_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void Point2X_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void Point2Y_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void Point3X_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void Point3Y_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void textBoxSteps_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void Point4X_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }


        private void Point4Y_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        // Не больше 500 и изменяет расположение
        private void Point1X_Leave(object sender, EventArgs e)
        {
            if (Point1X.Text == "")
            {
                Point1X.Text = "0";
            }
            int a = Convert.ToInt32(Point1X.Text);
            if (a > 500)
            {
                Point1X.Text = "500";
                a = 500;
            }
            bmp.SetPixel(PointX1, PointY1, Color.FromArgb(0, 0, 0));
            pictureBox1.Image = bmp;
            PointX1 = a;
            bmp.SetPixel(PointX1, PointY1, Color.FromArgb(255, 0, 0));
            pictureBox1.Image = bmp;
        }
        private void Point1Y_Leave(object sender, EventArgs e)
        {
            if (Point1Y.Text == "")
            {
                Point1Y.Text = "0";
            }
            int a = Convert.ToInt32(Point1Y.Text);
            if (a > 500)
            {
                Point1Y.Text = "500";
            }
            bmp.SetPixel(PointX1, PointY1, Color.FromArgb(0, 0, 0));
            pictureBox1.Image = bmp;
            PointY1 = a;
            bmp.SetPixel(PointX1, PointY1, Color.FromArgb(255, 0, 0));
            pictureBox1.Image = bmp;
        }

        private void Point2X_Leave(object sender, EventArgs e)
        {
            if (Point2X.Text == "")
            {
                Point2X.Text = "0";
            }
            int a = Convert.ToInt32(Point2X.Text);
            if (a > 500)
            {
                Point2X.Text = "500";
            }
            bmp.SetPixel(PointX2, PointY2, Color.FromArgb(0, 0, 0));
            pictureBox1.Image = bmp;
            PointX2 = a;
            bmp.SetPixel(PointX2, PointY2, Color.FromArgb(0, 255, 0));
            pictureBox1.Image = bmp;
        }

        private void Point2Y_Leave(object sender, EventArgs e)
        {
            if (Point2Y.Text == "")
            {
                Point2Y.Text = "0";
            }
            int a = Convert.ToInt32(Point2Y.Text);
            if (a > 500)
            {
                Point2Y.Text = "500";
            }
            bmp.SetPixel(PointX2, PointY2, Color.FromArgb(0, 0, 0));
            pictureBox1.Image = bmp;
            PointY2 = a;
            bmp.SetPixel(PointX2, PointY2, Color.FromArgb(0, 255, 0));
            pictureBox1.Image = bmp;
        }

        private void Point3X_Leave(object sender, EventArgs e)
        {
            if (Point3X.Text == "")
            {
                Point3X.Text = "0";
            }
            int a = Convert.ToInt32(Point3X.Text);
            if (a > 500)
            {
                Point3X.Text = "500";
            }
            bmp.SetPixel(PointX3, PointY3, Color.FromArgb(0, 0, 0));
            pictureBox1.Image = bmp;
            PointX3 = a;
            bmp.SetPixel(PointX3, PointY3, Color.FromArgb(0, 0, 255));
            pictureBox1.Image = bmp;
        }

        private void Point3Y_Leave(object sender, EventArgs e)
        {
            if (Point3Y.Text == "")
            {
                Point3Y.Text = "0";
            }
            int a = Convert.ToInt32(Point3Y.Text);
            if (a > 500)
            {
                Point3Y.Text = "500";
            }
            bmp.SetPixel(PointX3, PointY3, Color.FromArgb(0, 0, 0));
            pictureBox1.Image = bmp;
            PointY3 = a;
            bmp.SetPixel(PointX3, PointY3, Color.FromArgb(0, 0, 255));
            pictureBox1.Image = bmp;
        }


        private void Point4X_Leave(object sender, EventArgs e)
        {
            if (Point4X.Text == "")
            {
                Point4X.Text = "0";
            }
            int a = Convert.ToInt32(Point4X.Text);
            if (a > 500)
            {
                Point4X.Text = "500";
            }
            bmp.SetPixel(PointX4, PointY4, Color.FromArgb(0, 0, 0));
            pictureBox1.Image = bmp;
            PointX4 = a;
            bmp.SetPixel(PointX4, PointY4, Color.FromArgb(255, 0, 255));
            pictureBox1.Image = bmp;
        }

        private void Point4Y_Leave(object sender, EventArgs e)
        {
            if (Point4Y.Text == "")
            {
                Point4Y.Text = "0";
            }
            int a = Convert.ToInt32(Point4Y.Text);
            if (a > 500)
            {
                Point4Y.Text = "500";
            }
            bmp.SetPixel(PointX4, PointY4, Color.FromArgb(0, 0, 0));
            pictureBox1.Image = bmp;
            PointY4 = a;
            bmp.SetPixel(PointX4, PointY4, Color.FromArgb(255, 0, 255));
            pictureBox1.Image = bmp;
        }

        // Отображения координат курсора относительно PictureBox
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            int x = Convert.ToInt32(e.X);
            int y = Convert.ToInt32(e.Y);
            label13.Text = x.ToString() + " x " + y.ToString();
        }

        // Сохраняет координаты курсора относительно PictureBox, в выбранной точке
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            int x = Convert.ToInt32(e.X);
            int y = Convert.ToInt32(e.Y);
            if (Point1.Checked == true)
            {
                bmp.SetPixel(PointX1, PointY1, Color.FromArgb(0, 0, 0));
                pictureBox1.Image = bmp;
                PointX1 = x;
                PointY1 = y;
                Point1X.Text = x.ToString();
                Point1Y.Text = y.ToString();
                bmp.SetPixel(x, y, Color.FromArgb(255, 0, 0));
                pictureBox1.Image = bmp;
            }
            if (Point2.Checked == true)
            {
                bmp.SetPixel(PointX2, PointY2, Color.FromArgb(0, 0, 0));
                pictureBox1.Image = bmp;
                PointX2 = x;
                PointY2 = y;
                Point2X.Text = x.ToString();
                Point2Y.Text = y.ToString();
                bmp.SetPixel(x, y, Color.FromArgb(0, 255, 0));
                pictureBox1.Image = bmp;
            }
            if (Point3.Checked == true)
            {
                bmp.SetPixel(PointX3, PointY3, Color.FromArgb(0, 0, 0));
                pictureBox1.Image = bmp;
                PointX3 = x;
                PointY3 = y;
                Point3X.Text = x.ToString();
                Point3Y.Text = y.ToString();
                bmp.SetPixel(x, y, Color.FromArgb(0, 0, 255));
                pictureBox1.Image = bmp;
            }
            if (Point4.Checked == true)
            {
                bmp.SetPixel(PointX4, PointY4, Color.FromArgb(0, 0, 0));
                pictureBox1.Image = bmp;
                PointX4 = x;
                PointY4 = y;
                Point4X.Text = x.ToString();
                Point4Y.Text = y.ToString();
                bmp.SetPixel(x, y, Color.FromArgb(255, 0, 255));
                pictureBox1.Image = bmp;
            }
        }

        // Пуск
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            pictureBox1.Enabled = false;
            if (textBoxSteps.Text == "")
            {
                textBoxSteps.Text = "1000";
            }
            if (textBox1.Text == "")
            {
                textBox1.Text = "1000";
            }
            Delay = Convert.ToInt32(textBox1.Text);
            for (int a = 0, x = 0, y = 0 , X = 0, Y = 0, Steps = Convert.ToInt32(textBoxSteps.Text); a < Steps + 1 ; a++) 
            {
                if (a == 0)
                {
                    x = PointX4;
                    y = PointY4;
                }
                int R = rnd.Next(0, 7);
                // Красная точка PointX1, PointY1
                if (R == 1 || R == 2)
                {
                    X = x;
                    Y = y;
                    x = (PointX1 - x) / 2;
                    y = (PointY1 - y) / 2;
                    x = X + x;
                    y = Y + y;
                    bmp.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                }
                // Зелёная точка PointX2, PointY2
                if (R == 3 || R == 4)
                {
                    X = x;
                    Y = y;
                    x = (PointX2 - x) / 2;
                    y = (PointY2 - y) / 2;
                    x = X + x;
                    y = Y + y;
                    bmp.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                }
                // Синяя точка PointX3, PointY3
                if (R == 5 || R == 6)
                {
                    X = x;
                    Y = y;
                    x = (PointX3 - x) / 2;
                    y = (PointY3 - y) / 2;
                    x = X + x;
                    y = Y + y;
                    bmp.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                }
                pictureBox1.Image = bmp;
                System.Threading.Thread.Sleep(Delay);
            }            
        }

        // очистка экрана
        private void button4_Click(object sender, EventArgs e)
        {
            for (int a = 0; a < 501; a++)
            {
                for (int b = 0; b < 501; b++)
                {
                    if (bmp.GetPixel(a, b) == Color.FromArgb(255, 255, 255))
                    bmp.SetPixel(a, b, Color.FromArgb(0, 0, 0));
                }
            }
            pictureBox1.Image = bmp;
            button1.Enabled = true;
            pictureBox1.Enabled = true;
        }
    }
}
