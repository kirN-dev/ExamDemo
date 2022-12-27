using ExamDemo.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ExamDemo
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private readonly List<IEmployee> employees = new();

		public MainWindow()
		{
			InitializeComponent();

			employees.Add(new TemporalWorker("Артем", "Варламов", "Азазатор группы", new DateOnly(2020, 09, 01), 8));
			employees.Add(new ConstWorker("Егор", "Генеральский", "OSU-мастер", new DateOnly(2020, 09, 01), 172));

			lbEmployees.ItemsSource = employees;
		}
		private void GetSalary_Click(object sender, RoutedEventArgs e)
		{
			IEmployee employee = lbEmployees.SelectedItem as IEmployee;

			if (employee == null)
			{
				MessageBox.Show("Сотрудник не выбран");
				return;
			}

			MessageBox.Show($"У {employee} зарплата: {employee.Salary()}");
		}

		private void GetTotalSlary_Click(object sender, RoutedEventArgs e)
		{
			decimal sum = 0;
			foreach (var employee in employees)
			{
				sum += employee.Salary();
			}

			MessageBox.Show($"Общая зарплата: {sum}");
		}
	}
}
