﻿namespace Lab3._2
{
	public class Car
	{
		public string Color { get; set; }
		public int Year { get; set; }
		public int Mileage { get; set; }

		public Car(string color, int year)
		{
			Color = color;
			Year = year;
			instances++;
		}

		public Car(int year, int mileage)
		{
			Year = year;
			Mileage = mileage;
			instances++;
		}

		private static int instances = 0;

		public Car()
		{
			instances++;
		}

		public static int CountCars()
		{
			return instances;
		}
	}
}
