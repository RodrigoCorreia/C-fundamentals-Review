﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class NotacaoPonto
    {
		public static void Executar()
		{
			var saudacao = "olá".ToUpper().Insert(3, " World!").Replace("World!", "Mundo!");
			Console.WriteLine(saudacao);

			Console.WriteLine("Teste".Length);

			string valorimportante = null;
			//Console.WriteLine(valorimportante.Length); //cuidado com o vazio!!
			Console.WriteLine(valorimportante?.Length); //cuidado com o vazio!!

		}
    }
}
