using AoSoftware.Classes;
using System.Web.Mvc;

namespace AoSoftware.Controllers
{
	public class ProjectsController : BaseController
	{
		public ActionResult Index(string key)
		{
			var project = ProjectsDictionary[key];
			return View(key, project);
		}
	}
}