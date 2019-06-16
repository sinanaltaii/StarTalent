using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Star.Data.Models;
using Star.Repository.Repositories.OfficeRepository;
using Star.Service.EmployeeUoW;

namespace Star.Service.OfficeUoW
{
	public class OfficeUnitOfWork : IOfficeUnitOfWork
	{
		private readonly IMapper _mapper;
		private readonly OfficeRepository _repository;

		public OfficeUnitOfWork(IMapper mapper, OfficeRepository repository)
		{
			_mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
			_repository = repository ?? throw new ArgumentNullException(nameof(repository));
		}

		public async Task<IEnumerable<OfficeModel>> GetAllAsync()
		{
			var offices = await _repository.GetAllAsync();
			var officeModel = _mapper.Map<IEnumerable<Office>, IEnumerable<OfficeModel>>(offices);
			return officeModel;
		}

		public async Task<OfficeModel> GetbyIdAsync(int id)
		{
			var office = await _repository.GetByIdAsync(id);
			//TODO: convert office.Employee list to list of EmployeeModel
			var officeModel = new OfficeModel
			{
				ContentfulId = office.ContentfulId,
				Name = office.Name,
				Employees = new List<EmployeeModel>()
			};

			return officeModel;
		}

		public async Task<OfficeModel> GetByContentIdAsync(Guid contentId)
		{
			var entity = await _repository.GetByContentIdAsync(contentId);
			var officeModel = _mapper.Map<OfficeModel>(entity);
			return officeModel;
		}

		public async Task InsertAsync(OfficeModel officeModel)
		{
			var domainModel = _mapper.Map<OfficeModel, Office>(officeModel);
			await _repository.InsertAsync(domainModel);
		}
	}
}
