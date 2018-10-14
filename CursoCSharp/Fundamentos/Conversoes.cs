using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
	class Conversoes
	{
		public static void Executar()
		{
			int inteiro = 10;
			double quebrado = inteiro; //inteiro em double
			Console.WriteLine(quebrado);

			double nota = 9.7;
			int notaTruncada = (int)nota; //Tira a parte decimal e fica com a parte inteiras
			Console.WriteLine(notaTruncada);

			Console.WriteLine("Digite sua idade: ");
			string idadeString = Console.ReadLine();
			int idadeInteiro = int.Parse(idadeString);
			Console.WriteLine(idadeInteiro);

			idadeInteiro = Convert.ToInt32(idadeString);
			Console.WriteLine(idadeInteiro);

			Console.WriteLine("Digite o numero: ");
			string palavra = Console.ReadLine();
			int numero;
			int.TryParse(palavra, out numero);
			Console.WriteLine("Resultado1: " + numero);

			Console.WriteLine("Digite outro numero: ");
			int.TryParse(Console.ReadLine(), out int numero2);
			Console.WriteLine("Resultado2: " + numero2);

		}
	}
}
