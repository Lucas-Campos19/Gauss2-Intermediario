using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gauss2_Intermediario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int escolha;
            do
            {
                Console.WriteLine("Escolha um dos exercícios");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("1 = um programa que receba 10 números e armazene em uma lista e exiba os valores armazenados");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("2 = um programa que receba 10 frases e armazene em uma lista e exiba os valores armazenados");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("3 = um programa que receba qualquer valor mas so adicione na lista valores impares e exiba seus valores");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("4 = um programa que receba qualquer valor mas so adicione na lista valores pares e exiba seus valores");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("5 = um programa que receba 10 valores em uma lista e calcule sua media e exiba o valor da media.");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
                Console.Write("Escolha um número de 1 a 5: ");
                escolha = int.Parse(Console.ReadLine());
            } while (escolha != 1 && escolha != 2 && escolha != 3 && escolha != 4 && escolha != 5);

            if(escolha == 1)
            {
                int i = 0;
                Console.WriteLine("Exercício escolhido: um programa que receba 10 valores em uma lista e calcule sua media e exiba o valor da media.");
                numerosArmazenados(i);
            }
            else if(escolha == 2)
            {
                int percorre = 0;
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("2 = um programa que receba 10 frases e armazene em uma lista e exiba os valores armazenados");
                frasesArmazenadas(percorre);
            }
            Console.ReadKey();
        }

        static int numerosArmazenados(int i)
        {
            int[] numeros = { 10,20,30,40,50,60,70,80,90,100};
            for(i = 0; i<numeros.Length; i++)
            {
                Console.Write(numeros[i] + " ");
            }
            return i;
        }
        static int frasesArmazenadas(int percorre)
        {
            string[] frases = new string[5];
            frases[0] = "João come muita banana";
            frases[1] = "são paulo futebol clube é o mio time";
            frases[2] = "ai zé da manga";
            frases[3] = "kkkkkkkkkkkkkkkkkkkkkkkk";
            frases[4] = "não sei mais o que colocar aqui";

            for (percorre = 0; percorre < frases.Length; percorre++)
            {
                Console.WriteLine(frases[percorre]);
            }
            return percorre;

        }
    }
}
