using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
//     public class Pessoa
//     {
//       public string?  Nome { get; set; }
//        public int  Idade { get; set; }  

//        public string? NomePessoaLegal { get; set; }

//        public void  Apresentar() 
//        {
//         Console.WriteLine($"Olá, meu nome é {Nome}, tenho " +
//         $"{Idade} anos e sou filho do(a) {NomePessoaLegal}");
//        }
//     }
// }

public class Carro 
{

  public int ValorDoCarro { get; set; }

  public string? ModeloDoCarro { get; set; }

public void Propaganda(){
Console.WriteLine($"Vende-se um {ModeloDoCarro}, pela bagatela de apenas {ValorDoCarro}. ");

}

} 
}