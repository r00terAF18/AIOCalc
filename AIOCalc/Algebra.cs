using System;

namespace AIOCalc
{
    public class Algebra
    {
        /// <summary>
        /// This function factorials the given number.
        /// </summary>
        /// <param name="n">a double value to get the factor of</param>
        /// <returns></returns>
        public double factorial(double n)
        {
            double f = 1;
            do
            {
                f *= n;
                n--;
            } while (n > 0);

            return f;
        }

        /// <summary>
        /// a simple function to give out the root of a number
        /// </summary>
        /// <param name="n">Number to get the root of</param>
        /// <param name="r">The level of the root</param>
        /// <returns>Root of n by r (double)</returns>
        public double Root(double n, double r)
        {
            return Math.Pow(n, 1.0 / r);
        }

        /// <summary>
        /// Calcualtes the combination of two given values.
        /// </summary>
        /// <param name="n">all of our trials</param>
        /// <param name="k">how much from each trial</param>
        /// <returns></returns>
        public double nOverk(double n, double k)
        {
            double nMink = n - k;
            double noverk = (factorial(n) / (factorial(k) * factorial(nMink)));
            Math.Round(noverk, 4);

            return noverk;
        }

        /// <summary>
        /// We can calculate how many times we can expect something
        /// </summary>
        /// <param name="n">the number of trials</param>
        /// <param name="p">the probability</param>
        /// <returns></returns>
        public double Mu(double n, double p)
        {
            return Math.Round((n * p), 4);
        }

        /// <summary>
        /// How apart are the values
        /// </summary>
        /// <param name="n">the number of trials</param>
        /// <param name="p">the probability</param>
        /// <returns>Double</returns>
        public double Sigma(double n, double p)
        {
            double q = 1 - p;
            double s = Math.Sqrt((n * p * q));
            Math.Round(s, 4);

            return s;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public double binoF1(double a, double b)
        {
            return Math.Pow(a, 2) + 2 * a * b + Math.Pow(b, 2);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public double binoF2(double a, double b)
        {
            return Math.Pow(a, 2) - 2 * a * b + Math.Pow(b, 2);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public double binoF3(double a, double b)
        {
            return Math.Pow(a, 2) - Math.Pow(b, 2);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        /// <param name="q"></param>
        /// <returns></returns>
        public string qdrFs(double p, double q)
        {
            double resP = -(p / 2) + Math.Sqrt((Math.Pow((p / 2), 2)) - q);
            double resM = -(p / 2) - Math.Sqrt((Math.Pow((p / 2), 2)) - q);
            string res = "x1 = " + Math.Round(resP, 4) + " x2 = " + Math.Round(resM, 4);

            return res;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns>String</returns>
        public string qdrFb(double a, double b, double c)
        {
            double resP = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
            double resM = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
            string res = "x1 = " + Math.Round(resP, 4) + " x2 = " + Math.Round(resM, 4);

            return res;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="h"></param>
        /// <returns>Double</returns>
        public double getTriangleA(double a, double h)
        {
            return (a * h) / 2;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns>Double</returns>
        public double getTriangleD(double a, double b, double c)
        {
            return a + b + c;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="c"></param>
        /// <param name="h"></param>
        /// <returns>Double</returns>
        public double setTriangleA(double c, double h)
        {
            return (c * h) / 2;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>Double (c)</returns>
        public double Pythagaoras(double a, double b)
        {
            return Math.Sqrt((a + b));
        }
    }
}
