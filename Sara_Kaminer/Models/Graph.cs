using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sara_Kaminer.Models
{
	public class Graph
	{
		public DateTime Date { get; set; }
		public int JobView { get; set; }
		public int PredictedJobViews { get; set; }
		public int? ActiveJobs { get; set; }
		
	}
}