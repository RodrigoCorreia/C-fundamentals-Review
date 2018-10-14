using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaIf
    {
		public static void Executar()
		{
			bool bomComportamento = false;
			string Entrada;

			Console.WriteLine("Digite a nota do aluno: ");
			Entrada = Console.ReadLine();
			Double.TryParse(Entrada, out double nota);

			Console.WriteLine("Possui bom Comportamento (S/N): ");
			Entrada = Console.ReadLine();

			//Metodologia Trivial.
			//if (Entrada == "S" || Entrada == "s")
			//	bomComportamento = true;

			//Simplificação atribuindo o valor logico True ou False.
			//bomComportamento = Entrada == "S" || Entrada == "s";

			//Simplifinando ainda mais.
			bomComportamento = Entrada.ToLower() == "s";

			//Não faz sentido comprarar um boleano com true or false, é redundante!
			//if (nota >= 9.0 && bomComportamento == true)

			if (nota >= 9.0 && bomComportamento)
			{
				Console.WriteLine("Quadro de Honrra");
			}
		}

    }
}
