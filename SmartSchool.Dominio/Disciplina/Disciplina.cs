using SmartSchool.Dominio.Alunos;
using SmartSchool.Dominio.Professores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSchool.Dominio.Disciplinas
{
    public class Disciplina
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int ProfessorId { get; set; }
        public Professor Professor { get; set; }
        public IEnumerable<AlunoDisciplina> AlunosDisciplinas { get; set; }

        public Disciplina() { }
        public Disciplina(int id, string nome, int professorId)
        {
            this.Id = id;
            this.Nome = nome;
            this.ProfessorId = professorId;
        }
    }
}
