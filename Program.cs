using System;

class Program 
{
  public static void Main (string[] args) 
  {
    string nome;
    string idade;
    string CPF;
    string logradouro;
    string bairro;
    string numero;
    string complemento;
    
    Console.WriteLine ("Digite seu Nome Completo :");
    nome = Console.ReadLine();

    Console.WriteLine("digite sua idade :");
      idade = Console.ReadLine();

      Console.WriteLine("digite seu CPF :");
      CPF = Console.ReadLine();

    Console.WriteLine ("digite seu logradouro");
    logradouro = Console.ReadLine();

    Console.WriteLine("digite seu bairro");
    bairro = Console.ReadLine();

        Console.WriteLine("digite o numero da sua residencia");
        numero = Console.ReadLine();

        Console.WriteLine("digite um complemento (opcional)");
        complemento = Console.ReadLine();
    
    }
}