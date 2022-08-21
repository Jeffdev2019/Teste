using Confitec.WebAPI.Aplication.ValueObjects;
using Confitec.WebAPI.Domain.Interfaces.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Confitec_Test.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private IUsuarioRepository IUsuarioRepository;
        public UsuarioController(IUsuarioRepository UsuarioRepository)
        {
            IUsuarioRepository = UsuarioRepository;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UsuarioVO>>> FindAll()
        {
            var user = await IUsuarioRepository.FindAll();
            return Ok(user);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UsuarioVO>> FindById(int id)
        {
            var user = await IUsuarioRepository.FindById(id);
            if (user == null) return NotFound();

            return Ok(user);
        }

        [HttpPost]
        public async Task<ActionResult<UsuarioVO>> Create(UsuarioVO vo)
        {
            if (vo == null) return BadRequest();
            var user = await IUsuarioRepository.Create(vo);
            return Ok(user);
        }

        public async Task<ActionResult<UsuarioVO>> Update(UsuarioVO vo)
        {
            if (vo == null) return BadRequest();
            var user = await IUsuarioRepository.Update(vo);
            return Ok(user);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var status = await IUsuarioRepository.Delete(id);
            if (!status) return BadRequest();
            return Ok(status);
        }
    }
}
