using System;

namespace OperacoesBasicas 
{
    public static void main(String[] args) 
    {
        int numero1, numero2;
        
        Console.WriteLine("Informe o primeiro número:");
        numero1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe o segundo número:");
        numero2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(numero1 + " + " + numero2 + " = " + (numero1 + numero2));
        Console.WriteLine(numero1 + " - " + numero2 + " = " + (numero1 - numero2));
        Console.WriteLine(numero1 + " * " + numero2 + " = " + (numero1 * numero2));
        Console.WriteLine(numero1 + " / " + numero2 + " = " + (numero1 / numero2));

           
    }
}