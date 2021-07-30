using SmartSchool.Aplicacao.Alunos.Interface;
using SmartSchool.Comum.Mapeador;
using SmartSchool.Comum.Repositorio;
using SmartSchool.Dominio.Alunos;
using SmartSchool.Dto.Dtos.Alunos;
using SmartSchool.Dto.Dtos.Alunos.Obter;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartSchool.Aplicacao.Alunos.Servico
{
    public class AlunoServico : IAlunoServico
    {
        private readonly IRepositorio<Aluno> _alunoRepositorio;
        public AlunoServico(IRepositorio<Aluno> alunoRepositorio)
        {
            this._alunoRepositorio = alunoRepositorio;
        }

        public IEnumerable<ObterAlunoDto> Obter()
        {
            var alunos = this._alunoRepositorio.Obter();

            return alunos.MapearParaDto<ObterAlunoDto>();
        }

        public void CriarAluno(AlunoDto alunoDto)
        {
            var aluno = Aluno.Criar(alunoDto);

            this._alunoRepositorio.Adicionar(aluno);
        }
    }
}
