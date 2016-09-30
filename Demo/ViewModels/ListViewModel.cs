using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace Demo
{
	public class ListViewModel : BaseViewModel
	{
		ICommand loadCommand;

		ObservableCollection<Order> orders;

		public ListViewModel()
		{
			loadCommand = new Command(LoadOrders);
			LoadOrders();
		}

		void LoadOrders()
		{
			Orders = new ObservableCollection<Order>();

			for (int i = 0; i < IterationCount; i++)
				Orders.Add(new Order() { Id = i+1, Account = "Fatih Şimşek", Item = "Notebook", OrderDate = DateTime.Now, Price = 200.0f, Quantity = 1 });
		}

		public ObservableCollection<Order> Orders
		{
			get { return orders; }
			set
			{
				orders = value;
				OnPropertyChanged("Orders");
			}
		}

		private int iterationCount = 100;
		public int IterationCount
		{
			get { return iterationCount; }
			set
			{
				iterationCount = value;
				OnPropertyChanged("IterationCount");
			}
		}

		public ICommand LoadCommand
		{
			get
			{
				return loadCommand;
			}
		}
	}
}
