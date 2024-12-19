using System;

namespace tabelaCombustivel
{
    class Combustiveis
    {
        static void Main(string[] args)
        {
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            Console.WriteLine("Digite os combustiveis desejado e digite 4 para ver o resultado:");
            Console.WriteLine("(1.Alcool  2.gasolina    3.diesel    4.Fim)");

            int tipo = int.Parse(Console.ReadLine());

            while (tipo != 4)
            {
                
                if (tipo == 1)
                {
                    alcool = alcool + 1;
                }
                else if (tipo == 2)
                {
                    gasolina = gasolina + 1;
                }
                else if (tipo == 3)
                {
                    diesel = diesel + 1;
                }
                else
                {
                    Console.WriteLine("item não consta na tabela");
                }

                tipo = int.Parse(Console.ReadLine()); 
            }

            Console.WriteLine("Tabela de Consumo");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("gasolina: " + gasolina);
            Console.WriteLine("diesel: " + diesel);
        }
    }
}