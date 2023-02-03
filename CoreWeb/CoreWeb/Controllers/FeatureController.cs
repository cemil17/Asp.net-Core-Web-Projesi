using Microsoft.AspNetCore.Mvc;

namespace CoreWeb.Controllers
{
	public class FeatureController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
