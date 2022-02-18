using System;

namespace ConsoleApp3000
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vezesfalado;
            char olhando = 'N' ;
            string direcao;
            do
            {
                Console.WriteLine("numero de comandos emitidos");
                vezesfalado = int.Parse(Console.ReadLine());
                if (vezesfalado == 0)
                {
                    break;
                }
            volta:
                Console.WriteLine("Direçoes E ou D(maiusculo de preferencia)");

                direcao = Console.ReadLine();

                char[] instrucao = direcao.ToUpper().ToCharArray(); ;

                for (int i = 0; i < instrucao.Length; i++)
                {
                    if (instrucao[i] != 'E' && instrucao[i] != 'D')
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Deu algum erro, digite novamente");
                        Console.ResetColor();
                        goto volta;
                    }
                    else
                    {
                        if (instrucao[i] == 'E')
                        {
                            switch (olhando)
                            {
                                case 'N':
                                    olhando = 'O';
                                    break;

                                case 'O':
                                    olhando = 'S';
                                    break;

                                case 'S':
                                    olhando = 'L';
                                    break;

                                case 'L':
                                    olhando = 'N';
                                    break;
                            }
                        }
                        else if (instrucao[i] == 'D')
                        {
                            switch (olhando)
                            {
                                case 'N':
                                    olhando = 'L';
                                    break;

                                case 'L':
                                    olhando = 'S';
                                    break;

                                case 'S':
                                    olhando = 'O';
                                    break;

                                case 'O':
                                    olhando = 'N';
                                    break;
                            }

                        }
                    }






                }
                Console.WriteLine($"A direção que estará apontada será {olhando}");
                Console.ReadKey();
            } while (true);





        }
    }
}
