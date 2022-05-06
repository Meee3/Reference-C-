using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeuOCP;
namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ModeloPessoa> candidatos = new List<ModeloPessoa>
            {
            new ModeloPessoa { Nome = "T", Sobrenome = "L" },

            };

            List<ModeloEmpregado> empregados = new List<ModeloEmpregado>();
            Contas fluxoContas = new Contas();

            foreach (var pessoa in candidatos)
            {
                empregados.Add(fluxoContas.Create(pessoa));
            }

            foreach (var empregado in empregados)
            {
                Console.WriteLine($"{empregado.Nome}{empregado.Sobrenome}: {empregado.Email}");
            }

            Console.ReadLine();

        }
    }
}
}

