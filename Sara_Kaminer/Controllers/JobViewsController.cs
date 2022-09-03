using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using Sara_Kaminer.Data;
using Sara_Kaminer.Models;

namespace Sara_Kaminer.Controllers
{
	public class JobViewsController : ApiController
	{
		private Sara_KaminerContext db = new Sara_KaminerContext();

		// GET: api/JobViews
		public List<Graph> GetJobViews()
		{
			var JobViews = db.Database.SqlQuery<Graph>("Graph_SLCT").ToList();
			return JobViews.ToList();
		}
	}
}