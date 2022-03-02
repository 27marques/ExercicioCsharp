using System;
					
public class Program
{
	public static void Main()
	{
		int distancia, tempo;

        Console.WriteLine("Informe a distância:");
        distancia = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Informe o tempo:");
        tempo = Convert.ToInt32(Console.ReadLine());        

        float velocidademedia = (distancia / tempo);
        
    	Console.WriteLine("Velocidade média = " + velocidademedia + " Km/h\n");
	}
	
}