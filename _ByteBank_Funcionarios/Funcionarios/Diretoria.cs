using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _ByteBank_Funcionario.Funcionarios
{
   public class Diretoria
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public double Salario { get; set; }

        public double GetBonificacao()
        {
            return Salario;
        }


    }
}
