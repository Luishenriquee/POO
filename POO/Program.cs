using System;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aprendendo POO");
             
            Conta conta1 = new Conta();
            Conta conta2 = new Conta();

            conta1.Saldo = 1500;
            conta1.Limite = 500;
            conta1.Numero = 123;

            Console.WriteLine("Olá, Luis, seu saldo em conta é: " + conta1.Saldo);
            Console.WriteLine("Limite de saque: " + conta1.Limite);
            Console.WriteLine("O número da conta é: " + conta1.Numero);

            Console.WriteLine("____________________________________________");

            conta2.Saldo = 2100;
            conta2.Limite = 700;
            conta2.Numero = 456;

            Console.WriteLine("Olá, Lorena, seu saldo em conta é: " + conta2.Saldo);
            Console.WriteLine("Limete de saque: " + conta2.Limite);
            Console.WriteLine("O número da conta é: " + conta2.Numero);
        }
    }
}  
