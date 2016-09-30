using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace Demo
{
	public partial class MyMapPage : ContentPage
	{
		public MyMapPage()
		{
			InitializeComponent();
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();

			var position = new Position(40.792198, 29.4645453);
			var pin = new Pin
			{
				Type = PinType.Place,
				Position = position,
				Label = "Finansbank",
				Address = "Tübitak Yerleşkesi/Gebze"
			};
			myMap.Pins.Add(pin);

			myMap.HasZoomEnabled = true;

			myMap.MoveToRegion(
				MapSpan.FromCenterAndRadius(
					position, Distance.FromMiles(.2)));
		}
	}
}
