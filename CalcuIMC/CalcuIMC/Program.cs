using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcuIMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Cadastrar(); // Cadastro e cálculo do IMC
            Console.ReadKey();  
        }
    }
}
 
