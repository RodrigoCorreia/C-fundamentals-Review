using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
	class CalculadoraComum
	{
		public int Somar(int a, int b)
		{
			return a + b;
		}

		public int Somar(int a, int b, int c)
		{
			return Somar(a,b) + c;
		}

		public int Subtrair (int a,int b)
		{
			return a - b;
		}

		public int Multiplicar (int a, int b)
		{
			return a * b;
		}
	}

	class MetodosComRetorno
	{
		public static void Executar()
		{
			var Calculadora = new CalculadoraComum();

			var resultado = Calculadora.Somar(5, 5);
			Console.WriteLine(resultado);

			Console.WriteLine(Calculadora.Subtrair(2,7));

			Console.WriteLine(Calculadora.Multiplicar(4,4));
		}
	}
}
