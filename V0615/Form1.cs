namespace V0615
{
    public partial class Form1 : Form
    {
        static Random rand = new Random();
        int[] vx = new int[100];
        int[] vy = new int[100];
        Label[] labels = new Label[100];

        public Form1()
        {
            InitializeComponent();



            for (int i = 0; i < 100; i++)
            {
                vx[i] = rand.Next(-10, 11);
                vy[i] = rand.Next(-10, 11);

                labels[i] = new Label();
                labels[i].Text = "ž";
                labels[i].AutoSize = true;
                Controls.Add(labels[i]);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                labels[i].Left += vx[i];
                labels[i].Top += vy[i];
                if (labels[i].Left < 0)
                {
                    vx[i] = Math.Abs(vx[i]);
                }
                else if (labels[i].Right > ClientSize.Width)
                {
                    vx[i] = -Math.Abs(vx[i]);
                }
                if (labels[i].Top < 0)
                {
                    vy[i] = Math.Abs(vy[i]);
                }
                else if (labels[i].Bottom > ClientSize.Height)
                {
                    vy[i] = -Math.Abs(vy[i]);
                }
            }
        }


                private void button1_Click(object sender, EventArgs e)
                {
                    int a = 0;
                    for (; a < 10; a++)
                    {

                        if (a == 2)
                        {
                            continue;
                        }
                        if (a == 5)
                        {
                            break;
                        }
                        MessageBox.Show($"{a}");
                    }

                    MessageBox.Show($"done{a}");
                }
            }
        }
