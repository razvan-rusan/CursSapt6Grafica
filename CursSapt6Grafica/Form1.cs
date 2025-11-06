using CursSapt6Grafica;
using System.Windows.Forms;

namespace CursSapt6Grafica
{
    public partial class Form1 : Form
    {
        Graphics graphics;
        Bitmap bitmap;

        PointF p1 = new PointF(20, 50);
        PointF p2 = new PointF(400, 370);

        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(bitmap);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Segment s = new Segment(p1, p2);
            //s.Draw(graphics);   
            BezierGrad1 b = new BezierGrad1(
                new PointF(50, 300),
                new PointF(200, 20),
                new PointF(550, 150),
                20);
            b.Draw(graphics);
            pictureBox1.Image = bitmap;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
