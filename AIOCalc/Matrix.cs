using System;

namespace AIOCalc
{
    public class Matrix
    {
        public int i;
        public List<double> ai = new List<double>();
        public int j;
        public List<double> aj = new List<double>();
        public bool isI = false;

        public override string ToString()
        {
            return "i: " + this.i.ToString() + " | j: " + this.j.ToString();
        }

        public Matrix(int I, int J)
        {
            i = I;
            j = J;
        }

        public Matrix initMatrix()
        {            
            for (int Aj = 0; Aj < this.j; Aj++)
            {
                Console.Write("Enter value for position {0},{1} >>> ", 0, Aj);                
                this.aj.Add(double.Parse(Console.ReadLine()));
            }

            for (int Ai = 0; Ai < this.i; Ai++)
            {
                Console.Write("Enter value for position {0},{1} >>> ", Ai, 0);
                this.ai.Add(double.Parse(Console.ReadLine()));
            }
            
            //Console.Clear();

            for (int Aj = 0; Aj < this.j; Aj++)
            {
                Console.Write(this.aj[Aj].ToString() + " ");
            }

            Console.Write("\n");

            for (int Ai = 0; Ai < this.i; Ai++)
            {
                Console.Write(this.ai[Ai].ToString() + " ");
            }

            Console.WriteLine();

            return this;
        }
    }
}