

namespace _04_ByteBank
{
    public class ContaCorrente
    {
      

        public Cliente Titular { get; set;}
        public int Agencia { get; set; }
        public int Conta { get; set; }
        public static int TotaldeContasCriadas { get; private set; }

        private double _saldo = 300;

        //isso é uma propiedade.
        public double Saldo 
        {
            get
            {
                return _saldo;
            }

            set
            {
                   if (value < 0)
                {
                    return;
                }
                _saldo = value;
            }
        }


        //toda função é escrita como verbo. Criar, Fazer, Olhar, Traz
        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                return false;
            }

            else
            {
                _saldo -= valor;
                return true;
            }


        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;

            }

            else
            {
                _saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }

        }

        public ContaCorrente(int agencia, int conta)
        {
            Agencia = agencia;
            Conta = conta;
            TotaldeContasCriadas++;
        }

        

        
    }


}
