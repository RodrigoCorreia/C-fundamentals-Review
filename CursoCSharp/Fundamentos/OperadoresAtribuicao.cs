using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
	class OperadoresAtribuicao
	{
		public static void Executar()
		{
			var num1 = 3;
			num1 = 7;

			num1 += 10; // num1 = num1 + 10;
			num1 -= 10; // num1 = num1 - 10;
			num1 *= 10; // num1 = num1 * 10;
			num1 /= 10; // num1 = num1 / 10;

			Console.WriteLine(num1);

			int a = 1; //Atribuição de literal
			int b = a; //Atribuição Outra variave

			a++; // a = a + 1;
			b--; //b = b - 1;

			Console.WriteLine($" {a} {b}");

			//Não se preoculpe com o código
			dynamic c = new System.Dynamic.ExpandoObject();
			c.nome = "João";
			dynamic d = c;
			d.nome = "Maria";

			Console.WriteLine(c.nome);


		}
	}
}
