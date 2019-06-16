using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Star.Data.DataContext;
using Star.Data.Models;

namespace Star.Repository.Repositories.OfficeRepository
{
	public class OfficeRepository : RepositoryBase<Office>, IOfficeRepository
	{
		private readonly StarDbContext _context;
		private readonly IMapper _mapper;

		public OfficeRepository(StarDbContext context, IMapper mapper)
		{
			_context = context ?? throw new ArgumentNullException(nameof(context));
			_mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
		}

		public override async Task<IEnumerable<Office>> GetAllAsync() => await _context.Office.ToListAsync();

		public override async Task<Office> GetByIdAsync(int id) => await _context.Office.FindAsync(id);
		public override async Task<Office> GetByContentIdAsync(Guid contentId)
		{
			var model = await _context.Office.FindAsync(contentId);
			return model;
		}

		public override async Task InsertAsync(Office model)
		{
			await _context.Office.AddAsync(new Office
			{
				Name = model.Name,
			});

			await _context.SaveChangesAsync();
		}
	}
}
