using SmartSchool.Dto.Dtos.Alunos;
using SmartSchool.Dto.Dtos.Alunos.Obter;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartSchool.Aplicacao.Alunos.Interface
{
    public interface IAlunoServico
    {
        IEnumerable<ObterAlunoDto> Obter();

        void CriarAluno(AlunoDto alunoDto);
    }
}
