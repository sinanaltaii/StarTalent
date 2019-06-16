using AutoMapper;
using Star.Service.OfficeUoW;
using Star.Web.Features.Office;

namespace Star.Web
{
	public class StarWebMapperProfile : Profile
	{
		public StarWebMapperProfile()
		{
			CreateMap<OfficeModel, OfficeViewModel>();
			CreateMap<OfficeViewModel, OfficeModel>();
		}
	}
}
