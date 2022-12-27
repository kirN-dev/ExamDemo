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

namespace ExamDemo_2
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private readonly List<Fruit> _fruits = new();
		public MainWindow()
		{
			InitializeComponent();

			_fruits.Add(new Fruit("Яблоко", "Красное", 1, 200));
			_fruits.Add(new Fruit("Яблоко", "Зеленое", 15, 150));
			_fruits.Add(new Fruit("Банан", "Желтый", 20, 100));
			_fruits.Add(new Fruit("Апельсин", "Ораньжевый", 10, 230));

			lbFruits.ItemsSource = _fruits;
		}

		private void Compare_Click(object sender, RoutedEventArgs e)
		{
			var selectedFruits = lbFruits.SelectedItems;

			if (selectedFruits.Count != 2)
			{
				MessageBox.Show("Выделите 2 фрукта");
				return;
			}

			Fruit fruit1 = (Fruit)selectedFruits[0];
			Fruit fruit2 = (Fruit)selectedFruits[1];

			tbFruit1.Text = fruit1.ToString();
			tbFruit2.Text = fruit2.ToString();

			int resultCompare = fruit1.CompareTo(fruit2);

			switch (resultCompare)
			{
				case 0:
					MessageBox.Show("Вес фрутктов одинаковый");
					break;
				case > 0:
					MessageBox.Show("Первый весит больше");
					break;
				case < 0:
					MessageBox.Show("Второй весит больше");
					break;
			}
		}

		private void Sort_Click(object sender, RoutedEventArgs e)
		{
			for (int i = 0; i < lbFruits.Items.Count; i++)
			{
				for (int j = 0; j < lbFruits.Items.Count - 1; j++)
				{
					Fruit fruit1 = (Fruit)lbFruits.Items[j];
					Fruit fruit2 = (Fruit)lbFruits.Items[j + 1];

					if (fruit1.Weight > fruit2.Weight)
					{
						(lbFruits.Items[j], lbFruits.Items[j + 1]) = (lbFruits.Items[j + 1], lbFruits.Items[j]);
					}
				}
			}
		}
	}
}
