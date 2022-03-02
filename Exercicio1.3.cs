using System;
					
public class Program
{
	public static void Main()
	{
		int valor1, valor2;
        
        Console.WriteLine("Digite o 1º valor: ");
        valor1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o 2º valor: ");
        valor2 = Convert.ToInt32(Console.ReadLine());
		
        String message = valor1 >= (valor2 * 2)
            ? "É maior ao dobro do 1º valor"
            : "Não é maior ao dobro do 1º valor";
        Console.WriteLine(message);
	}
	
}