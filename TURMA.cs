using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gestao_escolar.modelos;


namespace gestao_escolar.modelos
{
    public class Turma
    {
      
        public string codigo { get; set; }
        public int ano { get; set; }
        public int capacidade { get; set; }
        public Professor professorResponsavel { get; set; } 
        public List<Aluno> listaAlunos { get; set; } 

   
        public Turma(string codigo, int ano, int capacidade, Professor prof)
        {
            this.codigo = codigo;
            this.ano = ano;
            this.capacidade = capacidade;
            this.professorResponsavel = prof;
            this.listaAlunos = new List<Aluno>();
        }

      
        public void adicionarAluno(Aluno aluno)
        {
            if (listaAlunos.Count < capacidade)
            {
                listaAlunos.Add(aluno);
            }
        }

 
        public string listarAlunos()
        {
            if (listaAlunos.Count == 0) return "Nenhum aluno inscrito";

            List<string> nomes = new List<string>();
            foreach (var a in listaAlunos)
            {
                nomes.Add(a.nome);
            }
            return string.Join(", ", nomes);
        }
    }
}

