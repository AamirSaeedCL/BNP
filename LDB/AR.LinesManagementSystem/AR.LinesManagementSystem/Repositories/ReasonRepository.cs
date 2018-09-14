using AR.LinesManagementSystem.Api.Models.Dto;
using AR.LinesManagementSystem.Context;
using AR.LinesManagementSystem.Models;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AR.LinesManagementSystem.Repositories
{
    public class ReasonRepository : Repository<Reason>
    {
        private readonly IMapper _mapper;
        public ReasonRepository(ArDBContext _context, IMapper mapper) : base(_context)
        {
            _mapper = mapper;
        }

        public async Task<List<ReasonDto>> GetReasons()
        {
            var list = await GetAllAsync();
            var result = _mapper.Map<List<ReasonDto>>(list).OrderBy(c => c.Name).ToList();
            return result;
        }

        public async Task<ReasonDto> GetReason(int? Id)
        {
            var category = await GetByIdAsync(Id);
            var result = _mapper.Map<ReasonDto>(category);
            return result;
        }

        public async Task<bool> DuplicateEntryAsync(string name, int Id)
        {
            var row = await Find(r => r.Name == name && r.Id != Id);
            return row.Count > 0 ? true : false;
        }
    }
}