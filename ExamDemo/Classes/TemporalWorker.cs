using System;

namespace ExamDemo.Classes
{
	public class TemporalWorker : IEmployee
	{
		private const int _costPerHour = 100;
		public string FirstName { get; }
		public string LastName { get; }
		public string Post { get; }
		public DateOnly Created { get; }

		public TemporalWorker(string firstName, string lastName, string post, DateOnly created, int hourWork)
		{
			FirstName = firstName;
			LastName = lastName;
			Post = post;
			Created = created;
			HourWork = hourWork;
		}

		public int HourWork { get; set; }

		public decimal Salary()
		{
			return _costPerHour * HourWork;
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
