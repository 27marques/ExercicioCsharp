using System;
					
public class Program
{
	public static void Main()
	{
		int numero, i;

        Console.WriteLine("Informe um numero entre 1 e 10:");
        numero = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("O numero informado foi:" + numero);

        for(i=0;i<=10;i++)
 		{
        	Console.WriteLine("\n" + numero *i);
        }
	}
	
}