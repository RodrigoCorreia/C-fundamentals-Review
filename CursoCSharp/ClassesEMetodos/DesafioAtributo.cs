using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
	class DesafioAtributo
	{
		int a = 10;

		public static void Executar()
		{
			//Acesse a variavel 'A' dentro do Método Executar;
			// Console.WriteLine(a);

			//Resposta
			DesafioAtributo desafio = new DesafioAtributo();
			Console.WriteLine(desafio.a);
		}
	}
}
