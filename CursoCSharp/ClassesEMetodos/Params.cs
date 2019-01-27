using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
	class Params
	{
		public static void Recepcionar(params string[] pPessoas)
		{
			foreach(var pessoa in pPessoas)
			{
				Console.WriteLine("Olá {0}",pessoa);
			}
		}

		public static void Executar()
		{
			Recepcionar("Pedro", "Manu", "Roger");
		}
	}
}
