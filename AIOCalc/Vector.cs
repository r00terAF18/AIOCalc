using System;

namespace AIOCalc
{
    public class Vector2D
    {
        public double x;
        public double y;
        public Vector2D(double X, double Y)
        {
            x = X;
            y = Y;
        }

        public Vector2D()
        {

        }

        public override string ToString()
        {
            return $"Vector = {x.ToString()}i ||  {y.ToString()}j";
        }

        /// <summary>
        /// returns the distance Vector between two given Vectors
        /// </summary>
        /// <param name="2nd Vector">Vector2D</param>
        /// <returns>new Vector2D</returns>
        public Vector2D VectorPtoQ(Vector2D V2)
        {
            return new Vector2D(this.x - V2.x, this.y - V2.y);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a1"></param>
        /// <returns>new Vector2D</returns>
        public Vector2D VectorSub(Vector2D V2)
        {
            return new Vector2D(this.x - V2.x, this.y - V2.y);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="2nd Vector">Vector2D</param>
        /// <returns>new Vector2D</returns>
        public Vector2D VectorAdd(Vector2D V2)
        {
            return new Vector2D(this.x + V2.x, this.y + V2.y);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="Va1"></param>
        /// <param name="Va2"></param>
        /// <param name="Vb1"></param>
        /// <param name="Vb2"></param>
        /// <returns></returns>
        public double VectorScalar(Vector2D V2)
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
        /// if no value is given, it defaults to 2 rounding digits
        /// </summary>
        /// <param name="n"></param>
        /// <returns>Double</returns>
        public double VectorLength()
        {
            return Math.Round(Math.Sqrt(Math.Pow(this.x, 2) + Math.Pow(this.y, 2)), 2);
        }
    }

    public class Vector3D
    {
        public double x;
        public double y;
        public double z;
        public Vector3D(double X, double Y, double Z)
        {
            x = X;
            y = Y;
            z = Z;
        }

        public Vector3D()
        {

        }

        public override string ToString()
        {
            return $"Vector = {x.ToString()}i || {y.ToString()}j || {z.ToString()}k";
        }

        /// <summary>
        /// returns the distance Vector between two given Vectors
        /// </summary>
        /// <param name="2nd Vector">Vector2D</param>
        /// <returns>new Vector2D</returns>
        public Vector3D VectorPtoQ(Vector3D V2)
        {
            return new Vector3D(this.x - V2.x, this.y - V2.y, this.z - V2.z);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a1"></param>
        /// <returns></returns>
        public Vector3D VectorSub(Vector3D V2)
        {
            return new Vector3D(this.x - V2.x, this.y - V2.y, this.z - V2.z);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a1"></param>
        /// <param name="a2"></param>
        /// <param name="b1"></param>
        /// <param name="b2"></param>
        /// <returns></returns>
        public Vector3D VectorAdd(Vector3D V2)
        {
            return new Vector3D(this.x + V2.x, this.y + V2.y, this.z + V2.z);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="Vector V2">Second Vector</param>
        /// <returns>double Scalar</returns>
        public double VectorScalar(Vector3D V2)
        {
            return (this.x * V2.x) + (this.y * V2.y) + (this.z * V2.z);
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
            return Math.Round(Math.Sqrt(Math.Pow(this.x, 2) + Math.Pow(this.y, 2) + Math.Pow(this.z, 2)), n);
        }

        /// <summary>
        /// Returns the Length of the Vector (round by n digits)
        /// if no value is given, it defaults to 2 rounding digits
        /// </summary>
        /// <param name="n"></param>
        /// <returns>Double</returns>
        public double VectorLength()
        {
            return Math.Round(Math.Sqrt(Math.Pow(this.x, 2) + Math.Pow(this.y, 2) + Math.Pow(this.z, 2)), 2);
        }
    }
}