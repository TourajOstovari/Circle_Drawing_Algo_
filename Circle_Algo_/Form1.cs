using System;
using System.Drawing;
using System.Windows.Forms;

namespace Circle_Algo_
{
    public partial class Form1 : Form
    {
        // Center

        public static int R { get; set; } = 10;   // Center >> ( 0 , R )
        public static int Rx { get; set; } = 0;
        public static int P { get; set; } = 1 - R;  // R
        // Size
        public static int x = 90;
        public static int y = 80;
        // Ends here the Size

        // End Center
        int Pos_X = 20; int Pos_Y = 60;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Pen pen = new Pen(Color.BlueViolet, 2.0f);

            for (int i = 0; i < 7; i++)
            {
                while (Rx <= R)
                {
                    if (P >= 0)
                    {
                        ++Rx;
                        --R;
                        P = P + 2 * Rx - 2 * R + 5;
                        graphics.DrawArc(pen, Pos_X, Pos_Y, x, y, Rx, R);
                    }
                    else
                    {
                        ++Rx;
                        P = P + 2 * Rx + 3;
                        graphics.DrawArc(pen, Pos_X, Pos_Y, x, y, Rx, R);
                    }
                }
                R += R;
                Rx = R;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            R = int.Parse(R_updown.Value.ToString());
            Pos_X = int.Parse(PosX_updown.Value.ToString());
            Pos_Y = int.Parse(PosY_updown.Value.ToString());
            //x = int.Parse(SizeX_updown.Value.ToString());
            //y = int.Parse(SizeY_updown.Value.ToString());
            x = int.Parse(R_updown.Value.ToString());
            y = int.Parse(R_updown.Value.ToString());
            this.Invalidate();

        }
    }
}
