using System;
					
public class Program
{
	public static void Main()
	{
		int lado1, lado2;
        int area;

        Console.WriteLine("informe o primeiro lado:");
        lado1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Informe o segundo lado:");
        lado2 = Convert.ToInt32(Console.ReadLine());

        area = (lado1 * lado2 );
		
		Console.WriteLine("O cálculo da área é:" + area);
	}
	
}