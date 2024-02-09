

using System;
using System.Runtime.InteropServices;
using System.Globalization;
using System.Net.Http.Headers;

namespace Program {
class Program {
static void Main(string[] args) {

    Funcionario f1 = new Funcionario();
    Funcionario f2 = new Funcionario();

    System.Console.WriteLine("Dados do primeiro Funcionario: ");
    System.Console.WriteLine("nome: ");
    f1.Nome = Console.ReadLine();
    Console.WriteLine("Salario: ");
    f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


    System.Console.WriteLine("Dados do segundo Funcionario: ");
    System.Console.WriteLine("nome: ");
    f2.Nome = Console.ReadLine();
    System.Console.WriteLine("salario: ");
    f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    double media = (f1.Salario + f2.Salario) / 2.0;

    Console.WriteLine("Salário médio = " + media.ToString("F2", CultureInfo.InvariantCulture));

        }   
    }
}