namespace Sara_Kaminer.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
	using Sara_Kaminer.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Sara_Kaminer.Data.Sara_KaminerContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Sara_Kaminer.Data.Sara_KaminerContext context)
        {
			context.Jobs.AddOrUpdate(x => x.JobId,
				new Models.Job() { JobId = 1, JobName = "werf Ausqwqfflten", JobDescription = "", PredictedJobViews = 15, CompanyName = "", DateModify = new DateTime(2022, 01, 01), IsActive = true },
				new Models.Job() { JobId = 2, JobName = "nskacnk knsakln", JobDescription = "", PredictedJobViews = 22, CompanyName = "", DateModify = new DateTime(2022, 01, 01), IsActive = true },
				new Models.Job() { JobId = 3, JobName = "lwkr werertgyh", JobDescription = "", PredictedJobViews = 24, CompanyName = "", DateModify = new DateTime(2022, 01, 02), IsActive = true },
				new Models.Job() { JobId = 4, JobName = "23e wedrfwd", JobDescription = "", PredictedJobViews = 28, CompanyName = "", DateModify = new DateTime(2022, 01, 02), IsActive = true },
				new Models.Job() { JobId = 5, JobName = "szlkdf fefd", JobDescription = "", PredictedJobViews = 17, CompanyName = "", DateModify = new DateTime(2022, 01, 02), IsActive = true },
				new Models.Job() { JobId = 6, JobName = "fesrt jgbfds", JobDescription = "", PredictedJobViews = 19, CompanyName = "", DateModify = new DateTime(2022, 01, 03), IsActive = true },
				new Models.Job() { JobId = 7, JobName = "fer grgege", JobDescription = "", PredictedJobViews = 31, CompanyName = "", DateModify = new DateTime(2022, 01, 03), IsActive = true },
				new Models.Job() { JobId = 8, JobName = "ert jhhggf", JobDescription = "", PredictedJobViews = 25, CompanyName = "", DateModify = new DateTime(2022, 01, 03), IsActive = true }
				);

			context.JobViews.AddOrUpdate(x => x.JobViewId,
				new Models.JobView() { JobViewId = 1, JobId = 1, DateView = new DateTime(2022, 01, 01) },
				new Models.JobView() { JobViewId = 2, JobId = 1, DateView = new DateTime(2022, 01, 01) },
				new Models.JobView() { JobViewId = 3, JobId = 2, DateView = new DateTime(2022, 01, 01) },
				new Models.JobView() { JobViewId = 4, JobId = 1, DateView = new DateTime(2022, 01, 01) },
				new Models.JobView() { JobViewId = 5, JobId = 1, DateView = new DateTime(2022, 01, 01) },
				new Models.JobView() { JobViewId = 6, JobId = 2, DateView = new DateTime(2022, 01, 01) },
				new Models.JobView() { JobViewId = 7, JobId = 2, DateView = new DateTime(2022, 01, 01) },
				new Models.JobView() { JobViewId = 8, JobId = 4, DateView = new DateTime(2022, 01, 02) },
				new Models.JobView() { JobViewId = 9, JobId = 3, DateView = new DateTime(2022, 01, 02) },
				new Models.JobView() { JobViewId = 10, JobId = 4, DateView = new DateTime(2022, 01, 02) },
				new Models.JobView() { JobViewId = 11, JobId = 1, DateView = new DateTime(2022, 01, 02) },
				new Models.JobView() { JobViewId = 12, JobId = 2, DateView = new DateTime(2022, 01, 03) },
				new Models.JobView() { JobViewId = 13, JobId = 8, DateView = new DateTime(2022, 01, 03) },
				new Models.JobView() { JobViewId = 14, JobId = 7, DateView = new DateTime(2022, 01, 03) },
				new Models.JobView() { JobViewId = 15, JobId = 4, DateView = new DateTime(2022, 01, 03) },
				new Models.JobView() { JobViewId = 16, JobId = 4, DateView = new DateTime(2022, 01, 03) },
				new Models.JobView() { JobViewId = 17, JobId = 2, DateView = new DateTime(2022, 01, 03) },
				new Models.JobView() { JobViewId = 18, JobId = 1, DateView = new DateTime(2022, 01, 03) },
				new Models.JobView() { JobViewId = 19, JobId = 3, DateView = new DateTime(2022, 01, 04) },
				new Models.JobView() { JobViewId = 20, JobId = 5, DateView = new DateTime(2022, 01, 04) },
				new Models.JobView() { JobViewId = 21, JobId = 4, DateView = new DateTime(2022, 01, 04) },
				new Models.JobView() { JobViewId = 22, JobId = 8, DateView = new DateTime(2022, 01, 04) },
				new Models.JobView() { JobViewId = 23, JobId = 5, DateView = new DateTime(2022, 01, 04) },
				new Models.JobView() { JobViewId = 24, JobId = 1, DateView = new DateTime(2022, 01, 04) }
				);
		}
    }
}
