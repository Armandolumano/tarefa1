using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gestao_escolar.modelos;
namespace gestao_escolar.modelos
{
    public class PESSOA
    { 
    public string nome { get; set; }
    public string dataNascimento { get; set; }
    public string telefone { get; set; }

   
    public PESSOA(string nome, string dataNascimento, string telefone)
    {
        this.nome = nome;
        this.dataNascimento = dataNascimento;
        this.telefone = telefone;
    }

   
    public string getNome() 
    { 
        return this.nome; 
    }
    
    public int getIdade() 
    {
        DateTime dt;
        if (DateTime.TryParse(this.dataNascimento, out dt))
        {
            return DateTime.Now.Year - dt.Year;
        }
        return 0;



    }
    }
}

