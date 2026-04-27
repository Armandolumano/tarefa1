using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace gestao_escolar.modelos
{
public class Professor : PESSOA
{
    public string especialidade { get; set; }
    public string departamento { get; set; }
    public double salario { get; set; }

    public Professor(string nome, string dataNascimento, string telefone, string esp, string dep, double sal)
        : base(nome, dataNascimento, telefone)
    {
        this.especialidade = esp;
        this.departamento = dep;
        this.salario = sal;
    }

    public void leccionar() 
    { 
       
    }
    
    public double avaliarAluno(Aluno a) 
    {
        return a.calcularMedia();
    }

    public double getSalario() 
    { 
        return this.salario; 
    }
}
}
 

