namespace сomputer_graphics_lab_1
{
    public partial class Form1 : Form
    {
        Paint rabbit = new Paint();

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Blue, 5);
            Matrix<double> displayRabit = rabbit.transformMatrix(paintPanel);
            for (int i = 0; i < rabbit.connections.Count; i++)
            {
                int x1 = (int)displayRabit[rabbit.connections[i][0], 0] + 1;
                int y1 = (int)displayRabit[rabbit.connections[i][0], 1] + 1;
                int x2 = (int)displayRabit[rabbit.connections[i][1], 0] + 1;
                int y2 = (int)displayRabit[rabbit.connections[i][1], 1] + 1;
                g.DrawLine(pen, new Point(x1, y1), new Point(x2, y2));
            }
        }

        public Form1()
        {
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            InitializeComponent();
            paintPanel.Paint += Form1_Paint;
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            rabbit.move(10, 0);
            paintPanel.Invalidate();
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            rabbit.move(-10, 0);
            paintPanel.Invalidate();
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            rabbit.move(0, -10);
            paintPanel.Invalidate();
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            rabbit.move(0, 10);
            paintPanel.Invalidate();
        }

        private void rotationLeft_Click(object sender, EventArgs e)
        {
            List<double> center = rabbit.getCenter();
            rabbit.move(center[0] * -1, center[1] * -1);
            rabbit.rotation(0.35);
            rabbit.move(center[0], center[1]);
            paintPanel.Invalidate();
        }

        private void rotationRight_Click(object sender, EventArgs e)
        {
            List<double> center = rabbit.getCenter();
            rabbit.move(center[0] * -1, center[1] * -1);
            rabbit.rotation(-0.35);
            rabbit.move(center[0], center[1]);
            paintPanel.Invalidate();
        }

        private void zoomIn_Click(object sender, EventArgs e)
        {
            List<double> center = rabbit.getCenter();
            rabbit.move(center[0] * -1, center[1] * -1);
            rabbit.zoom(1.5, 1.5);
            rabbit.move(center[0], center[1]);
            paintPanel.Invalidate();
        }

        private void zoomOut_Click(object sender, EventArgs e)
        {
            List<double> center = rabbit.getCenter();
            rabbit.move(center[0] * -1, center[1] * -1);
            rabbit.zoom(0.6, 0.6);
            rabbit.move(center[0], center[1]);
            paintPanel.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)=> Application.Exit();
    }
}
