using System;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente ContaRamon = new ContaCorrente();

            Console.WriteLine(ContaRamon.titular);

            ContaRamon.conta = 1234;
            int tt = 1235;
            ContaRamon.conta = tt;
            Console.WriteLine(ContaRamon.conta);
        }
    }
}
