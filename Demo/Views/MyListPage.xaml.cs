using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Demo
{
	public partial class MyListPage : ContentPage
	{
		public MyListPage()
		{
			InitializeComponent();
			this.BindingContext = new ListViewModel();
		}
	}
}
