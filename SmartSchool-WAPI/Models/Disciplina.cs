using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSchool_WAPI
{
    public class Disciplina
    {
        public Disciplina() { }

        public Disciplina(int id, string nome, int ProfessorId)
        {
            this.id = id;
            this.nome = nome;
            this.ProfessorId = ProfessorId;
        }
        public int id { get; set; }
        public string nome { get; set; }
        public int ProfessorId { get; set; }
        public Professor Professor { get; set; }
    }
}