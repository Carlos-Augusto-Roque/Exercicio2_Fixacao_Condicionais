using System;

namespace Exercicio2_Fixacao_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            double precoG = 5.30;
            double precoE = 4.90;

            Console.Write("Digite o volume do abastecimento em litros: ");
            double volumeCombustivel = double.Parse(Console.ReadLine());

            Console.WriteLine("Escolha e digite o tipo de combustível abaixo: ");
            Console.WriteLine("G (Gasolina)");
            Console.WriteLine("E (Etanol)");
            string tipoCombustivel = Console.ReadLine();

            switch(tipoCombustivel)
            {
                case "G":
                if(tipoCombustivel == "G" && volumeCombustivel<= 20)
                {
                    Console.WriteLine("Abastecimento com Gasolina !");
                    double valorAbastecimento = (precoG * volumeCombustivel) * 0.96;
                    Console.WriteLine("O valor do abastecimento com desconto é de : R$ "+valorAbastecimento);
                }
                if(tipoCombustivel == "G" && volumeCombustivel> 20)
                {
                    Console.WriteLine("Abastecimento com Gasolina !");
                    double valorAbastecimento = (precoG * volumeCombustivel) * 0.94;
                    Console.WriteLine("O valor do abastecimento com desconto é de : R$ "+valorAbastecimento);
                }
                break;


                case "E": 
                
                if(tipoCombustivel == "E" && volumeCombustivel<= 20)
                {
                    Console.WriteLine("Abastecimento com Etanol !");
                    double valorAbastecimento = (precoE * volumeCombustivel) * 0.97;
                    Console.WriteLine("O valor do abastecimento com desconto é de : R$ "+valorAbastecimento);
                }
                if(tipoCombustivel == "E" && volumeCombustivel> 20)
                {
                    Console.WriteLine("Abastecimento com Etanol !");
                    double valorAbastecimento = (precoE * volumeCombustivel) * 0.95;
                    Console.WriteLine("O valor do abastecimento com desconto é de : R$ "+valorAbastecimento);
                }
                break;
            }

        }
    }
}
// 2 - Um posto está vendendo combustíveis com a seguinte tabela de descontos:
// Álcool:
// . até 20 litros, desconto de 3% por litro Álcool
// . acima de 20 litros, desconto de 5% por litro
// Gasolina:
// . até 20 litros, desconto de 4% por litro Gasolina
// . acima de 20 litros, desconto de 6% por litro

// Escreva um algoritmo que leia o número de litros vendidos e o tipo de combustível (codificado
// da seguinte forma: A-álcool, G-gasolina), calcule e imprima o valor a ser pago pelo cliente
// sabendo-se que o preço do litro da gasolina é R$ 5,30 e o preço do litro do álcool é R$ 4,90.
// Dica: utilize switch case e funções/métodos para otimizar o algorítimo.