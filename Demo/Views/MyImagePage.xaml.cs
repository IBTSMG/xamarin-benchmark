using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Demo
{
	public partial class MyImagePage : ContentPage
	{
		public Dictionary<string, string> images = new Dictionary<string, string>()
		{
			{"Monkey","monkey.jpg"},
			{"WaterFront","waterfront.jpg"},
			{"Xamarin","tapped.jpg"}
		};

		public MyImagePage()
		{
			InitializeComponent();

			pckPrize.Items.Add("Monkey");
			pckPrize.Items.Add("WaterFront");
			pckPrize.Items.Add("Xamarin");
		}

	    void onPrizeChange(object sender, EventArgs eventArgs)
		{
			Picker prizes = sender as Picker;
			if (prizes.SelectedIndex > -1)
			{
				imgPrize.Source = images[prizes.Items[prizes.SelectedIndex]];
			}
		}
	}
}
