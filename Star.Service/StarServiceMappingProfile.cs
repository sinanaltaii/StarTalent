using AutoMapper;
using Star.Data.Models;
using Star.Service.OfficeUoW;

namespace Star.Service
{
	public class StarServiceMappingProfile : Profile
	{
		public StarServiceMappingProfile()
		{
			MapToOfficeDomain();
			MapToOfficeModel();
		}

		private void MapToOfficeModel()
		{
			CreateMap<Office, OfficeModel>()
				.ForMember(m => m.ContentfulId, opt => opt.MapFrom(src => src.ContentfulId));
		}

		private void MapToOfficeDomain()
		{
			CreateMap<OfficeModel, Office>();
		}
	}
}
