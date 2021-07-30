using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartSchool.Aplicacao.Alunos.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SmartSchool.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private readonly IAlunoServico _alunoServico;

        public AlunoController(IAlunoServico alunoServico)
        {
            this._alunoServico = alunoServico;
        }

        // GET: api/<AlunoController>
        [HttpGet]
        public IActionResult ObterTodos()
        {
            return Ok(_alunoServico.Obter());
        }

        // GET api/<AlunoController>/5
        //[HttpGet("{id}")]
        //public IActionResult ObterPorId(int id)
        //{
        //    var aluno = _alunoServico.ObterAlunoPorId(id);

        //    if (aluno == null)
        //        throw new Exception($"Não existe aluno com o id {id} informado.");

        //    return Ok(aluno);
        //}

        //[HttpGet("ByName")]
        //public IActionResult ObterPorNome(string nome, string sobrenome)
        //{
        //    var aluno = _alunoServico.ObterTodosAlunos().FirstOrDefault(a => a.Nome.Contains(nome) && a.Sobrenome.Contains(sobrenome));

        //    if (aluno == null)
        //        throw new Exception($"Não existe aluno com o nome {nome} informado.");

        //    return Ok(aluno);
        //}
        //// POST api/<AlunoController>
        //[HttpPost]
        //public IActionResult Criar(Aluno aluno)
        //{
        //    this._alunoServico.Add(aluno);
        //    if (this._alunoServico.SaveChanges())
        //    {
        //        return Ok(aluno);
        //    }

        //    return BadRequest("Aluno não cadastrado.");
        //}

        //// PUT api/<AlunoController>/5
        //[HttpPut("{id}")]
        //public IActionResult Put(int id, Aluno aluno)
        //{
        //    var alunoObtido = _alunoServico.ObterAlunoPorId(id);

        //    if (alunoObtido == null)
        //        throw new Exception($"Não foi encontrado o aluno com ID {id} informado.");

        //    this._alunoServico.Update(aluno);
        //    if (this._alunoServico.SaveChanges())
        //    {
        //        return Ok(aluno);
        //    }

        //    return BadRequest("Aluno não atualizado.");
        //}

        //[HttpPatch("{id}")]
        //public IActionResult Patch(int id, Aluno aluno)
        //{
        //    var alunoObtido = _alunoServico.ObterAlunoPorId(id);

        //    if (alunoObtido == null)
        //        throw new Exception($"Não foi encontrado o aluno com ID {id} informado.");

        //    this._alunoServico.Update(aluno);
        //    if (this._alunoServico.SaveChanges())
        //    {
        //        return Ok(aluno);
        //    }

        //    return BadRequest("Aluno não atualizado.");
        //}

        //// DELETE api/<AlunoController>/5
        //[HttpDelete("{id}")]
        //public IActionResult Delete(int id)
        //{
        //    var aluno = _alunoServico.ObterAlunoPorId(id);

        //    if (aluno == null)
        //        throw new Exception($"Não foi encontrado o aluno com ID {id} informado.");

        //    this._alunoServico.Remove(aluno);
        //    if (this._alunoServico.SaveChanges())
        //    {
        //        return Ok("Aluno deletado.");
        //    }

        //    return BadRequest("Aluno não deletado.");
        //}
    }
}
