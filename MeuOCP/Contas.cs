using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuOCP
{
    public class Contas
    {
        public ModeloEmpregado Create(ModeloPessoa pessoa)
        {
            ModeloEmpregado empregadoSaida = new ModeloEmpregado();
            empregadoSaida.Nome = pessoa.Nome;
            empregadoSaida.Sobrenome = pessoa.Sobrenome;
            empregadoSaida.Email = $"{pessoa.Nome.Substring(0,1)}{pessoa.Sobrenome}@castgroup.com.br";
            


        }
    }
}
