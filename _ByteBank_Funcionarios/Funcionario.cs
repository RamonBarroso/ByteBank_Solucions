using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _ByteBank_Bonificacao;

namespace _ByteBank_Bonificacao
{
    public class Funcionario
    {

        private int _tipo;
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public double Salario { get; set; }


        public Cargo(int tipo)
        {
            _tipo = tipo;
        }
        public double ObterBonificacao()
        {
            if (_tipo == 1)
            {
                return Salario;


            }
            return Salario * 0.10;
        }

    }
}
