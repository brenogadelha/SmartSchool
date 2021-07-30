using SmartSchool.Comum.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSchool.Dominio.Alunos
{
    public class Aluno : IEntidadeAgregavel<int>
    {
        public int ID { get; set; }
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public bool Ativo { get; set; }
        public IEnumerable<AlunoDisciplina> AlunosDisciplinas { get; set; }

        public Aluno() { }
        public Aluno(int id, string nome, string sobrenome, string telefone)
        {
            this.ID = id;
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.Telefone = telefone;
        }
    }
}
