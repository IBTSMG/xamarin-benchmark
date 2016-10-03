using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Demo
{
	public class ChartViewModel
	{
		public ChartViewModel()
		{
			this.Data = GetCategoricalData();
		}

		public List<CategoricalData> Data { get; set; }

		public string Title { get; set; }

		public static List<CategoricalData> GetCategoricalData()
		{
			List<CategoricalData> data = new List<CategoricalData>
			{
				new CategoricalData { Category = "A", Value = 0.63 },
				new CategoricalData { Category = "B", Value = 0.85 },
				new CategoricalData { Category = "C", Value = 1.05 },
				new CategoricalData { Category = "D", Value = 0.96 },
				new CategoricalData { Category = "E", Value = 0.78 },
			};

			return data;
		}
	}
}
