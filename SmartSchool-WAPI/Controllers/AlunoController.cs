using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SmartSchool_WAPI.Data;
using SmartSchool_WAPI.Models;

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
        public async Task<IActionResult> Post(Aluno model)
        {
            try
            {
                _repo.Add(model);

                if(await _repo.SaveChangesAsync()){
                    return Ok(model);
                }                
            }
            catch (System.Exception)
            {                
                throw;
            }

            return BadRequest("Erro ao salvar");
        }

        [HttpPut("{AlunoId}")]
        public async Task<IActionResult> Put(int AlunoId, Aluno model)
        {
            try
            {
                var aluno = await _repo.GetAlunoAsyncById(AlunoId, false);

                if(aluno == null){
                    return NotFound();
                }

                _repo.Update(model);

                if(await _repo.SaveChangesAsync()){
                    return Ok(model);
                }                
            }
            catch (System.Exception)
            {                
                throw;
            }

            return BadRequest("Erro ao salvar");
        }

        [HttpDelete("{AlunoId}")]
        public async Task<IActionResult> Delete(int AlunoId)
        {
            try
            {
                var aluno = await _repo.GetAlunoAsyncById(AlunoId, false);

                if(aluno == null){
                    return NotFound();
                }

                _repo.Delete(aluno);

                if(await _repo.SaveChangesAsync()){
                    return Ok("Deletado");
                }   
                
            }
            catch (System.Exception)
            {                
                throw;
            }

            return BadRequest("Erro ao salvar");
        }
    }
}