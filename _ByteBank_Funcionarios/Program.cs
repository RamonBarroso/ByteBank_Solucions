using _ByteBank_Bonificacao;
using System;
using System.Threading.Tasks;
namespace _ByteBank_Funcionario
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadordeBonificacao gerenciadordeBonificacao = new GerenciadordeBonificacao();
            Cargo Carlos = new Cargo();
            Carlos.Nome = "Ramon";
            Console.WriteLine(Carlos.Nome);


        }
    }
}
