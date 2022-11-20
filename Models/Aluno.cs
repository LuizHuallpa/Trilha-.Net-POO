using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace trilha_dotnet_POO.Models
{
    public class Aluno : Pessoa
    {

        public Aluno(string nome) : base (nome)
        {
            
        }
        public double Nota { get; set; }

        public override void Apresentar()
        {
            System.Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos, e sou um aluno nota {Nota}");
        }
    }
}