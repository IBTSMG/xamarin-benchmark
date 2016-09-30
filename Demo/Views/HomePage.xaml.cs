using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Demo
{
	public partial class HomePage : ContentPage
	{
		public HomePage()
		{
			InitializeComponent();
			this.BindingContext = new HomeViewModel();
		}

		void Show(object sender, EventArgs e)
		{
			HomeViewModel model = this.BindingContext as HomeViewModel;
			DisplayAlert("Alert", string.Format("Hoşgeldin {0} {1}", model.Name, model.Surname), "OK");
		}
	}
}
