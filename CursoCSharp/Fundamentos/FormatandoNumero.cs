using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class FormatandoNumero
    {
		public static void Executar()
		{
			double valor = 15.175;
			Console.WriteLine(valor.ToString("F1")); //Aredondamento
			Console.WriteLine(valor.ToString("C")); //Moeda local Configurada no SO
			Console.WriteLine(valor.ToString("P")); //Percentual
			Console.WriteLine(valor.ToString("#.##")); //Formato numero com 2 casas decimais

			CultureInfo cultura = new CultureInfo("pt-BR");
			Console.WriteLine(valor.ToString("C0", cultura));

			CultureInfo cultura2 = new CultureInfo("en-US");
			Console.WriteLine(valor.ToString("C0", cultura2));

			CultureInfo cultura3 = new CultureInfo("en-US");
			Console.WriteLine(valor.ToString("C3", cultura3)); //Currenci 3, umero com 3 casas decimais

			int inteiro = 256;
			Console.WriteLine(inteiro.ToString("D10")); //Numero com 10 digitos
		}
    }
}
