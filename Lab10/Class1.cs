using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    internal class Angle
    {
        double grad;
        double minute;
        double second;

        public double Grad
        { get { return grad; } set { grad = value; } }
        public double Second
        { get { return minute; } set { minute = value; } }
        public double Minute
        { get { return minute; } set { minute = value; } }

        public Angle(double grad, double minute, double second)
        {
            this.grad = grad;
            this.minute = minute;
            this.second = second;
        }

        public double ToRadian()
        {
            return (second/ (60*180) + minute /60 + grad) / (180 / Math.PI);
        }
    }
}
