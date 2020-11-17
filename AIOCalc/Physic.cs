using System;

namespace AIOCalc
{
	public class Physic
	{
		public double v_avg(double deltaX, double deltaT)
		{
			return Math.Round(deltaX / deltaT, 2);
		}
	}
}