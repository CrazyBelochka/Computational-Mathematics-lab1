using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vchmat6
{

    class Airplane
    {
        public
       int x, y;
        int degree;
        public Airplane(){}

        public Airplane(int _x, int _y)
        {
            x = _x;
            y = _y;
        }
        
    
        public void NewAirplane()
        {
            y = 200;
            x = 100;
        }

        public void MovingAIrplane( )
        {
            x+=3;
            y+=3;
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
