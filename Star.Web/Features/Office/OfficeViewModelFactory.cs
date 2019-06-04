using System.Collections.Generic;
using System.Linq;
using OfficeModel = Star.Data.Models.Office;

namespace Star.Web.Features.Office
{
	public class OfficeViewModelFactory : IOfficeViewModelFactory
	{
		public OfficeViewModelFactory()
		{

		}

		public IEnumerable<OfficeViewModel> Create(IEnumerable<OfficeModel> offices)
		{
			var viewModel = offices as List<OfficeModel> ?? offices.ToList();
			return viewModel.Any() ? viewModel.Cast<OfficeViewModel>() : Enumerable.Empty<OfficeViewModel>();
		}

		public OfficeModel Create(OfficeViewModel viewModel)
		{
			throw new System.NotImplementedException();
		}
	}
}
