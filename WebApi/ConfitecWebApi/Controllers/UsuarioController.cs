using Confitec.WebAPI.Aplication.ValueObjects;
using Confitec_Test.Domain.Interfaces.Service;
using Microsoft.AspNetCore.Mvc;

namespace Confitec_Test.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UsuarioVO>>> FindAll()
        {
            var user = await _usuarioService.FindAll();            
            return Ok(user);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UsuarioVO>> FindById(int id)
        {
            var user = _usuarioService.FindById(id);
            if (user == null) return NotFound();

            return Ok(user);
        }

        [HttpPost]
        public async Task<ActionResult<UsuarioVO>> Create(UsuarioVO vo)
        {
            if (vo == null) return BadRequest();
            var user = await _usuarioService.Create(vo);
            return Ok(user);
        }
        [HttpPut]
        public async Task<ActionResult<UsuarioVO>> Update(UsuarioVO vo)
        {
            if (vo == null) return BadRequest();
            var user = await _usuarioService.Update(vo);
            return Ok(user);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var status = await _usuarioService.Delete(id);
            if (!status) return BadRequest();
            return Ok(status);
        }
    }
}
