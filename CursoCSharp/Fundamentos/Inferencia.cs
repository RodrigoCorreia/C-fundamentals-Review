using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
	class Inferencia
	{
		public static void Executar()
		{
			var nome = "Rodrigo";
			Console.WriteLine(nome);
			// Não pode fazer isso pois a inferencia já assumiu valor de string
			//nome = 123;

			// Não se pode declarar uma inferencia sem especificar qual tipo ela se trata, 
			//Na linha a baixo vai dar erro por esse motivo.
			//var idade;
			//idade = 32;
			//Console.WriteLine(idade);

			int a;
			a = 3;

			int b = 2;
			Console.WriteLine(a+b);
		}
	}
}
