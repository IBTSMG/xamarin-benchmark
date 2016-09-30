using System;
using Xamarin.Forms;

namespace Demo
{
	public class MasterPageItem
	{
		public string Title { get; set; }

		public string IconSource { get; set; }

		public Func<Page> GetPage { get; set; }
	}
}
