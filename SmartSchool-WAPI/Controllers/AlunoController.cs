using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SmartSchool_WAPI.Data;

namespace SmartSchool_WAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private readonly IRepository _repo;
        public AlunoController(IRepository repo)
        {
            this._repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var result = await _repo.GetAllAlunosAsync(true);

                return Ok(result);
            }
            catch (System.Exception)
            {                
                throw;
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var result = await _repo.GetAlunoAsyncById(id, true);

                return Ok(result);
            }
            catch (System.Exception)
            {                
                throw;
            }
        }

        [HttpGet("ByDisciplina/{discId}")]
        public async Task<IActionResult> GetByIdDisciplina(int discid)
        {
            try
            {
                var result = await _repo.GetAlunosAsyncByDisciplinaId(discid, false);

                return Ok(result);
            }
            catch (System.Exception)
            {                
                throw;
            }
        }

        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}