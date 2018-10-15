using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaDoWhile
    {
		public static void Executar()
		{
			string entrada;

			do
			{
				Console.WriteLine("Qual seu nome?");
				entrada = Console.ReadLine();

				Console.WriteLine("Seja bem-vindo {0}", entrada);
				Console.WriteLine("Deseja continuar? (S/N)");

			} while (Console.ReadLine().ToLower() == "s");

		}
    }
}
