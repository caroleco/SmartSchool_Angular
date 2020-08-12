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
    public class ProfessorController : ControllerBase
    {
        private readonly IRepository _repo;

        public ProfessorController(IRepository repo)
        {
            this._repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var result = await _repo.GetAllProfessoresAsync(false);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro {ex.Message}");
            }
        }

        [HttpGet("ById/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var result = await _repo.GetProfessorAsyncById(id, false);
                return Ok(result);
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        [HttpGet("ByAluno/{id}")]
        public async Task<IActionResult> GetIdAluno(int id)
        {
            try
            {
                var result = await _repo.GetProfessoresAsyncByAlunoId(id, true);
                return Ok(result);
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post(Professor model)
        {
            try
            {
                _repo.Add(model);

                if (await _repo.SaveChangesAsync())
                {
                    return Ok(model);
                }
            }
            catch (System.Exception)
            {

                throw;
            }

            return BadRequest("Erro ao salvar.");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Professor model)
        {
            try
            {
                var professor = await _repo.GetProfessorAsyncById(id, false);
                if(professor == null){
                    return NotFound("Professor não encontrado");
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

            return BadRequest("Erro ao salvar.");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var professor = await _repo.GetProfessorAsyncById(id, false);
                if(professor == null){
                    return NotFound();
                }

                _repo.Delete(professor);

                if(await _repo.SaveChangesAsync()){
                    return Ok("Deletado");
                }   
            }
            catch (System.Exception)
            {
                
                throw;
            }

            return BadRequest("Erro ao deletar.");
        }
    }
}