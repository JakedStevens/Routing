using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RoutingIsF.Models;

namespace RoutingIsF.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			return View();
		}

		[Route("watch/")]
		public IActionResult Watch(string v)
		{
			return View("Watch", v);
		}

		[Route("gp/buyagain")]
		public IActionResult GP(string ie, string ref_)
		{
			ViewBag.ie = ie;
			ViewBag.ref_ = ref_;
			return View("GP");
		}

		[Route("HighKey-Snacks-Keto-Mini-Cookies/dp/B07JYS45BT")]
		public IActionResult HighKey(string pf_rd_p, string pf_rd_r, string pd_rd_r, string pd_rd_wg, string pd_rd_i, string psc, string ref_)
		{
			ViewBag.pf_rd_p = pf_rd_p;
			ViewBag.pf_rd_r = pf_rd_r;
			ViewBag.pd_rd_r = pd_rd_r;
			ViewBag.pd_rd_wg = pd_rd_wg;
			ViewBag.pd_rd_i = pd_rd_i;
			ViewBag.psc = psc;
			ViewBag.ref_ = ref_;

			ViewBag.path = Request.Path.ToString();
			ViewBag.routevalues = Request.RouteValues;
			ViewBag.query = Request.Query;

			var path = Request.Path.ToString();
			var queries = Request.QueryString;

			var concat = $"{path}{queries}";
			ViewBag.concat = concat;

			return View("HighKey");
		}

		[Route("2021/06/15/politics/{slug}")]
		public IActionResult Politics(string slug)
		{
			ViewBag.slug = slug;
			return View("Politics");
		}

		[Route("shows/{slug1}/{slug2}/{slug3}/{slug4}")]
		public IActionResult Shows(string slug1, string slug2, string slug3, string slug4)
		{
			ViewBag.slug1 = slug1;
			ViewBag.slug2 = slug2;
			ViewBag.slug3 = slug3;
			ViewBag.slug4 = slug4;
			return View("Shows");
		}

		[Route("/en-us/powerapps/{slug2}/{slug3}/")]
		public IActionResult PowerApps(string slug2, string slug3)
		{
			ViewBag.slug2 = slug2;
			ViewBag.slug3 = slug3;
			return View("PowerApps");
		}

		[Route("/main")]
		public IActionResult Main(string app, string forceUCI, string pagetype, string id, string type)
		{
			ViewBag.app = app;
			ViewBag.forceUCI = forceUCI;
			ViewBag.pagetype = pagetype;
			ViewBag.id = id;
			ViewBag.type = type;
			return View("Main");
		}
		
		[Route("/manage/{slug1}/{slug2}/{slug3}/{slug4}/{slug5}")]
		public IActionResult Manage(string slug1, string slug2, string slug3, string slug4, string slug5)
		{
			ViewBag.slug1 = slug1;
			ViewBag.slug2 = slug2;
			ViewBag.slug3 = slug3;
			ViewBag.slug4 = slug4;
			ViewBag.slug5 = slug5;
			return View();
		}

		[Route("/environments/environment/{slug1}/{slug2}")]
		public IActionResult Environments(string slug1, string slug2, string geo)
		{
			ViewBag.slug1 = slug1;
			ViewBag.slug2 = slug2;
			ViewBag.geo = geo;
			return View("Environments");
		}

		[Route("/en-us/{slug1}")]
		public IActionResult PDP(string slug1, string id)
		{
			ViewBag.slug1 = slug1;
			ViewBag.id = id;
			return View();
		}

		[Route("2021/06/15/{slug}")]
		public IActionResult Uberall(string slug)
		{
			ViewBag.slug = slug;
			return View("Uberall");
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
