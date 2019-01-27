using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
	public enum Genero { Acao, Aventura, Terro, Animacao, Comedia};

	public class Filme
	{
		public string Titulo;
		public Genero GeneroDoFilme;
	}

	class ExemploEnum
	{
		public static void Executar()
		{
			int id = (int)Genero.Animacao;
			Console.WriteLine(id);

			var filmeParaFamiia = new Filme();
			filmeParaFamiia.Titulo = "Sharknardo 17";
			filmeParaFamiia.GeneroDoFilme = Genero.Comedia;

			Console.WriteLine("{0} é {1}", filmeParaFamiia.Titulo, filmeParaFamiia.GeneroDoFilme);
		}
	}
}
