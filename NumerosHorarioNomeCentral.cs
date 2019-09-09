using System;
//Autor: Welvis da Silva Moreira
namespace MatrizNome
{
    class NumerosHorarioNomeCentral
    {
        static void Main(string[] args)
        {
         string nome;
         Console.WriteLine("Digite um Nome: ");
         nome = Console.ReadLine();
         int contador = 2*(nome.Length) + 6;
         int contadorChar = 0;
         string[] matriz = new string[30];

            for(int i=0; i <= contador; i++)
            {
                // Coloca a numeração inicial na matriz.
                if (i <= nome.Length + 1)                        
                {                                              
                    matriz[i] = Convert.ToString(i + 1);
                    Console.Write("  " + matriz[i]);

                    // Salva o valor final no inicio do Nome.
                    if (i == (nome.Length+1))                   
                    {
                        Console.WriteLine();
                        matriz[i] = Convert.ToString(contador);
                        Console.Write(" " + matriz[i]);
                    }
                }
                else
                {   // Salva o nome na matriz.
                    while (contadorChar < nome.Length)              
                    {
                        matriz[i] = nome[contadorChar].ToString();
                        Console.Write("  " + matriz[i]);
                        contadorChar++;
                    }
                    // Salva o valor no final do Nome.
                    if (i == nome.Length+2)                      
                    {
                        matriz[i] = Convert.ToString(i+1);        
                        Console.Write("  " + matriz[i]);
                        Console.WriteLine();
                        contador--;
                    }
                    else
                    {   // Inverte a sequencia da matriz.
                        while (i != contador)                           
                        {
                            matriz[i] = Convert.ToString(contador--);
                            Console.Write(" " + matriz[i]);
                        }
                    }
                }
            }
     Console.ReadKey();
        }
    }
}

