using System;

namespace Calculadora_Simples
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pedir a operação
            // Pedir o 1º Número
            // Pedir o 2º Número

            Console.WriteLine("Digite a operação que deseja fazer \n Soma, Subtração, Multiplicação ou  Divisão");
            string operacao = Console.ReadLine();

             Console.WriteLine("Digite o 1º Número");
             float num1 = float.Parse(Console.ReadLine());
             
            Console.WriteLine("Digite o 2º Número");
             float num2 = float.Parse(Console.ReadLine());

            float resultado = 0;

        //     if(operacao == "Soma")
        //     {
        //         resultado = num1 + num2;
        //     }
        //     else if(operacao == "Subtração")
        //     {
        //         resultado = num1 - num2;
        //     }
        //     else if(operacao == "Multiplicação")
        //     {
        //         resultado = num1 * num2;
        //     }
        //     else if(operacao == "Divisão"){
        //         resultado = num1 / num2;
        //     }
        //     else{
        //         Console.WriteLine("Operação Inválida");
        //     }
        //     Console.WriteLine($"Resultado: {resultado}");
        // }
        // Não esquecer: para comentar todas as linhas selecionadas - pressione ctrl + ;

        // Switch / Case
        switch(operacao)
        {
            case "Soma":
            resultado = num1 + num2;
            break;

            case "Subtração":
            resultado = num1 - num2;
            break;

            case "Multiplicação":
            resultado = num1 * num2;
            break;

            case "Divisão":
            resultado = num1 / num2;
            break;

            default:
                Console.WriteLine("Operação inválida");
                break;
        }
        Console.WriteLine($"Calculo: {num1} e {num2} = Resultado: {resultado}");
        }
    }
}
    


