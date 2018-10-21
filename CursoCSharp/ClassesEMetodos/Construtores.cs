using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
	class Carro
	{
		public string Modelo;
		public string Fabricante;
		public int Ano;

		public Carro(string Modelo, string pFabricante, int pAno)
		{
			this.Modelo = Modelo; //Mesmo nome necessário uso do this pra especificar
			Fabricante = pFabricante;
			Ano = pAno;
		}
	}

    class Construtores
    {
		public static void Executar()
		{
			//Ese tipo de construtor so existe enquanto um contrutor não é definido
			//var carro = new Carro();

			//Outra de instanciar sem precisar da definição de um construtor
			//var carro3 = new Carro()
			//{
			//	Fabricante = "Ford",
			//	Modelo = "Ka",
			//	Ano = 2019
			//};

			var carro2 = new Carro("Uno", "Fiat", 2010);

			Console.WriteLine($"{carro2.Fabricante} fabricou {carro2.Modelo} em {carro2.Ano}");

		}
    }
}
