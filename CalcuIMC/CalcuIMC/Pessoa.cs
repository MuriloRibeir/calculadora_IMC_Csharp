using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CalcuIMC
{
    internal class Pessoa
    {
        public string name;
        public int age;
        public string city;
        public float height;
        public float weight;
        public float imc;

        public void Cadastrar()
        {
            Console.WriteLine("Digite seu nome: ");
            name = Console.ReadLine();

            Console.WriteLine("Digite sua idade: ");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua cidade: ");
            city = Console.ReadLine();

            Console.WriteLine("Digite seu peso (em kg): ");
            weight = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua altura (em metros): ");
            height = float.Parse(Console.ReadLine());

            imc = weight / (height * height);

            DefinirIMC();

            MostrarDados();
        }

        private void DefinirIMC()
        {
            if (imc < 16)
            {
                Console.WriteLine("Magreza grave");
            }
            else if (imc >= 16 && imc <= 16.9)
            {
                Console.WriteLine("Magreza moderada");
            }
            else if (imc >= 17 && imc <= 18.5)
            {
                Console.WriteLine("Magreza leve");
            }
            else if (imc >= 18.6 && imc <= 24.9)
            {
                Console.WriteLine("Peso ideal");
            }
            else if (imc >= 25 && imc <= 29.9)
            {
                Console.WriteLine("Sobrepeso");
            }
            else if (imc >= 30 && imc <= 34.9)
            {
                Console.WriteLine("Obesidade Grau I");
            }
            else if (imc >= 35 && imc <= 39.9)
            {
                Console.WriteLine("Obesidade Grau II");
            }
            else
            {
                Console.WriteLine("Obesidade Grau III");
            }
        }

        public void MostrarDados()
        {
            Console.WriteLine("\n--- Dados da Pessoa ---");
            Console.WriteLine("Nome: {0}", name);
            Console.WriteLine("Idade: {0}", age);
            Console.WriteLine("Cidade: {0}", city);
            Console.WriteLine("Altura: {0} metros", height);
            Console.WriteLine("Peso: {0} kg", weight);
            Console.WriteLine("IMC: {0}", imc);

            Console.ReadKey(); 
        }
    }

}

  