using System.Collections.Generic;
using System.Threading.Tasks;

namespace Star.Service.OfficeUoW
{
	public interface IOfficeUnitOfWork
	{
		Task<IEnumerable<OfficeModel>> GetAllAsync();
		Task<OfficeModel> GetbyIdAsync(int id);
		Task InsertAsync(OfficeModel officeModel);
	}
}
