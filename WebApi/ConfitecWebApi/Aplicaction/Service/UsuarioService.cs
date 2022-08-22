using Confitec.WebAPI.Aplication.ValueObjects;
using Confitec.WebAPI.Domain.Interfaces.Repository;
using Confitec_Test.Domain.Interfaces.Service;

namespace Confitec_Test.Aplicaction.Service
{
    public class UsuarioService : IUsuarioService
    {
        private IUsuarioRepository _IUsuarioRepository;
        private IHistoricoEscolarRepository _IHistoricoEscolarRepository;
        private IEscolaridadeRepository _IEscolaridadeRepository;
        public UsuarioService(IUsuarioRepository UsuarioRepository, IHistoricoEscolarRepository HistoricoEscolarRepository, IEscolaridadeRepository IEscolaridadeRepository)
        {
            _IUsuarioRepository = UsuarioRepository;
            _IHistoricoEscolarRepository = HistoricoEscolarRepository;
            _IEscolaridadeRepository = IEscolaridadeRepository;
        }

        public async Task<UsuarioVO> Create(UsuarioVO vo)
        {
            var user = await _IUsuarioRepository.Create(vo);

            user.Escolaridade = GetEscolaridadeById(user);
            user.HistoricoEscolar = GetHistoricoById(user);

            return user;
        }

        public async Task<bool> Delete(int id) =>  await _IUsuarioRepository.Delete(id);


        public async Task<IEnumerable<UsuarioVO>> FindAll()
        {
            var user = await _IUsuarioRepository.FindAll();
            user.ToList().ForEach( a =>
            {
                a.Escolaridade = GetEscolaridadeById(a);
                a.HistoricoEscolar = GetHistoricoById(a);                
            });

            return user;
        }

        private EscolaridadeVO GetEscolaridadeById(UsuarioVO a)
        {
            int idEscolaridade;
            Int32.TryParse(a.EscolaridadeId.ToString(), out idEscolaridade);
            a.Escolaridade = _IEscolaridadeRepository.FindById(idEscolaridade);
            return a.Escolaridade;
        }

        private HistoricoEscolarVO GetHistoricoById(UsuarioVO a)
        {
            int idHistorico;
            Int32.TryParse(a.HistoricoEscolarId.ToString(), out idHistorico);
            a.HistoricoEscolar = _IHistoricoEscolarRepository.FindById(idHistorico);
            return a.HistoricoEscolar;
        }

        public UsuarioVO FindById(int id)
        {
            var user = _IUsuarioRepository.FindById(id);

            user.Escolaridade = GetEscolaridadeById(user);
            user.HistoricoEscolar = GetHistoricoById(user);

            return user;
        }

        public async Task<UsuarioVO> Update(UsuarioVO vo)
        {
            var user = await _IUsuarioRepository.Update(vo);

            user.Escolaridade = GetEscolaridadeById(user);
            user.HistoricoEscolar = GetHistoricoById(user);

            return user;
        }
    }
}
