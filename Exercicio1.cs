using System;
					
public class Program
{
	public static void Main()
	{
		int nota1, nota2, nota3;
        int media, i;

        for(i=0; i<3; i++)
		{

            Console.WriteLine("Digite a primeira nota:");
            nota1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota:");
            nota2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota:");
            nota3 = Convert.ToInt32(Console.ReadLine());
          
        	media = (nota1 + nota2 + nota3) / 3;
        	Console.WriteLine("A media da nota é:" + media);
		}
	}
}