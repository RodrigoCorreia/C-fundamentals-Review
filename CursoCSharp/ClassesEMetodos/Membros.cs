using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Membros
    {
		public static void Executar()
		{
			Pessoa Sicrano = new Pessoa();
			Sicrano.Nome = "Rodrigo";
			Sicrano.Sobrenome = "Correia";

			Console.WriteLine($"{Sicrano.Nome} tem sobrenome {Sicrano.Sobrenome}.");

			Sicrano.ApresentarNoConsole();
			Sicrano.Zerar();
			Sicrano.ApresentarNoConsole();

			var fulano = new Pessoa();
			fulano.Nome = "Beto";
			fulano.Sobrenome = "Souza";

			var apresentacaoDoFulado = fulano.Apresentar();

			Console.WriteLine(apresentacaoDoFulado.Length);
			Console.WriteLine(apresentacaoDoFulado);
		}
    }
}
