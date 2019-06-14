using System;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Star.Service.OfficeUoW;

namespace Star.Web.Features.Office
{
	public class OfficeController : Controller
	{
		private readonly IOfficeUoW _service;
		private readonly IOfficeViewModelFactory _viewModelFactory;

		public OfficeController(IMapper mapper, IOfficeUoW service, IOfficeViewModelFactory factory)
		{
			_service = service ?? throw new ArgumentNullException(nameof(service));
			_viewModelFactory = factory ?? throw new ArgumentNullException(nameof(factory));
		}

		public async Task<IActionResult> Index()
		{
			var offices = await _service.GetAllAsync();
			var viewModel = _viewModelFactory.Create(offices);
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