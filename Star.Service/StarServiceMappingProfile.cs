using AutoMapper;
using Star.Data.Models;
using Star.Service.OfficeUoW;

namespace Star.Service
{
	public class StarServiceMappingProfile : Profile
	{
		public StarServiceMappingProfile()
		{
			CreateMap<OfficeModel, Office>();
		}
	}
}
