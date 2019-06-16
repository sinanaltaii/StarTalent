using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Star.Service.OfficeUoW
{
	public interface IOfficeUnitOfWork
	{
		Task<IEnumerable<OfficeModel>> GetAllAsync();
		Task<OfficeModel> GetbyIdAsync(int id);
		Task<OfficeModel> GetByContentIdAsync(Guid contentId);
		Task InsertAsync(OfficeModel officeModel);
	}
}
