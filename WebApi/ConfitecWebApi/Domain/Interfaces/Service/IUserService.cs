using Confitec.WebAPI.Aplication.ValueObjects;

namespace Confitec_Test.Domain.Interfaces.Service
{
    public interface IUsuarioService
    {
        Task<IEnumerable<UsuarioVO>> FindAll();
        UsuarioVO FindById(int id);
        Task<UsuarioVO> Create(UsuarioVO vo);
        Task<UsuarioVO> Update(UsuarioVO vo);
        Task<bool> Delete(int id);
    }
}
