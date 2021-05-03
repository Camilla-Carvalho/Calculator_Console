using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraConsole
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro número: ");
            int num = int.Parse(Console.ReadLine()); 
            Console.Write("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("\n[ 1 ] Soma\n[ 2 ] Multiplicação\n[ 3 ] Divisão\n[ 4 ] Subtração\n");

            Console.Write("Digite uma opção para realizar a operação: ");
            int option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                int result = (num + num2);
                Console.WriteLine(result);
        
            }

            else if (option == 2)
            {
                int result = (num * num2);
                Console.WriteLine(result);

            }

            else if (option == 3)
            {
                Convert.ToDouble(num);
                Convert.ToDouble(num2);

                int result = (num / num2);
                Console.WriteLine(result);
            }

            else if(option == 4)
            {
                int result = (num - num2);
                Console.WriteLine(result);
            }

            else
            {
                Console.WriteLine("ERRO! Digite uma opção válida!");
                Console.WriteLine("\n[ 1 ] Soma\n[ 2 ] Multiplicação\n[ 3 ] Divisão\n[ 4 ] Subtração\n");
            }

            Console.ReadLine();



        }
    }
}
