using System;

namespace Ex1{
    class Program{
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-Vindo ao Sportore Bank");

            ContaCorrente conta1 = new ContaCorrente();
            conta1.titular = "Cesar";
            conta1.agencia = 132;
            conta1.numeroConta = 999;
            conta1.Depositar(10000);

            ContaCorrente conta2 = new ContaCorrente();

            conta2.titular = "Tsukamoto";
            conta2.agencia = 132;
            conta2.numeroConta = 1;
            conta2.Depositar(5000);


            System.Console.WriteLine($"----Primeira conta----");
            System.Console.WriteLine($"Titular: {conta1.titular}");
            System.Console.WriteLine($"Agência: {conta1.agencia}");
            System.Console.WriteLine($"Numero da conta: {conta1.numeroConta}");
            System.Console.WriteLine($"Saldo: {conta1.ExibirSaldo()}");
            System.Console.WriteLine($"-----------------------");

            System.Console.WriteLine($"----Segunda conta----");
            System.Console.WriteLine($"Titular: {conta2.titular}");
            System.Console.WriteLine($"Agência: {conta2.agencia}");
            System.Console.WriteLine($"Numero da conta: {conta2.numeroConta}");
            System.Console.WriteLine($"Saldo: {conta2.ExibirSaldo()}");
            System.Console.WriteLine($"-----------------------");

            //bool valorRetornado = conta1.sacar(3500);
            //if(valorRetornado){
            //   System.Console.WriteLine($"Parabéns, você conseguiu!");
            //}else{
            //    System.Console.WriteLine($"Você não tem dinheiro na sua conta!");
            //}
            //System.Console.WriteLine(valorRetornado);
            //System.Console.WriteLine($"Saldo depois do saque: {conta1.ExibirSaldo()}");

            conta2.Transferir(1000, conta1);

            System.Console.WriteLine($"Saldo conta 1: {conta1.ExibirSaldo()}");
            System.Console.WriteLine($"Saldo conta 2: {conta2.ExibirSaldo()}");
        }
    }
}