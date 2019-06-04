using System.Collections.Generic;
using OfficeModel = Star.Data.Models.Office;

namespace Star.Web.Features.Office
{
	public interface IOfficeViewModelFactory
	{
		IEnumerable<OfficeViewModel> Create(IEnumerable<OfficeModel> offices);
		OfficeModel Create(OfficeViewModel viewModel);
	}
}
