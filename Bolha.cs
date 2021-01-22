using System;
using Base; 

public class Bolha : Base
{
	Base b = new Base;
	b.setNumeros();
	public Bolha()
	{


		for (int i = (b.getLenght - 1); i > 0; i--)
		{
			for (int j = 0; j < i; j++)
			{
                if (b.getNumeros([j]) > b.getNumeros([j + 1]))
                {
					b.swap(j, j + 1);
                }
			}


		}
	}

}

