using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
	class VariaveisEConstantes
	{
		public static void Executar()
		{
			//Area da circunferencia
			double raio = 4.5;
			const double PI = 3.14;

			raio = 5.5;
			//PI = 3.1415;

			double area = PI * raio * raio;
			Console.WriteLine(area);
			Console.WriteLine("Área é: " + area);
			Console.WriteLine("Área é: " + area + 1000);
			Console.WriteLine("Área é: " + (area + 1000) );

			//Tipos Internos
			bool estaChovendo = true;
			Console.WriteLine("Esta chovendo " +estaChovendo);

			byte idade = 45;
			Console.WriteLine("Idade " + idade);

			sbyte saldoDeGols = sbyte.MinValue;
			Console.WriteLine("Saldo de Gols: " + saldoDeGols);

			short salario = short.MinValue;
			Console.WriteLine("Salario: " + salario);

			int menorValorInt = int.MinValue; //Mais usado dos inteiros!
			Console.WriteLine("O menor valor inteiro: " + menorValorInt);

			uint populacaoBrasileira = 207_600_00;
			Console.WriteLine("Populacao Brasileira " +populacaoBrasileira);

			long menorValorLong = long.MinValue;
			Console.WriteLine("Menor Long: " + menorValorLong);

			ulong populacaoMundial = 7_600_000_000;
			Console.WriteLine("A população Mundial é de: " + populacaoMundial);

			float precoComputador = 1299.99f;
			Console.WriteLine("O preco do Computador é: " + precoComputador);

			double valorDeMercadoDaApple = 1_000_000_000_000.0; //mais udado dos Reais
			Console.WriteLine("Valor de Mercado da apple: " + valorDeMercadoDaApple);

			decimal distanciaEntreEstrelas = decimal.MaxValue;
			Console.WriteLine("A Distancia das estrelas é de: " + distanciaEntreEstrelas);

			char letra = 'b';
			Console.WriteLine("A letra é: " + letra);

			string texto = "Seja bem vindo ao curso c#!";
			Console.WriteLine(texto);
		}
	}
}
