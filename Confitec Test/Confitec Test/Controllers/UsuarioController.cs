using Confitec.WebAPI.Aplication.ValueObjects;
using Confitec.WebAPI.Domain.Interfaces.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Confitec_Test.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private IUsuarioRepository _IUsuarioRepository;
        private IHistoricoEscolarRepository _IHistoricoEscolarRepository;
        private IEscolaridadeRepository _IEscolaridadeRepository;
        public UsuarioController(IUsuarioRepository UsuarioRepository, IHistoricoEscolarRepository HistoricoEscolarRepository, IEscolaridadeRepository IEscolaridadeRepository)
        {
            _IUsuarioRepository = UsuarioRepository;
            _IHistoricoEscolarRepository = HistoricoEscolarRepository;
            _IEscolaridadeRepository = IEscolaridadeRepository;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UsuarioVO>>> FindAll()
        {
            var user = await _IUsuarioRepository.FindAll();
            user.ToList().ForEach(async a => 
            {
                a.Escolaridade =  _IEscolaridadeRepository.FindById(a.EscolaridadeId);
                a.HistoricoEscolar =  _IHistoricoEscolarRepository.FindById(a.HistoricoEscolarId);
            });
            await Task.Delay(50);
            return Ok(user);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UsuarioVO>> FindById(int id)
        {
            var user = _IUsuarioRepository.FindById(id);
            if (user == null) return NotFound();

            return Ok(user);
        }

        [HttpPost]
        public async Task<ActionResult<UsuarioVO>> Create(UsuarioVO vo)
        {
            if (vo == null) return BadRequest();
            var user = await _IUsuarioRepository.Create(vo);
            return Ok(user);
        }

        public async Task<ActionResult<UsuarioVO>> Update(UsuarioVO vo)
        {
            if (vo == null) return BadRequest();
            var user = await _IUsuarioRepository.Update(vo);
            return Ok(user);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var status = await _IUsuarioRepository.Delete(id);
            if (!status) return BadRequest();
            return Ok(status);
        }
    }
}
