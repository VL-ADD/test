using System;
using System.Collections.Generic;

namespace TestClassLib
{
    public class triangle
    {
        public double S_triangle(double a, double b, double c)
        {
            double P = (a + b + c) / 2;
            double S = Math.Sqrt(P * (P - a) * (P - b) * (P - c));
            return S;
        }


        public bool IsRightTriangle(double a, double b, double c)
        {
            bool flag = false;
            if( a*a == (b*b + c*c) || b*b == (a*a + c*c) || c*c == (a*a + b*b))
            {
                flag = true;
            }
            return flag;
        }
    }

    public class circle
    {
        public double S_circle(double R)
        {
            double S = R * R * Math.PI;
            return S;
        }
    }

    public class UncnovunknownFigure
    {
        public double S_figure( List<double> param, string type = null) //// определяет фигуру по заданным параметрам
        {
            double S = -1;

            if(param.Count == 1 && type == null)
            {
                S = param[0] * param[0] * Math.PI;
            }

            if(param.Count == 2 && type == null)
            {
                double a = param[0];
                double b = param[1];
                double c = param[2];
                double P = (a + b + c) / 2;
                S = Math.Sqrt(P * (P - a) * (P - b) * (P - c));
            }
            return S;
        }
    }
}
