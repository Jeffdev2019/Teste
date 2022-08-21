using AutoMapper;
using Confitec.WebAPI.Aplication.ValueObjects;
using Confitec.WebAPI.Domain.Interfaces.Repository;
using Confitec.WebAPI.Infra.Data.Context;
using Confitec.WebAPI.Infra.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace Confitec.WebAPI.Infra.Repository
{
    public class EscolaridadeRepository : IEscolaridadeRepository
    {
        private readonly SQLServerContext _context;
        private IMapper _mapper;

        public EscolaridadeRepository(SQLServerContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<EscolaridadeVO> Create(EscolaridadeVO vo)
        {
            Escolaridade escolaridade = _mapper.Map<Escolaridade>(vo);
            _context.Escolaridade.Add(escolaridade);
            await _context.SaveChangesAsync();
            return _mapper.Map<EscolaridadeVO>(escolaridade);
        }

        public async Task<bool> Delete(int id)
        {
            try
            {
                Escolaridade escolaridade =
                await _context.Escolaridade.Where(p => p.IdEscolaridade == id)
                .FirstOrDefaultAsync();

                if (escolaridade == null) return false;

                _context.Escolaridade.Remove(escolaridade);
                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<IEnumerable<EscolaridadeVO>> FindAll()
        {
            List<Escolaridade> escolaridade = await _context.Escolaridade.ToListAsync();
            return _mapper.Map<List<EscolaridadeVO>>(escolaridade);
        }

        public EscolaridadeVO FindById(int id)
        {
            Escolaridade escolaridade =
                 _context.Escolaridade.Where(p => p.IdEscolaridade == id)
                .FirstOrDefault();
            return _mapper.Map<EscolaridadeVO>(escolaridade);
        }

        public async Task<EscolaridadeVO> Update(EscolaridadeVO vo)
        {
            Escolaridade escolaridade = _mapper.Map<Escolaridade>(vo);
            _context.Escolaridade.Update(escolaridade);
            await _context.SaveChangesAsync();
            return _mapper.Map<EscolaridadeVO>(escolaridade);
        }
    }
}
