using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
	public class Moto
	{
		private string Marca;
		private string Modelo;
		private int Cilindrada;

		public Moto(string pMarca, string pModelo, int pCilindrada)
		{
			Marca = pMarca;
			Modelo = pModelo;
			Cilindrada = pCilindrada;
		}

		public Moto()
		{

		}

		public string GetMarca()
		{
			return Marca;
		}
		public void SetMarca(string pMarca)
		{
			Marca = pMarca;
		}

		public string GetModelo()
		{
			return Modelo;
		}
		public void SetModelo(string pModelo)
		{
			Modelo = pModelo;
		}

		public int GetCilindrada()
		{
			return Cilindrada;
		}
		public void SetCilindrada(int pCilindrada)
		{
			//1 Opção
			//if (pCilindrada < 0)
			//	pCilindrada = pCilindrada * -1;

			//2 Opção
			Cilindrada = Math.Abs(pCilindrada);
		}
	}


	class GetSet
	{
		public static void Executar()
		{
			var Moto1 = new Moto("Kawaasaki", "Nija", 636);

			Console.WriteLine(Moto1.GetMarca());
			Console.WriteLine(Moto1.GetModelo());
			Console.WriteLine(Moto1.GetCilindrada());

			var Moto2 = new Moto();

			Moto2.SetMarca("Honda");
			Moto2.SetModelo("Titã");
			Moto2.SetCilindrada(-150);
			Console.WriteLine(Moto2.GetMarca() + " " + Moto2.GetCilindrada());
		}
	}
}
