using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
	interface Ponto
	{
		void MoverNaDiagonal(int Delta);
	}

	struct Coordenada : Ponto
	{
		public int X;
		public int Y;

		public Coordenada(int x, int y)
		{
			X = x;
			Y = y;
		}

		public void MoverNaDiagonal (int delta)
		{
			X += delta;
			Y += delta;
		}
	}


	class ExemploStruct
	{
		public static void Executar()
		{
			Coordenada CoordenadaInicial;
			CoordenadaInicial.X = 2;
			CoordenadaInicial.Y = 2;

			Console.WriteLine("Coordenada Incial: ");
			Console.WriteLine("X = {0}", CoordenadaInicial.X);
			Console.WriteLine("Y = {0}", CoordenadaInicial.Y);

			var coordenadaFinal = new Coordenada(x: 9, y: 1);
			coordenadaFinal.MoverNaDiagonal(10);

			Console.WriteLine("Coordenada Final: ");
			Console.WriteLine("X = {0}", coordenadaFinal.X);
			Console.WriteLine("Y = {0}", coordenadaFinal.Y);

		}
	}
}
