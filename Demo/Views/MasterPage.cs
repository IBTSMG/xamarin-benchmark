using System;
using Xamarin.Forms;

namespace Demo
{
	public class MasterPage : MasterDetailPage
	{
		public MasterPage()
		{
			Title = "Ibtech Demo";

			Master = new MenuPage();
			MasterBehavior = MasterBehavior.Split;

			Detail = GetNavigation(new HomePage());

			BackgroundColor = Color.FromHex("#144fa8");
		}

		public void NavigateTo(Page targetPage)
		{
			this.Detail = GetNavigation(targetPage);
			this.Title = targetPage.Title;
			this.IsPresented = false;
		}

		private NavigationPage GetNavigation(Page targetPage)
		{
			return new NavigationPage(targetPage)
			{
				BarTextColor = Color.White,
				BarBackgroundColor = Color.FromHex("#1A237E")
			};
		}
	}
}
