using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    public class OperadoresUnarios
    {
		public static void Executar()
		{
			var valorNegativo = -5;

			var numero1 = 2;
			var numero2 = 3;
			var booleano = true;

			Console.WriteLine(-valorNegativo);
			Console.WriteLine(!booleano);

			numero1++;
			Console.WriteLine(numero1);

			--numero1;
			Console.WriteLine(numero1);

			//Quando é prefixado a operação é imediata antes da comparação
			//Quando é sufixado a operação não tem tanta prioridade e realizada depois da igualdade.
			Console.WriteLine(numero1++ == --numero2);
			Console.WriteLine($"{numero1} {numero2}");
		}
    }
}
