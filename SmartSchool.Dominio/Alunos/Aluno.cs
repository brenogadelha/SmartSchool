using Newtonsoft.Json;
using SmartSchool.Comum.Dominio;
using SmartSchool.Dto.Dtos.Alunos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSchool.Dominio.Alunos
{
    public class Aluno : IEntidade
    {
        public Guid ID { get; set; }
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public bool Ativo { get; set; }

        //[JsonIgnore]
        //public IEnumerable<AlunoDisciplina> AlunosDisciplinas { get; set; }

        public Aluno() { }
        public static Aluno Criar(AlunoDto alunoDto)
        {
            var aluno = new Aluno()
            {

                ID = Guid.NewGuid(),
                Nome = alunoDto.Nome,
                Sobrenome = alunoDto.Sobrenome,
                Telefone = alunoDto.Telefone,
                DataInicio = alunoDto.DataInicio,
                Ativo = alunoDto.Ativo,
                DataNascimento = alunoDto.DataNascimento,
                Matricula = alunoDto.Matricula
            };

            return aluno;
        }
    }
}


