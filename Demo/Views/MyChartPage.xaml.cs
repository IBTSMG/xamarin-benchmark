using System;
using System.Collections.Generic;
//using Telerik.XamarinForms.Chart;

using Xamarin.Forms;

namespace Demo
{
	public partial class MyChartPage : ContentPage
	{
		public MyChartPage()
		{
			InitializeComponent();

			/*this.BindingContext = new ChartViewModel();
			this.Content = CreateChart();*/
		}

		/*private static RadCartesianChart CreateChart()
		{
			var chart = new RadCartesianChart
			{
				HorizontalAxis = new Telerik.XamarinForms.Chart.CategoricalAxis(),
				VerticalAxis = new Telerik.XamarinForms.Chart.NumericalAxis(),
			};

			var series = CreateSeries();

			chart.Series.Add(series);
			return chart;
		}

		private static BarSeries CreateSeries()
		{
			var series = new Telerik.XamarinForms.Chart.BarSeries();
			series.SetBinding(BarSeries.ItemsSourceProperty, new Binding("Data"));

			series.ValueBinding = new Telerik.XamarinForms.Chart.PropertyNameDataPointBinding
			{
				PropertyName = "Value"
			};

			series.CategoryBinding = new Telerik.XamarinForms.Chart.PropertyNameDataPointBinding
			{
				PropertyName = "Category"
			};

			return series;
		}*/
	}
}
