using System;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            ContaCorrente conta = new ContaCorrente(1502, 14756);
            ContaCorrente contadoRamon = new ContaCorrente(15, 126);
            ContaCorrente ContadaYasmin = new ContaCorrente(12, 15);

            

            Console.WriteLine(ContaCorrente.TotaldeContasCriadas);


        }
    }
}
