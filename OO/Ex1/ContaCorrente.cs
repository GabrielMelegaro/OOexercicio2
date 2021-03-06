namespace Ex1{
    public class ContaCorrente{
        public string titular;

        public int agencia;

        public int numeroConta;

        public double saldo {get; private set;}

        public void Depositar(double valor){
            saldo += valor;
        }
        public bool sacar(double valor){
            if(valor > saldo){
                return false;
            }else{
               saldo -= valor;
               return true;
            }              
        }//fim sacar
        public double ExibirSaldo(){
            return saldo;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino){
            if(valor > saldo){
                return false;
            }else{
                saldo -= valor;
                contaDestino.saldo += valor;
                return true;
            }
        }
    }
}