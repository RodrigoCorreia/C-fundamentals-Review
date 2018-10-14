﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaIfElse
    {
		public static void Executar()
		{
			Console.WriteLine("Qual sua nota? ");

			Double nota;

			Double.TryParse(Console.ReadLine(), out nota);

			if (nota >= 7.0)
			{
				Console.WriteLine("Aprovado!");
				Console.WriteLine("Não fez mais do que sua obrigação...");
			}
			else
			{
				Console.WriteLine("Recuperação");
			}
		}
    }
}
