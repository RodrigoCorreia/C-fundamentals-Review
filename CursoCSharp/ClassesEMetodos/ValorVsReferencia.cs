using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
	public class Dependente
	{
		public string nome;
		public int idade;
	}

	class ValorVsReferencia
	{
		public static void Executar()
		{
			int numero = 3;
			int copiaNumero = numero;
			Console.WriteLine($"{numero} {copiaNumero}");

			numero++;
			Console.WriteLine($"{numero} {copiaNumero}");

			Dependente dep = new Dependente
			{
				nome = "Beto",
				idade = 20
			};

			Dependente copiaDep = dep;

			Console.WriteLine($"{dep.nome} {dep.idade}");
			Console.WriteLine($"{copiaDep.nome} {copiaDep.idade}");

			copiaDep.nome = "Renato";
			copiaDep.idade = 21;

			Console.WriteLine($"{dep.nome} {dep.idade}");
			Console.WriteLine($"{copiaDep.nome} {copiaDep.idade}");
		}

	}
}

