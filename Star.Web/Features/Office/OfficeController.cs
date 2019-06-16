using System;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Star.Service.OfficeUoW;

namespace Star.Web.Features.Office
{
	public class OfficeController : Controller
	{
		private readonly IOfficeUnitOfWork _officeUoW;
		private readonly IOfficeViewModelFactory _viewModelFactory;
		private readonly IMapper _mapper;

		public OfficeController(IMapper mapper, IOfficeUnitOfWork service, IOfficeViewModelFactory factory)
		{
			_officeUoW = service ?? throw new ArgumentNullException(nameof(service));
			_viewModelFactory = factory ?? throw new ArgumentNullException(nameof(factory));
			_mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
		}

		public async Task<IActionResult> Index()
		{
			var offices = await _officeUoW.GetAllAsync();
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
				var model = _mapper.Map<OfficeViewModel, OfficeModel>(viewModel);
				await _officeUoW.InsertAsync(model);
				return RedirectToAction(nameof(Index));
			}

			return View(viewModel);
		}
	}
}