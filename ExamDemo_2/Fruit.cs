using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamDemo_2
{
	public class Fruit : IComparable
	{
		public string Title { get; set; }
		public string Color { get; set; }
		public int Weight { get; set; }
		public int Calories { get; set; }

		public Fruit(string title, string color, int weight, int calories)
		{
			Title = title;
			Color = color;
			Weight = weight;
			Calories = calories;
		}

		public int CompareTo(object? obj)
		{
			Fruit anotherFruit = (Fruit)obj;

			return Weight.CompareTo(anotherFruit.Weight);
		}

		public override string ToString()
		{
			return $"Фрукт: {Title} Вес: {Weight}";
		}


		//Операторы перегрузить самостоятельно
	}
}
