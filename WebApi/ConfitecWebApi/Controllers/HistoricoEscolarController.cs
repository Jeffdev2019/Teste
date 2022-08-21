using Confitec.WebAPI.Aplication.ValueObjects;
using Confitec.WebAPI.Domain.Interfaces.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Confitec_Test.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class HistoricoEscolarController : ControllerBase
    {
        private IHistoricoEscolarRepository _historicoEscolarRepository;
        public HistoricoEscolarController(IHistoricoEscolarRepository historicoEscolarRepository)
        {
            _historicoEscolarRepository = historicoEscolarRepository;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HistoricoEscolarVO>>> FindAll()
        {
            var historico = await _historicoEscolarRepository.FindAll();
            return Ok(historico);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<HistoricoEscolarVO>> FindById(int id)
        {
            var historico =  _historicoEscolarRepository.FindById(id);
            if (historico == null) return NotFound();

            return Ok(historico);
        }

        [HttpPost]
        public async Task<ActionResult<HistoricoEscolarVO>> Create(HistoricoEscolarVO vo)
        {
            if (vo == null) return BadRequest();
            var historico = await _historicoEscolarRepository.Create(vo);
            return Ok(historico);
        }

        public async Task<ActionResult<HistoricoEscolarVO>> Update(HistoricoEscolarVO vo)
        {
            if (vo == null) return BadRequest();
            var historico = await _historicoEscolarRepository.Update(vo);
            return Ok(historico);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var status = await _historicoEscolarRepository.Delete(id);
            if (!status) return BadRequest();
            return Ok(status);
        }
    }
}
