﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_2_Coletto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercício 1
            void CalculaAreaRetangulo()
            {
                double baseRetangulo, alturaRetangulo, areaRetangulo;
                bool converteu = false;

                
                converteu = double.TryParse(Console.ReadLine(), out baseRetangulo);

                while (!converteu || baseRetangulo < 0 )
                {
                    Console.WriteLine("Valor inválido! Digite novamemnte");
                    converteu = double.TryParse(Console.ReadLine(), out baseRetangulo);
                }

                Console.WriteLine("Digite a medida da altura do retângulo: ");
                converteu = double.TryParse(Console.ReadLine(), out alturaRetangulo);

                while (!converteu || alturaRetangulo < 0)
                {
                    Console.WriteLine("Valor inválido! Digite novamemnte");
                    converteu = double.TryParse(Console.ReadLine(), out alturaRetangulo);
                }

                areaRetangulo = baseRetangulo * alturaRetangulo;

                Console.WriteLine("A área do retãngulo mede " + areaRetangulo + " uni.");

                Console.ReadKey();

            }

            // Exercício 2
            void CalculaAreaECircunferencia()
            {
                double diametro = 0, area, circunferencia;

                bool converteuDiametro = false; 

                while (!converteuDiametro)
                {
                    Console.WriteLine("Digite a medida do diâmetro do círculo: ");
                    converteuDiametro = double.TryParse(Console.ReadLine(), out diametro);

                    if(!converteuDiametro || diametro < 0)
                    {
                        Console.WriteLine("Valor inválido");
                        converteuDiametro = false;
                    }
                }

                area = ((diametro / 2) * (diametro / 2)) * Math.PI;
                circunferencia = diametro * Math.PI;

                Console.WriteLine("Valor da área do círculo: " + area.ToString("N2") + " uni.");
                Console.WriteLine("Valor do perímetro do círculo: " + circunferencia.ToString("N2") + " uni.");

                Console.ReadKey ();
            }

            // Exercício 4
            void RecebeValoresEIndicaOMaior()
            {
                double num1 = 0, num2 = 0;
                bool converteuNumero = false;

                while (!converteuNumero)
                {
                    Console.WriteLine("Digite o primeiro número: ");
                    converteuNumero = double.TryParse(Console.ReadLine(), out num1);

                    if (!converteuNumero)
                    {
                        Console.WriteLine("Valor inválido.");
                        converteuNumero = false;
                    }
                }

                converteuNumero = false;

                while (!converteuNumero)
                {
                    Console.WriteLine("Digite o segundo número: ");
                    converteuNumero = double.TryParse(Console.ReadLine(), out num2);

                    if (!converteuNumero)
                    {
                        Console.WriteLine("Valor inválido.");
                        converteuNumero = false;
                    }
                }

                if (num1 > num2)
                {
                    Console.WriteLine("O maior número é " + num1);
                }
                else if (num1 < num2)
                {
                    Console.WriteLine("O maior número é " + num2);
                }
                else
                {
                    Console.WriteLine("O mesmo número foi digitado duas vezes");
                }

                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Digite 's' para comparar outros números");
                Console.WriteLine("Digite qualquer outra tecla para sair");

                string opcaoEscolhida = Console.ReadLine();
                if (opcaoEscolhida == "s" || opcaoEscolhida == "S")
                    RecebeValoresEIndicaOMaior();
                else
                    Environment.Exit(0);
            }

            // Exercício 5 e 6
            void VerificaSeValoresFormamTriangulo()
            {
                double lado1 = 0, lado2 = 0, lado3 = 0;

                bool converteuDouble = false;   

                while(!converteuDouble)
                {
                    Console.WriteLine("Digite o valor do primeiro lado do triângulo: ");
                    converteuDouble = double.TryParse((Console.ReadLine()), out lado1);

                    if (!converteuDouble || lado1 < 0)
                    {
                        Console.WriteLine("Valor inválido.");
                        converteuDouble = false;
                    }
                }

                converteuDouble = false;

                while (!converteuDouble)
                {
                    Console.WriteLine("Digite o valor do segundo lado do triângulo: ");
                    converteuDouble = double.TryParse((Console.ReadLine()), out lado2);

                    if (!converteuDouble || lado2 < 0)
                    {
                        Console.WriteLine("Valor inválido.");
                        converteuDouble = false;
                    }
                }

                converteuDouble = false;

                while (!converteuDouble)
                {
                    Console.WriteLine("Digite o valor do terceiro lado do triângulo: ");
                    converteuDouble = double.TryParse((Console.ReadLine()), out lado3);

                    if (!converteuDouble || lado3 < 0)
                    {
                        Console.WriteLine("Valor inválido.");
                        converteuDouble = false;
                    }
                }
                
                if (lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1)
                {
                    if (lado1 == lado2 && lado1 == lado3)
                    {
                        Console.WriteLine("É um triângulo equilátero");
                    }
                    else if ((lado1 == lado2 && lado1 != lado3) || (lado1 == lado3 && lado1 != lado2) || (lado2 == lado3 && lado2 != lado1)) {
                        Console.WriteLine("É um triângulo isósceles");
                    }
                    else
                    {
                        Console.WriteLine("É um triângulo escaleno");
                    }
                }
                else
                {
                     Console.WriteLine("Não é triângulo");
                }

                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Digite 's' para digitar outros valores");
                Console.WriteLine("Digite qualquer outra tecla para sair");

                string opcaoEscolhida = Console.ReadLine();
                if (opcaoEscolhida == "s" || opcaoEscolhida == "S")
                    VerificaSeValoresFormamTriangulo();
                else
                    Environment.Exit(0);
            }


            // CalculaAreaRetangulo();
            //CalculaAreaECircunferencia();
            // RecebeValoresEIndicaOMaior();
            VerificaSeValoresFormamTriangulo();
        }
    }
}
