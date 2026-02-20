using Microsoft.AspNetCore.Mvc;

namespace OtoSevk.WebUI.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class MainController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
