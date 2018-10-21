using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Pessoa
    {
		public string Nome;
		public string Sobrenome;

		public string Apresentar()
		{
			return string.Format($"Olá Me chamo {Nome} e tenho {Sobrenome} como sobrenome.");
		}

		public void ApresentarNoConsole()
		{
			Console.WriteLine(Apresentar());
		}

		public void Zerar()
		{
			Nome = "";
			Sobrenome = "";
		}
    }
}
