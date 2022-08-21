using AutoMapper;
using Confitec.Dominio.Interfaces.Repository;
using Confitec.Dominio.ValueObjects;
using Confitec.Infraestrutura.Data.Context;
using Confitec.Infraestrutura.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace Confitec.Infraestrutura.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly SQLServerContext _context;
        private IMapper _mapper;

        public UsuarioRepository(SQLServerContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<UsuarioVO> Create(UsuarioVO vo)
        {
            Usuario usuario = _mapper.Map<Usuario>(vo);
            _context.Usuario.Add(usuario);
            await _context.SaveChangesAsync();
            return _mapper.Map<UsuarioVO>(usuario);
        }

        public async Task<bool> Delete(int id)
        {
            try
            {
                Usuario usuario =
                await _context.Usuario.Where(p => p.Id == id)
                .FirstOrDefaultAsync();

                if (usuario == null) return false;

                _context.Usuario.Remove(usuario);
                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<IEnumerable<UsuarioVO>> FindAll()
        {
            List<Usuario> usuario = await _context.Usuario.ToListAsync();
            return _mapper.Map<List<UsuarioVO>>(usuario);
        }

        public async Task<UsuarioVO> FindById(int id)
        {
            Usuario usuario =
                await _context.Usuario.Where(p => p.Id == id)
                .FirstOrDefaultAsync();
            return _mapper.Map<UsuarioVO>(usuario);
        }

        public async Task<UsuarioVO> Update(UsuarioVO vo)
        {
            Usuario usuario = _mapper.Map<Usuario>(vo);
            _context.Usuario.Update(usuario);
            await _context.SaveChangesAsync();
            return _mapper.Map<UsuarioVO>(usuario);
        }
    }
}
