using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
	public struct SPonto
	{
		public int X;
		public int Y;
	}

	public class CPonto
	{
		public int X;
		public int Y;
	}


	class StructVsClasse
	{
		public static void Executar()
		{
			SPonto ponto1 = new SPonto { X = 1, Y = 3 };
			SPonto CopiaPonto1 = ponto1; //Atribuição por VALOR!
			ponto1.X = 3;

			Console.WriteLine("Ponto 1 X:{0}",ponto1.X);//Print 3
			Console.WriteLine("Copia Ponto 1 X:{0}",CopiaPonto1.X);//Print 1

			///////////

			CPonto ponto2 = new CPonto { X = 2, Y = 4 };
			CPonto CopiaPonto2 = ponto2; //Atribuição por REFERENCIA!
			ponto2.X = 4;

			Console.WriteLine("Ponto 1 X:{0}", ponto2.X);//Print 4
			Console.WriteLine("Copia Ponto 1 X:{0}", CopiaPonto2.X);//Print 4
		}
	}
}
