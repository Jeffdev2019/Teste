using AutoMapper;
using Confitec.Aplicacao.ValueObjects;
using Confitec.Dominio.Interfaces.Repository;
using Confitec.Infraestrutura.Data.Context;
using Confitec.Infraestrutura.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace Confitec.Infraestrutura.Repository
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
                await _context.Escolaridade.Where(p => p.Id == id)
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

        public async Task<EscolaridadeVO> FindById(int id)
        {
            Escolaridade escolaridade =
                await _context.Escolaridade.Where(p => p.Id == id)
                .FirstOrDefaultAsync();
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
