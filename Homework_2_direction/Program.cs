using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2_direction
{
	internal class Program
	{
		struct Point
		{


			public double x, y;
			public Point(double x, double y)
			{
				this.x = x;
				this.y = y;
			}
			public void print()
			{
				Console.WriteLine($"X = {x}\tY = {y}");
			}
			public double distance(Point other)
			{
				//double x_distance = this.x - other.x;
				//double y_distance = this.y - other.y;
				//double distance = Math.Sqrt(x_distance * x_distance + y_distance * y_distance);
				//return distance;
				return Math.Sqrt(Math.Pow(this.x-other.x, 2) + Math.Pow(this.y-other.y, 2));
			}
			public static double distance(Point left, Point right)
			{
				return left.distance(right);
			}
		}
	
		

		static void Main(string[] args)
		{
			Point A;
			A.x = 2;
			A.y = 3;
			A.print();

			Point B = new Point(7, 8);
			B.print();

			Console.WriteLine($"Расстояние от точки 'A' ДО ТОЧКИ 'B': {A.distance(B)}");
			Console.WriteLine($"Расстояние от точки 'B' ДО ТОЧКИ 'A': {B.distance(A)}");
			Console.WriteLine($"Расстояние между точками 'А' и 'В' : {Point.distance(A,B)}");
			Console.WriteLine($"Расстояние между точками 'B' и 'A' : {Point.distance(B,A)}");

			Console.WriteLine($"Расстояние между точками: {new Point(22, 33).distance(new Point (77, 88))}");
		}
		


		

	}
}
