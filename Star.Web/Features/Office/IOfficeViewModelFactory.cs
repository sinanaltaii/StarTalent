using System.Collections.Generic;
using Star.Service.OfficeUoW;


namespace Star.Web.Features.Office
{
	public interface IOfficeViewModelFactory
	{
		OfficeViewModel Create(OfficeModel viewModel);
		IEnumerable<OfficeViewModel> Create(IEnumerable<OfficeModel> offices);
	}
}