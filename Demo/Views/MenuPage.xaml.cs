using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Demo
{
	public partial class MenuPage : ContentPage
	{
		public MenuPage()
		{
			InitializeComponent();

			var masterPageItems = new List<MasterPageItem>();
			masterPageItems.Add(new MasterPageItem
			{
				Title = "Home",
				IconSource = "contacts.png",
				GetPage = () => new HomePage()
			});
			masterPageItems.Add(new MasterPageItem
			{
				Title = "Controls",
				IconSource = "contacts.png",
				GetPage = () => new MyControlPage()
			});
			masterPageItems.Add(new MasterPageItem
			{
				Title = "ListView",
				IconSource = "contacts.png",
				GetPage = () => new MyListPage()
			});
			masterPageItems.Add(new MasterPageItem
			{
				Title = "Map",
				IconSource = "contacts.png",
				GetPage = () => new MyMapPage()
			});
			masterPageItems.Add(new MasterPageItem
			{
				Title = "Carousel",
				IconSource = "contacts.png",
				GetPage = () => new MyCarouselPage()
			});
			masterPageItems.Add(new MasterPageItem
			{
				Title = "TabPanel",
				IconSource = "contacts.png",
				GetPage = () => new MyTabPanelPage()
			});
			masterPageItems.Add(new MasterPageItem
			{
				Title = "Image",
				IconSource = "contacts.png",
				GetPage = () => new MyImagePage()
			});
			masterPageItems.Add(new MasterPageItem
			{
				Title = "Scroll",
				IconSource = "contacts.png",
				GetPage = () => new MyScrollPage()
			});
			masterPageItems.Add(new MasterPageItem
			{
				Title = "Popup",
				IconSource = "contacts.png",
				GetPage = () => new MyPopupPage()
			});

			listView.ItemSelected += OnItemSelected;
			listView.ItemsSource = masterPageItems;
		}

		void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			var item = e.SelectedItem as MasterPageItem;
			if (item != null)
			{
				Page targetPage = item.GetPage();
				((MasterPage)App.Current.MainPage).NavigateTo(targetPage);
			}
		}
	}
}
