using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region switch - case
            int escolha = 2;
             
            switch (escolha)
            {
                default:
                    Console.WriteLine("Opção Default");
                    break;
                case 1:
                    Console.WriteLine("Opção 1:");
                    break;
                case 2:
                    Console.WriteLine("Opção 2:");
                    break;
                case 3:
                    Console.WriteLine("Opção 3:");
                    break;
            }
        #endregion

            #region Declaração Goto
        Inicio:
            Console.WriteLine("Escolha uma Opção");
            int op = int.Parse(Console.ReadLine());
            int valor = 0;

            switch (op) 
            {
                default:
                    goto Inicio;
                    break;
                case 1:
                    valor += 100;
                    break;
                case 2:
                    valor += 50;
                    goto case 1;
            }

            Console.WriteLine("Valor final " + valor);
            #endregion


            Console.ReadKey();  

        }
    }
}
