using System;

public class Base
{
	private int[] numerosAleatorios = new int[5];

	public setNumeros()
    {
		for (int i = 0; i < numerosAleatorios.Length; i++)
		{
			numerosAleatorios[i] = randNum.Next(Min, Max);
		}
	}

	public getNumeros()
    {
		return numerosAleatorios;
    }


	
}
