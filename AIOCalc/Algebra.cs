using System;

namespace AIOCalc
{
    public class Algebra
    {
    	public void writeThis(string text)
    	{
    		foreach(var x in text)
    		{
    			Console.WriteLine($"==> {x}");
    		}
    	}
    }
}
