using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace introducao_NET.Common.Models
{  // models puramente para organizaçao, poderia ter outra pasta dentro, tipo models.contas.
   // namespace representa um caminho único, posso ter varias classes com mesmo nome, caso o namespace seja diferente
   // convenções case:
   // camelCase para variáveis e PascalCase para metódos, propriedades e classes.
    public class Pessoa
    {
        public string Nome { get; set; } = string.Empty;     
        public int Idade { get; set; }   
        public string NomeRepresentanteLegalDaPessoaFisica { get; set; } = string.Empty;

        public void Apresentar()
        {
          //  Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos");
          Console.WriteLine($"Olá, meu nome é {Nome} \ne tenho {Idade} anos");
        }
    }
}