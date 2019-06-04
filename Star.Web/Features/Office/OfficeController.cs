using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Star.Data.DataContext;

namespace Star.Web.Features.Office
{
	public class OfficeController : Controller
	{
		private readonly StarDbContext _context;
		private readonly IOfficeViewModelFactory _factory;
		public OfficeController(StarDbContext context, IOfficeViewModelFactory factory)
		{
			_context = context ?? throw new ArgumentNullException(nameof(context));
			_factory = factory ?? throw new ArgumentNullException(nameof(factory));
		}

		public async Task<IActionResult> Index()
		{
			var offices = await _context.Office.ToListAsync();
			var viewModel = _factory.Create(offices);
			return View(viewModel);
		}

		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Create([Bind("Name")]OfficeViewModel viewModel)
		{
			if (ModelState.IsValid && !string.IsNullOrWhiteSpace(viewModel.Name))
			{
				

			}

			return View(viewModel);
		}
	}
}