using Confitec.WebAPI.Aplication.ValueObjects;
using Confitec.WebAPI.Domain.Interfaces.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Confitec_Test.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class EscolaridadeController : ControllerBase
    {
        private IEscolaridadeRepository _escolaridadeRepository;
        public EscolaridadeController(IEscolaridadeRepository scolaridadeRepository)
        {
            _escolaridadeRepository = scolaridadeRepository;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EscolaridadeVO>>> FindAll()
        {
            var escolaridade = await _escolaridadeRepository.FindAll();
            return Ok(escolaridade);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<EscolaridadeVO>> FindById(int id)
        {
            var escolaridade =  _escolaridadeRepository.FindById(id);
            if (escolaridade == null) return NotFound();

            return Ok(escolaridade);
        }
        
    }
}
