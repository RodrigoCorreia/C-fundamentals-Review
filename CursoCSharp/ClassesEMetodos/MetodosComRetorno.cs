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
			return Somar(a, b) + c;
		}

		public int Subtrair(int a, int b)
		{
			return a - b;
		}

		public int Multiplicar(int a, int b)
		{
			return a * b;
		}
	}

	class CalculadoraCadeia
	{
		int memoria;

		public CalculadoraCadeia Somar(int a)
		{
			memoria += a;
			return this;
		}

		public CalculadoraCadeia Multiplicar (int a)
		{
			memoria *= a;
			return this;
		}

		public CalculadoraCadeia Limpar()
		{
			memoria = 0;
			return this;
		}

		public CalculadoraCadeia Imprimir()
		{
			Console.WriteLine(memoria);
			return this;
		}

		public int Resultado()
		{
			return memoria;
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

			//////////////////////////////////////////////////
			
			var CalculadoraCadeia = new CalculadoraCadeia();

			//É possivel encadear pois o retorno dos metodos é o proprio objeto.
			CalculadoraCadeia.Somar(3).Multiplicar(3).Imprimir().Limpar().Imprimir();

			resultado = CalculadoraCadeia.Somar(3).Multiplicar(2).Resultado();
			Console.WriteLine(resultado);
		}
	}
}
