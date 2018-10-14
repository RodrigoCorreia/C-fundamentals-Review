using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresTernarios
    {
		public static void Executar()
		{
			var nota = 7.0;
			bool bomCOmportamento = true;
			string resultado = nota >= 7.0 && 
								bomCOmportamento ? "Aprovado" : "Reprovado";

			Console.WriteLine(resultado);

		}
    }
}
