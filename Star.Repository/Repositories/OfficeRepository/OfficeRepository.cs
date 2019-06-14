using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Star.Data.DataContext;
using Star.Data.Models;

namespace Star.Repository.Repositories.OfficeRepository
{
	public class OfficeRepository : RepositoryBase<Office>, IOfficeRepository
	{
		private readonly StarDbContext _context;

		public OfficeRepository(StarDbContext context)
		{
			_context = context ?? throw new ArgumentNullException(nameof(context));
		}

		public override async Task<IEnumerable<Office>> GetAllAsync() => await _context.Office.ToListAsync();

		public override async Task<Office> GetByIdAsync(int id) => await _context.Office.FindAsync(id);
		public override async Task InsertAsync(Office model)
		{
			//TODO: automapper here to map employeemodel  to employee
			await _context.Office.AddAsync(new Office
			{
				ContentfulId = model.ContentfulId,
				Name = model.Name,
				Employee = new List<Employee>()
			});
		}
	}
}
