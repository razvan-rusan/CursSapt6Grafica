using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursSapt6Grafica
{
    public class Segment
    {
        PointF p1, p2;
        public static int k = 10;
        public PointF[] intermediatePoints;

        public Segment(PointF p1, PointF p2)
        {
            this.p1 = p1;
            this.p2 = p2;
            intermediatePoints = GetPoints();
        }

        PointF[] GetPoints()
        {
            PointF[] res = new PointF[k+1];
            for (int i = 0; i <= k; i++)
            {
                float x = (i * p1.X + (k - i) * p2.X) / k;
                float y = (i * p1.Y + (k - i) * p2.Y) / k;
                res[i] = new PointF(x, y);
            }
            return res;
        }

        public void Draw(Graphics handler) {
            handler.DrawLine(Pens.Black, p1, p2);
            handler.DrawEllipse(Pens.Black, p1.X - 7, p1.Y - 7, 15, 15);
            handler.DrawEllipse(Pens.Black, p2.X - 7, p2.Y - 7, 15, 15);
            foreach (PointF p in intermediatePoints) {
                handler.DrawEllipse(Pens.Green, p.X - 2, p.Y - 2, 5, 5);
            }
        }
    }
}
