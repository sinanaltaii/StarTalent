using System;
using System.Collections.Generic;
using AutoMapper;
using Star.Service.OfficeUoW;

namespace Star.Web.Features.Office
{
	public class OfficeViewModelFactory : IOfficeViewModelFactory
	{
		private readonly IMapper _mapper;

		public OfficeViewModelFactory(IMapper mapper)
		{
			_mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
		}

		public OfficeViewModel Create(OfficeModel viewModel)
		{
			throw new System.NotImplementedException();
		}

		public IEnumerable<OfficeViewModel> Create(IEnumerable<OfficeModel> offices)
		{
			var viewModel = _mapper.Map<IEnumerable<OfficeModel>, IEnumerable<OfficeViewModel>>(offices);
			return viewModel;
		}
	}
}
