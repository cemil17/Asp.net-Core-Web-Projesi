using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreWeb.Controllers
{
	public class PortfolioController : Controller
	{
		PortfolioManager portfolioManager = new PortfolioManager(new EFPortfolioDal());
		public IActionResult Index()
		{
			var listed = portfolioManager.TGetList();
			return View(listed);
		}
		[HttpGet]
		public IActionResult PortfolioAdd()
		{
			return View();
		}
		[HttpPost]
		public IActionResult PortfolioAdd(Portfolio portfolio)
		{
			portfolioManager.TAdd(portfolio);
			return RedirectToAction("Index");
		}
	}
}
