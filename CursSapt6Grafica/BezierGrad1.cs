using CursSapt6Grafica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursSapt6Grafica 
    //curbe bezier
    //tema: fa cu n puncte
{
    public class BezierGrad1
    {
        PointF p1; PointF p2; PointF p3;
        Segment s1, s2;

        public BezierGrad1(PointF p1, PointF p2, PointF p3, int k) { 
            Segment.k = k;
            s1 = new Segment(p1, p2);
            s2 = new Segment(p2, p3);
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
        }

        public void Draw(Graphics handler) {
            s1.Draw(handler);
            s2.Draw(handler);
            PointF[] p1 = s1.intermediatePoints;
            PointF[] p2 = s2.intermediatePoints;
            for (int i = 0; i < p1.Length; i++) { 
                Segment tmp = new Segment(p1[i], p2[i]);
                tmp.Draw(handler);
            }
        }
    }
}
