using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gestao_escolar.modelos;


namespace gestao_escolar.modelos
{
    public class Aluno : PESSOA 
{
    public int numero { get; set; }
    public string curso { get; set; }

     private List<double> nts; 

    public Aluno(string nome, string dataNascimento, string telefone, int numero, string curso) 
        : base(nome, dataNascimento, telefone)
    {
        this.numero = numero;
        this.curso = curso;
        this.nts = new List<double>();
    }

    public void adicionarNota(double n) 
    { 
        this.nts.Add(n); 
    }

    public double calcularMedia() 
    {
        if (this.nts.Count == 0) return 0;
        double soma = 0;
        foreach (double n in this.nts)
        {
            soma += n;
        }
        return soma / this.nts.Count;
    }

    public string obterSituacao() 
    {
        
        return (this.calcularMedia() >= 10) ? "Aprovado" : "Reprovado";
    }
}}

