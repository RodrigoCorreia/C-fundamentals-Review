using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
	class EstruturaSwitch
	{
		public static void Executar()
		{
			Console.WriteLine("Avalie o Atendimento de 0 a 5: ");

			int.TryParse(Console.ReadLine(), out int nota);

			switch (nota)
			{
				case 0:
					Console.WriteLine("Péssimo");
					break;
				case 1:
				case 2:
					Console.WriteLine("Ruim");
					break;
				case 3:
					Console.WriteLine("Regular");
					break;
				case 4:
					{
						Console.WriteLine("Bom");
						Console.WriteLine("Estude mais que voce chega lá!!!");
						break;
					}
				case 5:
					Console.WriteLine("Ótimo");
					Console.WriteLine("Parabéns");
					break;
				default:
					Console.WriteLine("Nota inválida");
					break;
			}
			Console.WriteLine("Fim!");

		}
	}
}
