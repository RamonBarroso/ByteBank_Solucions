using System;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contadoramon = new ContaCorrente();
            contadoramon.titular = "Ramon";
            contadoramon.agencia = 1502;
            contadoramon.conta = 3600;
            contadoramon.saldo = 90000;
            contadoramon.saldo += 200;
            Console.WriteLine(contadoramon.saldo);

            
            
            


        }
    }
}
