using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _ByteBank_Bonificacao;

namespace _ByteBank_Bonificacao
{
    public class GerenciadordeBonificacao
    {
        private double _totalBonificacao;
       public void Registrar(Funcionario funcionario)
        {
           _totalBonificacao += funcionario.ObterBonificacao();
        }

        public double GetTotalBonificacao()
        {
            return _totalBonificacao;
        }
    }
}
