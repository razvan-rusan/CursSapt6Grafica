using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursSapt6Grafica
{
    public partial class Form2 : Form
    {
        Bitmap source;
        Bitmap dest;
        Bitmap belit;

        public Form2()
        {
            InitializeComponent();
            source = new Bitmap(Image.FromFile(@"../../spongebob cu afectiuni multiple.png"));
            //source = new Bitmap(Image.FromFile(@"../../spongebob afectat.png"));
            ///source = new Bitmap(Image.FromFile(@"../../Spongebob.png"));
            dest = new Bitmap(source.Width, source.Height);
            //belit = new Bitmap(Image.FromFile(@"../../spongebob afectat.png"));
        }



        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = source;
            pictureBox2.Image = dest;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Color c;
            for (int i = 0; i < source.Width; i++)
            {
                for (int j = 0; j < source.Height; j++)
                {
                    Color t = source.GetPixel(i, j);
                    int avg = (t.R + t.G + t.B) / 3;
                    if (avg < 64)
                    {
                        c = Color.Red;
                    }
                    else if (avg < 128)
                    {
                        c = Color.Green;
                    }
                    else
                    {
                        c = Color.Yellow;
                    }

                    dest.SetPixel(i, j, Color.FromArgb
                     (t.A, c.R, c.G, c.B));
                }
            }
            pictureBox1.Image = source;
            pictureBox2.Image = dest;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int k = 64;
            Color c;
            for (int i = 0; i < source.Width; i++)
            {
                for (int j = 0; j < source.Height; j++)
                {
                    Color t = source.GetPixel(i, j);
                    int r = (t.R / k) * k;
                    int g = (t.G / k) * k;
                    int b = (t.B / k) * k;

                    dest.SetPixel(i, j, Color.FromArgb
                     (r, g, b));
                }
            }
            pictureBox1.Image = source;
            pictureBox2.Image = dest;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Color c;
            Bitmap tmp = new Bitmap(source.Width, source.Height);
            for (int i = 0; i < source.Width; i++)
            {
                for (int j = 0; j < source.Height - 1; j++)
                {
                    Color t1 = source.GetPixel(i, j);
                    Color t2 = source.GetPixel(i, j + 1);
                    if (t1 == t2)
                    {
                        tmp.SetPixel(i, j, Color.White);
                        tmp.SetPixel(i, j + 1, Color.White);
                    }
                    else
                    {
                        tmp.SetPixel(i, j, Color.Black);
                        tmp.SetPixel(i, j + 1, Color.Black);
                    }
                }
            }
            pictureBox1.Image = source;
            pictureBox2.Image = tmp;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            source = dest;
            pictureBox1.Image = source;

        }

        int T(Color c)
        {
            return c.R * c.R * c.R + c.G * c.G + c.B;
        }

        //matrice 5x5
        private void button1_Click_1(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Value = 0;
            progressBar1.Maximum = source.Width;
            List<Color> colors = new List<Color>();
            for (int i = 0; i < source.Width; i++)
            {
                progressBar1.Value = i;
                for (int j = 0; j < source.Height; j++)
                {
                    colors.Clear();
                    for (int k = -2; k <= 2; k++)
                    {
                        for (int l = -2; l <= 2; l++)
                        {
                            if (i + k >= 0 && i + k < source.Width && j + l >= 0 && j + l < source.Height)
                            {
                                Color t2 = source.GetPixel(i + k, j + l);
                                colors.Add(t2);
                            }
                        }
                        if (colors.Count >=2 ) {
                            colors.Sort((a, b) => T(a).CompareTo(T(b)));
                            dest.SetPixel(i, j, colors[colors.Count / 2]);
                        } else
                        {
                            dest.SetPixel(i, j, Color.Gray);   
                        }
                             //mijlocul
                    }
                }

            }
            pictureBox2.Image = dest;
        }
    }
}
