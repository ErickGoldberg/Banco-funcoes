using System.Globalization;
using Teste;

class Program
{
    static void Main(string[] args)
    {
        Cliente cliente1 = new Cliente();

        Console.Write("Entre o número da conta: ");
        cliente1.NumeroDaConta = int.Parse(Console.ReadLine());

        Console.Write("Entre o titular da conta: ");
        cliente1.Titular = Console.ReadLine();

        Console.Write("Haverá deposito inicial (s/n)? ");
        char escolha = char.Parse(Console.ReadLine());
        if (escolha == 's')
        {
            Console.Write("Entre o valor do deposito inicial: ");
            cliente1.Deposito = int.Parse(Console.ReadLine());
        }
        
        Console.WriteLine("Dados da conta:");
        Console.Write(cliente1 + "\n \n");

        Console.Write("Entre um valor para déposito: ");
        int valorConta = int.Parse(Console.ReadLine());
        cliente1.Depositar(valorConta);

        Console.WriteLine("Dados da conta atualizados: ");
        Console.Write(cliente1 + "\n \n");

        Console.Write("Entre um valor para saque: ");
        valorConta = int.Parse(Console.ReadLine());
        cliente1.Sacar(valorConta);

        Console.WriteLine("Dados da conta atualizados: ");
        Console.Write(cliente1 + "\n \n");

    }
}
