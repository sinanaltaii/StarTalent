using System.Collections.Generic;
using System.Threading.Tasks;
using Star.Data.Models;

namespace Star.Repository.Repositories
{
	public abstract class RepositoryBase<T> : IRepository<T> where T : BaseModel
	{
		public abstract Task<IEnumerable<T>> GetAllAsync();
		public abstract Task<T> GetByIdAsync(int id);
	}
}
