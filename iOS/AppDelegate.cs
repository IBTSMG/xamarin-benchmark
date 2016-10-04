using System;
using System.Collections.Generic;
using System.Linq;
using Demo;
using Foundation;
using UIKit;
using Xamarin.Forms;

/*
[assembly: ExportRenderer(typeof(Telerik.XamarinForms.Chart.RadCartesianChart), typeof(Telerik.XamarinForms.ChartRenderer.iOS.CartesianChartRenderer))]
[assembly: ExportRenderer(typeof(Telerik.XamarinForms.Chart.RadPieChart), typeof(Telerik.XamarinForms.ChartRenderer.iOS.PieChartRenderer))]
*/

namespace Demo.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();

			/*new Telerik.XamarinForms.ChartRenderer.iOS.PieChartRenderer();
			new Telerik.XamarinForms.ChartRenderer.iOS.CartesianChartRenderer();*/

			Xamarin.Forms.Forms.Init();
			//Telerik.XamarinForms.Common.iOS.TelerikForms.Init();

			Xamarin.FormsMaps.Init();

			LoadApplication(new App());

			return base.FinishedLaunching(app, options);
		}
	}
}
