using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoEstoqueMedio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Entrada das quantidades mínima e máxima
            Console.Write("Digite a quantidade mínima: ");
            double quantidadeMinima = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a quantidade máxima: ");
            double quantidadeMaxima = Convert.ToDouble(Console.ReadLine());

            // Cálculo do estoque médio
            double estoqueMedio = (quantidadeMinima + quantidadeMaxima) / 2;

            // Exibição do resultado 
            Console.WriteLine("O estoque médio é: " + estoqueMedio);
        }
    }
}
