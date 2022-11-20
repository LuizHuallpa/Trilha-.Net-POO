using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace trilha_dotnet_POO.Models
{
    public class Professor : Pessoa
    {
        public  Professor(string nome) : base(nome)
        {
            
        }

        public Professor()
        {
            
        }
        public decimal Salario { get; set; }

        public sealed override void Apresentar()
        {
            System.Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos, sou um professor e meu salário é {Salario}");
        }
    }
}