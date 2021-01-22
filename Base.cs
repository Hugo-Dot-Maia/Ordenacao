using System;

namespace Base
{
	public class Base
	{
		private int[] numerosAleatorios = new int[100];

		public setNumeros()
		{
			for (int i = 0; i < numerosAleatorios.Length; i++)
			{
				numerosAleatorios[i] = randNum.Next(0, 1000);
			}
		}

		public getNumeros(int indice)
		{
			return numerosAleatorios[indice];
		}
		public getLenght()
        {
			return numerosAleatorios.Length;
        }

		public swap(int i, int j)
        {
			int temp = numerosAleatorios[i];
			numerosAleatorios[i] = numerosAleatorios[j];
			numerosAleatorios[j] = temp;

        }
		


	}
}

