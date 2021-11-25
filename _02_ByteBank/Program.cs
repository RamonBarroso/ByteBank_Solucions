using System;

namespace _02_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            conta.saldo = 1548;

            Console.WriteLine(conta.saldo);
        }
    }
}
