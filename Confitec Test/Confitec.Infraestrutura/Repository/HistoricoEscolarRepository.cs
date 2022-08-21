using AutoMapper;
using Confitec.Aplicacao.ValueObjects;
using Confitec.Dominio.Interfaces.Repository;
using Confitec.Infraestrutura.Data.Context;
using Confitec.Infraestrutura.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace Confitec.Infraestrutura.Repository
{
    public class HistoricoEscolarRepository : IHistoricoEscolarRepository
    {
        private readonly SQLServerContext _context;
        private IMapper _mapper;

        public HistoricoEscolarRepository(SQLServerContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<HistoricoEscolarVO> Create(HistoricoEscolarVO vo)
        {
            HistoricoEscolar historicoEscolar = _mapper.Map<HistoricoEscolar>(vo);
            _context.HistoricoEscolar.Add(historicoEscolar);
            await _context.SaveChangesAsync();
            return _mapper.Map<HistoricoEscolarVO>(historicoEscolar);
        }

        public async Task<bool> Delete(int id)
        {
            try
            {
                HistoricoEscolar historicoEscolar =
                await _context.HistoricoEscolar.Where(p => p.Id == id)
                .FirstOrDefaultAsync();

                if (historicoEscolar == null) return false;

                _context.HistoricoEscolar.Remove(historicoEscolar);
                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<IEnumerable<HistoricoEscolarVO>> FindAll()
        {
            List<HistoricoEscolar> historicoEscolar = await _context.HistoricoEscolar.ToListAsync();
            return _mapper.Map<List<HistoricoEscolarVO>>(historicoEscolar);
        }

        public async Task<HistoricoEscolarVO> FindById(int id)
        {
            HistoricoEscolar historicoEscolar =
                await _context.HistoricoEscolar.Where(p => p.Id == id)
                .FirstOrDefaultAsync();
            return _mapper.Map<HistoricoEscolarVO>(historicoEscolar);
        }

        public async Task<HistoricoEscolarVO> Update(HistoricoEscolarVO vo)
        {
            HistoricoEscolar historicoEscolar = _mapper.Map<HistoricoEscolar>(vo);
            _context.HistoricoEscolar.Update(historicoEscolar);
            await _context.SaveChangesAsync();
            return _mapper.Map<HistoricoEscolarVO>(historicoEscolar);
        }
    }
}
