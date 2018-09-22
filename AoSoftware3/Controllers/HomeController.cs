using AoSoftware.Classes;
using System.Web.Mvc;

namespace AoSoftware.Controllers
{
	public class HomeController : BaseController
	{
		public ActionResult Index()
		{
			var projects = GetProjects();
			return View(projects);
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}