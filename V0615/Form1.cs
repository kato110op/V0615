namespace V0615
{
    public partial class Form1 : Form
    {
        static Random rand = new Random();
        int vx1 = rand.Next(-10, 11);
        int vy1 = rand.Next(-10, 11);
        int vx2 = rand.Next(-10, 11);
        int vy2 = rand.Next(-10, 11);
        int vx3 = rand.Next(-10, 11);
        int vy3 = rand.Next(-10, 11);
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx1;
            label1.Top += vy1;
            if (label1.Left < 0)
            {
                vx1 = Math.Abs(vx1);
            }
            else if (label1.Right > ClientSize.Width)
            {
                vx1 = -Math.Abs(vx1);
            }
            if (label1.Top < 0)
            {
                vy1 = Math.Abs(vy1);
            }
            else if (label1.Bottom > ClientSize.Height)
            {
                vy1 = -Math.Abs(vy1);
            }

            label2.Left += vx2;
            label2.Top += vy2;
            if (label2.Left < 0)
            {
                vx2 = Math.Abs(vx2);
            }
            else if (label2.Right > ClientSize.Width)
            {
                vx2 = -Math.Abs(vx2);
            }
            if (label2.Top < 0)
            {
                vy2 = Math.Abs(vy2);
            }
            else if (label2.Bottom > ClientSize.Height)
            {
                vy2 = -Math.Abs(vy2);
            }

            label3.Left += vx3;
            label3.Top += vy3;
            if (label3.Left < 0)
            {
                vx3 = Math.Abs(vx3);
            }
            else if (label3.Right > ClientSize.Width)
            {
                vx3 = -Math.Abs(vx3);
            }
            if (label3.Top < 0)
            {
                vy3 = Math.Abs(vy3);
            }
            else if (label3.Bottom > ClientSize.Height)
            {
                vy3 = -Math.Abs(vy3);
            }
        }
    }
}