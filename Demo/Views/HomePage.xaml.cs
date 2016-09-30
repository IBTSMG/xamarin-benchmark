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
	}
}
