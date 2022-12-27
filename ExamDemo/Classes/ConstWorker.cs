using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamDemo.Classes
{
	public class ConstWorker : IEmployee
	{
		private const int _requiredHour = 160;
		private const int _salary = 45_000;
		private const int _percentAdd = 7;
		private const int _percentSub = 10;
		private const int _dayWork = 8;

		public string FirstName { get; }
		public string LastName { get; }
		public string Post { get; }
		public DateOnly Created { get; }
		public int HourWork { get; set; }

		public ConstWorker(string firstName, string lastName, string post, DateOnly created, int hourWork)
		{
			FirstName = firstName;
			LastName = lastName;
			Post = post;
			Created = created;
			HourWork = hourWork;
		}

		public decimal Salary()
		{
			int add = _salary / 100 * _percentAdd;
			int sub = _salary / 100 * _percentSub;

			int diffHour = HourWork - _requiredHour;
			int totalSalary = _salary;

			if (diffHour >= _dayWork)
			{
				for (int i = 0; i < diffHour / 8; i++)
				{
					totalSalary += add; 
				}
				return totalSalary;
			}
			else if(diffHour <= -_dayWork)
			{
				for (int i = 0; i < -diffHour / 8; i++)
				{
					totalSalary -= sub;
				}
				return totalSalary;
			}

			return _salary;
		}

		public int Seniority()
		{
			return DateTime.Now.Year - Created.Year;
		}

		public override string ToString()
		{
			return $"Имя: {FirstName} Фамилия: {LastName} Должность: {Post}";
		}
	}
}
