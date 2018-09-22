using AoSoftware.Models;
using JsonSettings;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace AoSoftware.Classes
{
	public class BaseController : Controller
	{
		protected IEnumerable<Project> GetProjects()
		{
			string projectsFile = Server.MapPath("~/Data/projects.json");
			return JsonFile.Load<IEnumerable<Project>>(projectsFile);
		}

		protected Dictionary<string, Project> ProjectsDictionary
		{
			get
			{
				var projects = GetProjects();
				return projects.ToDictionary(row => row.Key);
			}
		}
	}
}