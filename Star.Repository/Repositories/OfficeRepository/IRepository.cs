﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace Star.Repository.Repositories
{
	public interface IRepository<T>
	{
		Task<IEnumerable<T>> GetAllAsync();
		Task<T> GetByIdAsync(int id);
	}
}
