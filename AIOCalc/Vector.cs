using System;

namespace AIOCalc
{
	public class Vector
    {
        public double x;
        public double y;
        public Vector(double X, double Y)
        {
            x = X;
            y = Y;
        }

        public Vector()
        {

        }
        
        public override string ToString()
        {
            return "Vector X: " + x.ToString() + " || Y: " + y.ToString();
        }

        /// <summary>
        /// returns the distance Vector between two given Vectors
        /// </summary>
        /// <param name="Vector 1"></param>
        /// <param name="Vector 2"></param>
        /// <returns>String</returns>
        public string VectorPtoQ(Vector V2)
        {
            return "(" + (this.x - V2.x) + " | " + (this.y - V2.y) + ")";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a1"></param>
        /// <param name="a2"></param>
        /// <param name="b1"></param>
        /// <param name="b2"></param>
        /// <returns></returns>
        public string VectorSub(Vector V2)
        {
            return "(" + (this.x - V2.x) + " | " + (this.y - V2.y) + ")";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a1"></param>
        /// <param name="a2"></param>
        /// <param name="b1"></param>
        /// <param name="b2"></param>
        /// <returns></returns>
        public string VectorAdd(Vector V2)
        {
            return "(" + (this.x + V2.x) + " | " + (this.y + V2.y) + ")";
        }

        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Va1"></param>
        /// <param name="Va2"></param>
        /// <param name="Vb1"></param>
        /// <param name="Vb2"></param>
        /// <returns></returns>
        public double VectorScalar(Vector V2)
        {
            return (this.x * V2.x) + (this.y * V2.y);
        }

        /// <summary>
        /// Returns the Length of the Vector (round by n digits)
        /// if no value is given, it defaults to 4 rounding digits
        /// </summary>
        /// <param name="n"></param>
        /// <returns>Double</returns>
        public double VectorLength(int n)
        {
            if (n <= 0)
            {
                throw new Exception("Cannot round to 0 or lower");
            }
            return Math.Round(Math.Sqrt(Math.Pow(this.x, 2) + Math.Pow(this.y, 2)), n);
        }

        /// <summary>
        /// Returns the Length of the Vector (round by n digits)
        /// if no value is given, it defaults to 4 rounding digits
        /// </summary>
        /// <param name="n"></param>
        /// <returns>Double</returns>
        public double VectorLength()
        {
            return Math.Round(Math.Sqrt(Math.Pow(this.x, 2) + Math.Pow(this.y, 2)), 4);
        }
    }
}