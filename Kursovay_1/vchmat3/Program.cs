using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vchmat6
{

    class Airplane
    {

        public int x, y;
        public double degree;
        public int takeOff_checker = 0;
        protected int number_planes_on_screen;
        /*public int CheckPlanesOnScreen(Airplane[] arrayAirplanes, int amount_planes)
        {
            number_planes_on_screen = amount_planes-1;
            for (int i = 1; i < amount_planes; i++)
            {
                if(arrayAirplanes[i].x > 1920 || arrayAirplanes[i].x < 0 || arrayAirplanes[i].y > 1080 || arrayAirplanes[i].y < 0)
                {
                    number_planes_on_screen--;
                }
            }
            return (number_planes_on_screen);
        }*/
    }
    class AirplaneInAir : Airplane
    {
        public void MovingAirplane()
        {
            double x1, y1;


            x1 = 10 * Math.Cos(degree * 3.14 / 180);
            y1 = 10 * Math.Sin(degree * 3.14 / 180);
            if (x1 > 0 && y1 > 0)
            {
                x += (int)x1;
                y -= (int)y1;
            }
            if (x1 > 0 && y1 < 0)
            {
                x += (int)x1;
                y -= (int)y1;
            }
            if (x1 < 0 && y1 < 0)
            {
                x += (int)x1;
                y -= (int)y1;
            }
            if (x1 < 0 && y1 > 0)
            {
                x += (int)x1;
                y -= (int)y1;
            }
        }

        public void Maneuver(Airplane[] arrayAirplanes, int amount_planes)
        {
            //   int checker = 0;
            for (int j = 1; j < amount_planes; j++)
            {
                for (int i = 1; i < amount_planes; i++)
                {
                    if (i == j)
                    {
                        break;

                    }


                    if (Math.Abs(arrayAirplanes[j].x - arrayAirplanes[i].x) <= 100 && Math.Abs(arrayAirplanes[j].y - arrayAirplanes[i].y) <= 100)
                    {

                        if (arrayAirplanes[j].takeOff_checker == 0 && arrayAirplanes[i].takeOff_checker == 0)
                        {
                            if (arrayAirplanes[j].degree > 135 && arrayAirplanes[j].degree < 225)
                            {
                                arrayAirplanes[j].x--;
                                arrayAirplanes[j].y--;
                                arrayAirplanes[i].x++;
                                arrayAirplanes[i].y++;
                            }
                            if (arrayAirplanes[j].degree >= 225 && arrayAirplanes[j].degree < 315)
                            {
                                arrayAirplanes[j].x++;
                                arrayAirplanes[j].y--;
                                arrayAirplanes[i].x--;
                                arrayAirplanes[i].y++;

                            }
                            if (arrayAirplanes[j].degree >= 315 || arrayAirplanes[j].degree <= 45)
                            {
                                arrayAirplanes[j].x++;
                                arrayAirplanes[j].y++;
                                arrayAirplanes[i].x--;
                                arrayAirplanes[i].y--;

                            }
                            if (arrayAirplanes[j].degree > 45 && arrayAirplanes[j].degree <= 135)
                            {
                                arrayAirplanes[j].x--;
                                arrayAirplanes[j].y++;
                                arrayAirplanes[i].x++;
                                arrayAirplanes[i].y--;

                            }
                        }
                    }

                }
            }
        }
    }

    class AiplaneOnEarth : AirplaneInAir
    {
        public AiplaneOnEarth()
        {
            Random rndy = new Random();
            y = rndy.Next(50, 900);
            Random rndx = new Random();
            x = rndy.Next(50, 1800);
            Random rnddegree = new Random();
            degree = rnddegree.Next(0, 360);
        }


        public AiplaneOnEarth(int _x, int _y, int _degree)
        {
            x = _x;
            y = _y;
            degree = _degree;
        }

        public void Landing(Airplane[] arrayAirplanes, int i, int amount_planes)
        {
            bool checker2 = false;
            for (int z = 1; z < amount_planes; z++)
            {
                if (arrayAirplanes[z].takeOff_checker == 1)
                {
                    checker2 = true;
                }
            }
            if ((Math.Abs(arrayAirplanes[i].x - 150) <= 100) && (Math.Abs(arrayAirplanes[i].y - 500) <= 100) && checker2 == false)
            {
                if (arrayAirplanes[i].x > 150)
                {
                    arrayAirplanes[i].x--;
                }
                if (arrayAirplanes[i].x < 150)
                {
                    arrayAirplanes[i].x++;
                }
                if (arrayAirplanes[i].y > 500)
                {
                    arrayAirplanes[i].y--;
                }
                if (arrayAirplanes[i].y < 500)
                {
                    arrayAirplanes[i].y++;
                }
                if (arrayAirplanes[i].x == 150 && arrayAirplanes[i].y < 500)
                {
                    arrayAirplanes[i].y++;
                }
                if (arrayAirplanes[i].x == 150 && arrayAirplanes[i].y > 500)
                {
                    arrayAirplanes[i].y--;
                }
                if (arrayAirplanes[i].x > 150 && arrayAirplanes[i].y == 500)
                {
                    arrayAirplanes[i].x--;
                }
                if (arrayAirplanes[i].x < 150 && arrayAirplanes[i].y == 500)
                {
                    arrayAirplanes[i].y++;
                }
                if (arrayAirplanes[i].x == 150 && arrayAirplanes[i].y == 500)
                {
                    arrayAirplanes[i].takeOff_checker = 1;
                }

            }
        }
        public void Landing_in_Airport(Airplane[] arrayAirplanes, int num)
        {
            arrayAirplanes[num].x+=10;
        }
        public void TakeOff_preparing(Airplane[] arrayAirplanes, int num)
        {      
            arrayAirplanes[num].x += 10;
        }
    }

    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    

}
