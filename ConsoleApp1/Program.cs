using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Quantos numeros irá colocar?");
            string[] strNumeros = Console.ReadLine().Split(' ');
            
            for (int i = 0; i < strNumeros.Length; i++)
            {
            //    strNumeros[i] = Convert.ToInt32(strNumeros[i]);
            }

            int[] numeros = new int[10];
            
            bool certo;
            for (int s = 0; s < numeros.Length; s++)
            {
                Console.WriteLine("Digite os numeros " );

            volta1:
                
                certo = int.TryParse(Console.ReadLine(), out numeros[s]);
                Console.Clear();
                if  (certo == false)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opção inválida, digite novamente");
                    Console.ResetColor();
                    goto volta1;
                }



            }
            Array.Sort(numeros);
            int cont;
            int num;
            for(int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }
            for (int i = 0; i < numeros.Length; i++)
            {
                cont = 0;
                for (int j = 0; j < numeros.Length; j++)
                {
                    if (numeros[i] == numeros[j])
                        cont++;
                    num = numeros[i];


                    Console.WriteLine($" repeticoes numero {num}: {cont} vezes");
                }
            }
            Console.ReadKey();


        }
    }
}
