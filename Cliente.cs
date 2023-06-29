namespace Teste
{
    class Cliente
    {
        private int _NumeroDaConta;
        private string _Titular;
        private int _Deposito = 0;

        public int NumeroDaConta { get => _NumeroDaConta; set => _NumeroDaConta = value; }
        public string Titular { get => _Titular; set => _Titular = value; }
        public int Deposito { get => _Deposito; set => _Deposito = value; }

        public void Depositar(int deposito)
        {
            _Deposito += deposito;
        }

        public void Sacar(int saque)
        {
            _Deposito -= (saque + 5);
        }

        public override string ToString()
        {
            return "Conta " + NumeroDaConta + ", Titular " + Titular + ", Saldo " + Deposito;
        }
    }
}
