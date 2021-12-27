using System;
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

namespace vchmat6

{
    public partial class Form1 : Form
    {
        Airplane a1 = new Airplane();
        Airplane a2 = new Airplane(100, 100);
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)

        {
            a1.NewAirplane();
            pictureBox2.Location = new Point(a1.x, a1.y);
            //a2.NewAirplane();
            pictureBox3.Location = new Point(a2.x, a2.y);
        }

        private void button1_Click(object sender, EventArgs e)

        {
            for (; ;)
            {
                Thread.Sleep(50);
                a1.MovingAIrplane();
                pictureBox2.Location = new Point(a1.x, a1.y);
                if (a1.x > 500 || a1.y > 1250)
                    break;
            }
        }
         

    }
}