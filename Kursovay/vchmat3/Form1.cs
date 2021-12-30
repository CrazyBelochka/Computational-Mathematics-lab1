using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Globalization;

namespace vchmat6

{
    public partial class Form1 : Form
    {
        Airplane a1 = new Airplane();
        string writePath =  @"C:\users\rkusu\source\repos\Kursovay\vchmat3\information.txt";
        string text = "Начало работы:";
        //  StreamWriter sw = new StreamWriter(@"C:\users\rkusu\source\repos\Kursovay\vchmat3\information.txt", true);

        AiplaneOnEarth[] arrayAirplanes = new AiplaneOnEarth[15];
        PictureBox[] pictureBoxes = new PictureBox[100];
        int amount_planes = 0;
        public Form1()
        {
            InitializeComponent();
            pictureBoxes[1] = pictureBox2; pictureBoxes[2] = pictureBox3; pictureBoxes[3] = pictureBox4; pictureBoxes[4] = pictureBox5; pictureBoxes[5] = pictureBox6; pictureBoxes[6] = pictureBox7;
            pictureBoxes[7] = pictureBox8; pictureBoxes[8] = pictureBox9; pictureBoxes[9] = pictureBox10; pictureBoxes[10] = pictureBox11;

        }

        private bool empty(TextBox box)
        {
            if (box.Text == "")
                return true;
            else
                return false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string line = "------------------------------------------------------------";
            string text = "Начало работы:";
            using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
            {
                sw.WriteLine(text);
            }    
            if (empty(textBox1))
            {
                MessageBox.Show("Укажите количество cамолетов.");
                return;
            }

            if (textBox1.Text == "1" || textBox1.Text == "2" || textBox1.Text == "3" || textBox1.Text == "4" || textBox1.Text == "5" || textBox1.Text == "6"
                 || textBox1.Text == "7" || textBox1.Text == "8" || textBox1.Text == "9" || textBox1.Text == "10")
            {
                text = "Число самолетов: ";
                amount_planes = int.Parse(textBox1.Text) + 1;
                using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                {
                    sw.WriteLine(text);
                    sw.WriteLine(amount_planes -1);
                    sw.WriteLine(line);
                }
            }
            else
            {
                MessageBox.Show("Число самолетов варьируется от 1 до 10 самолетов.");
                text = "!!!НЕПРАВИЛЬНЫЙ ВВОД!!! : ";
                using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                {
                    sw.WriteLine(text);
                    sw.WriteLine(line);
                }
                return;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string line = "------------------------------------------------------------";
            string text = "Начало работы:";
            using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
            {
                sw.WriteLine(line);
            }
            if (amount_planes == 0)
            {
                MessageBox.Show("Введите число самолетов.");
                return;
            }
            text = "Число самолетов в воздухе: ";
            using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
            {
                sw.WriteLine(text);
                sw.WriteLine(amount_planes - 1);
            }
            for (int i = 1; i < amount_planes; i++)
            {
                arrayAirplanes[i] = new AiplaneOnEarth();
                if (arrayAirplanes[i].degree > 135 && arrayAirplanes[i].degree < 225)
                {
                    pictureBoxes[i].Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                }
                if (arrayAirplanes[i].degree >= 225 && arrayAirplanes[i].degree < 315)
                {
                    pictureBoxes[i].Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
                }
                if (arrayAirplanes[i].degree >= 315 || arrayAirplanes[i].degree <= 45)
                {
                    pictureBoxes[i].Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                }
                pictureBoxes[i].Location = new Point(arrayAirplanes[i].x, arrayAirplanes[i].y);
                pictureBoxes[i].Invalidate();


                Thread.Sleep(50);
                using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                {
                    sw.WriteLine("Координаты ");
                    sw.WriteLine(i);
                    sw.WriteLine("Самолета ");
                    sw.WriteLine(arrayAirplanes[i].x);
                    sw.WriteLine(arrayAirplanes[i].y);
                    sw.WriteLine("Угол поворота: ");
                    sw.WriteLine(arrayAirplanes[i].degree);
                    sw.WriteLine(line);
                    //sw.WriteLine(line);
                    //int a = arrayAirplanes[1].CheckPlanesOnScreen(arrayAirplanes, amount_planes);
                    //sw.WriteLine("Число самолетов на радарах: ");
                    //sw.WriteLine(a);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)

        {
            if (amount_planes == 0)
            {
                MessageBox.Show("Введите число самолетов.");
                return;
            }
            using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
            {
                sw.WriteLine("=====Движение самолетов===== ");
            }
            int xChecker = 0;
            int yChecker = 0;
            for (int j = 1; j < 10; j++)
            {
                for (int i = 1; i < amount_planes; i++)
                {
                    //Thread.Sleep(50);
                    xChecker = arrayAirplanes[i].x;
                    yChecker = arrayAirplanes[i].y;
                    if (arrayAirplanes[i].takeOff_checker == 0)
                        arrayAirplanes[i].Landing(arrayAirplanes, i, amount_planes);
                    

                    if (arrayAirplanes[i].takeOff_checker == 1)
                    {
                        arrayAirplanes[i].Landing_in_Airport(arrayAirplanes, i);
                        pictureBoxes[i]= pictureBox12;
                        pictureBoxes[i].Refresh();
                     

                    }
                    if ((arrayAirplanes[i].x == xChecker && arrayAirplanes[i].y == yChecker) && arrayAirplanes[i].takeOff_checker == 0)
                    {
                        arrayAirplanes[i].Maneuver(arrayAirplanes, amount_planes);
                       
                    }
                    if ((arrayAirplanes[i].x == xChecker && arrayAirplanes[i].y == yChecker) && arrayAirplanes[i].takeOff_checker == 0)
                    {
                        arrayAirplanes[i].MovingAirplane();
                       
                    }
                    pictureBoxes[i].Refresh();
                    pictureBoxes[i].Location = new Point(arrayAirplanes[i].x, arrayAirplanes[i].y);
                    using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                    {
                        sw.WriteLine("Координаты ");
                        sw.WriteLine(i);
                        sw.WriteLine("Самолета ");
                        sw.WriteLine(arrayAirplanes[i].x);
                        sw.WriteLine(arrayAirplanes[i].y);
                        sw.WriteLine("=================== ");
                    }
                    pictureBoxes[i].Invalidate();
                    Thread.Sleep(10);                 
                }
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
            {
                sw.WriteLine("=================== ");
                sw.WriteLine("Тест маневра двух самолетов ");
            }

            arrayAirplanes[1] = new AiplaneOnEarth(600, 500, 1);
            pictureBoxes[1].Location = new Point(arrayAirplanes[1].x, arrayAirplanes[1].y);
            arrayAirplanes[2] = new AiplaneOnEarth(900, 500, 179);
            pictureBoxes[2].Location = new Point(arrayAirplanes[2].x, arrayAirplanes[2].y);
            for (int i = 3; i < amount_planes; i++)
            {
                arrayAirplanes[i] = new AiplaneOnEarth();
            }
            pictureBoxes[1].Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBoxes[2].Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pictureBoxes[1].Invalidate();
            pictureBoxes[2].Invalidate();
            pictureBoxes[1].Refresh();
            pictureBoxes[2].Refresh();
            for (int j = 0; j < 100; j++)
            {


               
                    int xChecker = arrayAirplanes[1].x;
                    int yChecker = arrayAirplanes[1].y;
                   
                    arrayAirplanes[2].Maneuver(arrayAirplanes, 3);

                    if (arrayAirplanes[1].x == xChecker || arrayAirplanes[1].y == yChecker)
                    {
                        arrayAirplanes[1].MovingAirplane();
                        arrayAirplanes[2].MovingAirplane();
                     }
                    Thread.Sleep(10);
                    pictureBoxes[1].Refresh();
                    pictureBoxes[1].Location = new Point(arrayAirplanes[1].x, arrayAirplanes[1].y);
                    pictureBoxes[1].Invalidate();
                    pictureBoxes[2].Refresh();
                    pictureBoxes[2].Location = new Point(arrayAirplanes[2].x, arrayAirplanes[2].y);
                    pictureBoxes[2].Invalidate();
                    Thread.Sleep(200);
                using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                {
                    sw.WriteLine("Изменения координат в связи с применеием маневра: ");
                    sw.WriteLine("Координаты первого самолета: ");
                    sw.WriteLine(arrayAirplanes[1].x);
                    sw.WriteLine(arrayAirplanes[1].y);
                    sw.WriteLine("Координаты второго самолета: ");
                    sw.WriteLine(arrayAirplanes[2].x);
                    sw.WriteLine(arrayAirplanes[2].y);
                    sw.WriteLine("=================== ");
                }

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
            {
                sw.WriteLine("=================== ");
                sw.WriteLine("Тест посадки самолета ");
            }

            arrayAirplanes[1] = new AiplaneOnEarth(170, 486, 30);
            pictureBoxes[1].Location = new Point(arrayAirplanes[1].x, arrayAirplanes[1].y);

            for (int i = 2; i < amount_planes; i++)
            {
                arrayAirplanes[i] = new AiplaneOnEarth();
            }
            for (int i = 1; i < amount_planes; i++)
            {
                if (arrayAirplanes[i].degree > 135 && arrayAirplanes[i].degree < 225)
                {
                    pictureBoxes[i].Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                }
                if (arrayAirplanes[i].degree >= 225 && arrayAirplanes[i].degree < 315)
                {
                    pictureBoxes[i].Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
                }
                if (arrayAirplanes[i].degree >= 315 || arrayAirplanes[i].degree <= 45)
                {
                    pictureBoxes[i].Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                }
            }
            pictureBoxes[1].Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBoxes[1].Invalidate();


            //pictureBoxes[1].Refresh();

            int xChecker = arrayAirplanes[1].x;
            int yChecker = arrayAirplanes[1].y;

            for (int j = 0; j < 50; j++)
            {
                arrayAirplanes[1].Landing(arrayAirplanes, 1, amount_planes);
                Thread.Sleep(10);
                if (arrayAirplanes[1].x == xChecker || arrayAirplanes[1].y == yChecker)
                {
                    arrayAirplanes[1].MovingAirplane();
                }
                pictureBoxes[1].Location = new Point(arrayAirplanes[1].x, arrayAirplanes[1].y);
                Thread.Sleep(10);
            }
            pictureBoxes[1].Location = new Point(arrayAirplanes[1].x, arrayAirplanes[1].y);
            pictureBoxes[1].Invalidate();
            using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
            {
                sw.WriteLine("Изменения координат в связи с посадкой самолета: ");
                sw.WriteLine("Координаты первого самолета: ");
                sw.WriteLine(arrayAirplanes[1].x);
                sw.WriteLine(arrayAirplanes[1].y);
                sw.WriteLine("=================== ");
            }

            pictureBoxes[1].Refresh();
            for (int i = 0; i < 45; i++)
            {
                arrayAirplanes[1].Landing_in_Airport(arrayAirplanes, 1);
                pictureBoxes[1].Location = new Point(arrayAirplanes[1].x, arrayAirplanes[1].y);
                using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                {
                    sw.WriteLine("Изменения координат в связи с перемещением самолета по аэропроту: ");
                    sw.WriteLine("Координаты первого самолета: ");
                    sw.WriteLine(arrayAirplanes[1].x);
                    sw.WriteLine(arrayAirplanes[1].y);
                    sw.WriteLine("=================== ");
                }
                Thread.Sleep(20);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (amount_planes == 0)
            {
                MessageBox.Show("Введите число самолетов.");
                return;
            }
            for (int i = 0; i < 10; i++)
            {
                button1_Click(sender, e);
                Thread.Sleep(1000);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
            {
                sw.WriteLine("=================== ");
                sw.WriteLine("Тест взлета двух самолетов ");
            }
            arrayAirplanes[1] = new AiplaneOnEarth(130, 650, 1);
            arrayAirplanes[2] = new AiplaneOnEarth(130, 800, 340);
            pictureBoxes[1] = pictureBox12;
            pictureBoxes[2] = pictureBox12;
            for (int i = 1; i < 500; i++)
            {
                arrayAirplanes[1].TakeOff_preparing(arrayAirplanes, 1);
                arrayAirplanes[2].TakeOff_preparing(arrayAirplanes, 2);
                pictureBoxes[1].Refresh();
                pictureBoxes[2].Refresh();
                pictureBoxes[1].Location = new Point(arrayAirplanes[1].x, arrayAirplanes[1].y);
                pictureBoxes[2].Location = new Point(arrayAirplanes[2].x, arrayAirplanes[2].y);
                using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                {
                    sw.WriteLine("Изменения координат в связи со взлетом: ");
                    sw.WriteLine("Координаты первого самолета: ");
                    sw.WriteLine(arrayAirplanes[1].x);
                    sw.WriteLine(arrayAirplanes[1].y);
                    sw.WriteLine("=================== ");
                }
                Thread.Sleep(5);
                pictureBoxes[1].Invalidate();
                pictureBoxes[2].Invalidate();
            }
            for (int i = 1; i < 500; i++)
            {
                arrayAirplanes[1].MovingAirplane();
                arrayAirplanes[2].MovingAirplane();
                pictureBoxes[1].Refresh();
                pictureBoxes[2].Refresh();
                pictureBoxes[1].Location = new Point(arrayAirplanes[1].x, arrayAirplanes[1].y);
                pictureBoxes[2].Location = new Point(arrayAirplanes[2].x, arrayAirplanes[2].y);
                using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                {
                    sw.WriteLine("Изменения координат в связи со взлетом: ");
                    sw.WriteLine("Координаты первого самолета: ");
                    sw.WriteLine(arrayAirplanes[1].x);
                    sw.WriteLine(arrayAirplanes[1].y);
                    sw.WriteLine("=================== ");
                }
                Thread.Sleep(5);
                pictureBoxes[1].Invalidate();
                pictureBoxes[2].Invalidate();
            }


            }
    }
}