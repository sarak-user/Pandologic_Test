using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Sara_Kaminer.Models
{
	public class Job
	{
		public int JobId{ get; set; }
		[Required]
		public string JobName { get; set; }
		public string JobDescription { get; set; }
		public string CompanyName { get; set; }
		public bool  IsActive{ get; set; }
		public int PredictedJobViews { get; set; }
		public DateTime DateModify { get; set; }

	}
}