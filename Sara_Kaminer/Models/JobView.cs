using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Sara_Kaminer.Models
{
	public class JobView
	{
		public int JobViewId { get; set; }
		[Required]
		public int JobId { get; set; }
		public virtual Job Job { get; set; }
		public DateTime DateView { get; set; }

	}
}