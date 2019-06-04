using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Star.Data.Models;

namespace Star.Repository.Repositories
{
	public class OfficeRepository : RepositoryBase<Office>
	{
		public override Task<IEnumerable<Office>> GetAllAsync()
		{
			throw new NotImplementedException();
		}

		public override Task<Office> GetByIdAsync(int id)
		{
			throw new NotImplementedException();
		}
	}
}
