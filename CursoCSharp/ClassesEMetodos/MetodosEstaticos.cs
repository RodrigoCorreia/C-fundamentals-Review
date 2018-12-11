using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
	public class CalculadoraEstatica
	{
		//Metodo de Classe ou Método estático
		public static int Multiplicar (int a, int b)
		{
			return a * b;
		}

		//Metodo de Intência
		public int Somar(int a, int b)
		{
			return a + b;
		}
	}

	class MetodosEstaticos
	{
		public static void Executar()
		{
			var resultado = CalculadoraEstatica.Multiplicar(2, 2);
			Console.WriteLine("Resultado: {0}", resultado);

			Console.WriteLine(CalculadoraEstatica.Multiplicar(2, 2));

			CalculadoraEstatica Calc = new CalculadoraEstatica();

			Console.WriteLine(Calc.Somar(2,2));
			
			//Dá erro
			// Console.WriteLine(Calc.Multiplicar(2, 2));
		}
	}
}
