using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Forms;

namespace Demo
{
	public partial class MyPopupPage : ContentPage
	{
		public MyPopupPage()
		{
			InitializeComponent();
		}

	    void ShowAlert(object sender, EventArgs e)
		{
			DisplayAlert("Alert", "You have been alerted", "OK");
		}

		async void ShowConfirm(object sender, EventArgs e)
		{
			var answer = await DisplayAlert("Question?", "Would you like to play a game", "Yes", "No");
			Debug.WriteLine("Answer: " + answer);
		}

		async void ShowActionSheet(object sender, EventArgs e)
		{
			var action = await DisplayActionSheet("ActionSheet: Send to?", "Cancel", null, "Email", "Twitter", "Facebook");
			Debug.WriteLine("Action: " + action);
		}
	}
}
