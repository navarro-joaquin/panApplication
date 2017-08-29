using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace panApplication
{
	class aleatorio
	{
		Random rnd;
		string[] nombres = System.IO.File.ReadAllLines(@"nombres.txt");

		public aleatorio()
		{
			rnd = new Random(Guid.NewGuid().GetHashCode());
		}

		public int generarAleatorio()
		{
			int numero = rnd.Next(1, nombres.Length + 1);
			return numero;
		}

		public string elegirNombre(int numero)
		{
			string nombre;

			nombre = nombres[numero - 1];

			return nombre;
		}
	}
}
