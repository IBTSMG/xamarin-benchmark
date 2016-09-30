using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace Demo
{
	public class HomeViewModel : BaseViewModel
	{
		private string name;
		public string Name
		{ 
			get { return name; }
			set 
			{
				name = value;
				this.OnPropertyChanged("Name");
			}
		}

		private string surname;
		public string Surname
		{
			get { return surname; }
			set
			{
				surname = value;
				this.OnPropertyChanged("Surname");
			}
		}
	}
}
