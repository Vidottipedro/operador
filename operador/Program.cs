using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operador
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o primeiro numero:");
                 double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero:");
                 double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("escolha um dos: +, -, *, /");
                 var operador = Console.ReadLine();

            if (operador == "+") Console.WriteLine("O resultado do calculo é:" + (n1 + n2));
            else if (operador == "-") Console.WriteLine("O resultado do calculo é:" + (n1 - n2));
            else if (operador == "*") Console.WriteLine("O resultado do calculo é:" + (n1 * n2));
            else if (operador == "/") Console.WriteLine("O resultado do calculo é" + (n1 / n2));
            else Console.WriteLine(" ERRO DIGITE UM OPEREDOR VALIDO");
            Console.ReadKey();
            
            {

            }
        }
    }
}
