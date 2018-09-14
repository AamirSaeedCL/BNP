using AR.LinesManagementSystem.Api.Models.Dto;
using AR.LinesManagementSystem.Context;
using AR.LinesManagementSystem.Models;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AR.LinesManagementSystem.Repositories
{
    public class ConnectivityCategoryRepository : Repository<ConnectivityCategory>
    {
        private readonly IMapper _mapper;
        public ConnectivityCategoryRepository(ArDBContext _context, IMapper mapper) : base(_context)
        {
            _mapper = mapper;
        }

        public async Task<List<ConfigurationDto>> GetConnectivityCategories()
        {
            var categoriesList = await GetAllAsync();
            var result = _mapper.Map<List<ConfigurationDto>>(categoriesList).OrderBy(c => c.Name).ToList();
            return result;
        }

        public async Task<ConfigurationDto> GetConnectivityCategory(int? Id)
        {
            var category = await GetByIdAsync(Id);
            var result = _mapper.Map<ConfigurationDto>(category);
            return result;
        }

        public async Task<bool> DuplicateEntryAsync(string name, int Id)
        {
            var row = await Find(r => r.Name == name && r.Id != Id);
            return row.Count > 0 ? true : false;
        }
    }
}


