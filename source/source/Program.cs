using System;
using System.Collections.Generic;

class Program
{
   static void Main(string[] args)
   {
	var str = "Hello github!";
	Console.WriteLine(str);
	foreach(var ch in str)
	{
		Console.WriteLine(ch.ToString());
	}
  	Console.ReadLine();
   }
}
