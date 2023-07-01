using System.Web.Mvc;

namespace Practical_15_Form_AUth.Controllers
{
	//[Authorize]
	public class HomeController : Controller
	{
		[Authorize]
		public ActionResult Index()
		{
			return View();
		}

		//[Authorize]
		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}


	}
}