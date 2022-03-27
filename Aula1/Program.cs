using System;

// namespace Aula1
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//           int valor1;
//           int valor2; 
//           int total; 

//             Console.WriteLine("Digite o primeiro valor");
//             valor1 = int.Parse(Console.ReadLine());
//             Console.WriteLine("O primeiro valor é: " + valor1);

//             Console.WriteLine("Digite o segundo valor");
//             valor2 = int.Parse(Console.ReadLine());
//             Console.WriteLine("O segundo valor é: " + valor2);

//             total = valor1 +valor2;
//             Console.WriteLine("A soma dos dois valor é: "+ total);
//         }
//     }
// }



using System;

class DIO
{

    static void Main(string[] args)
    {
        string[] input = null;

        int peca1;
        int peca2;

        Console.WriteLine("Escreva o código da peça 1, a quantidade de peças e seu valor unitário");
        peca1 = int.Parse(Console.ReadLine());
        int cod1 = int.Parse(input[0]);
        int n1 = int.Parse(input[1]);
        double valor1 = double.Parse(input[2]);
        //Escreva sua lógica nos espaços em branco
        Console.WriteLine("Escreva o código da peça 2, a quantidade de peças e seu valor unitário");
        peca2 = int.Parse(Console.ReadLine());
        int cod2 = int.Parse(input[0]);
        int n2 = int.Parse(input[1]);
        double valor2 = double.Parse(input[2]);

        double total = (peca1 + peca2) * (n1) * (n2);
        Console.WriteLine("VALOR A PAGAR: R$ ", +total);
    }

}
