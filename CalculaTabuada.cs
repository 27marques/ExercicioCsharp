using System;

namespace CalculaTabuada 
{
    public static void main() 
    {
        try
        {
            BufferedWriter escrita = new BufferedWriter(new FileWriter("./tabuada.txt"));
            int i, numero;
            
            Console.WriteLine("Informe um número: ");
            numero = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine("\nTabuada do número " + numero + ":\n");
            for(i=0;i<=10;i++)
            {
                
                Console.WriteLine(numero + " * " + i + " = " + numero * i);
                //append aqui
                escrita.append(numero + " * " + i + " = " + numero * i+ "\n");
                
            }
            escrita.close();
        } catch (IOException exception)
        {
            Console.WriteLine("Erro de exceção I/O: " + exception.getMessage());
        }

        
    }
}