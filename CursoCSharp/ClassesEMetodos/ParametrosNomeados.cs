using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
	class ParametrosNomeados
	{
		public static void Formatar(int pDia, int pMes, int pAno)
		{
			Console.WriteLine("{0:D2}/{1:D2}/{2}",pDia,pMes,pAno);
		}

		public static void Executar()
		{
			Formatar(pMes: 1, pDia: 6, pAno: 1996);
		}
	}
}
