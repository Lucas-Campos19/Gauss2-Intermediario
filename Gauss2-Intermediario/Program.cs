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
            inicio:
            int escolha;
            do
            {
                Console.Clear();
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
                Console.WriteLine("Exercício escolhido: um programa que receba 10 números e armazene em uma lista e exiba os valores armazenados");
                numerosArmazenados(i);
            }
            else if(escolha == 2)
            {
                int percorre = 0;
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("2 = um programa que receba 10 frases e armazene em uma lista e exiba os valores armazenados");
                frasesArmazenadas(percorre);
            }
            else if(escolha == 3)
            {
                int valores = 0;
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("3 = um programa que receba qualquer valor mas so adicione na lista valores impares e exiba seus valores");
                imparesLista(valores);
            }
            else if(escolha == 4)
            {
                int valores = 0;
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("4 = um programa que receba qualquer valor mas so adicione na lista valores pares e exiba seus valores");
                paresLista(valores);

            }
            else
            {
                double media = 0;
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("5 = um programa que receba 10 valores em uma lista e calcule sua media e exiba o valor da media.");
                Media(media);
            }
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
            Console.Write("Deseja escolher outro exercício ? [s/n] ");
            char retorno = char.Parse(Console.ReadLine());
            if(retorno == 's' || retorno == 'S')
            {
                goto inicio;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Programa encerrado!!!");
            }
            Console.ReadKey();
        }

        static int numerosArmazenados(int i)
        {
            int[] numeros = { 10,20,30,40,50,60,70,80,90,100};
            for(i = 0; i<numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }
            return i;
        }
        static int frasesArmazenadas(int percorre)
        {
            Console.WriteLine();
            string[] frases = new string[10];
            frases[0] = "João come muita banana";
            frases[1] = "são paulo futebol clube é o mio time";
            frases[2] = "vasco da gama";
            frases[3] = "kkkkkkkkkkkkkkkkkkkkkkkk";
            frases[4] = "não sei mais o que colocar aqui";
            frases[5] = "Existem diversas ferramentas online que geram frases aleatórias";
            frases[6] = "Algumas dessas ferramentas permitem escolher a categoria ou o autor das frases";
            frases[7] = "As frases geradas podem ser usadas em posts, tweets, histórias, cartas, entre outros";
            frases[8] = "Algumas frases aleatórias encontradas na web são";
            frases[9] = "o ruim de mentir, com tempo você acaba acreditando nas suas próprias mentiras";

            for (percorre = 0; percorre < frases.Length; percorre++)
            {
                Console.WriteLine(frases[percorre]);
            }
            return percorre;
        }
        static int imparesLista(int valores)
        {
            Console.WriteLine();
            Console.Write("Quantos valores impares deseja adicionar na lista: ");
            int totalRepeticao = int.Parse(Console.ReadLine());
            List<int> numeros = new List<int>();
            for(int i = 0; i < totalRepeticao; i++)
            {
                Console.WriteLine("Digite um número: ");
                int numeroUsuario = int.Parse(Console.ReadLine());
                
                if(numeroUsuario % 2 != 0)
                {
                    numeros.Add(numeroUsuario);
                }
                else
                {
                    i--;
                }
            }
            Console.WriteLine("Números armazenados na lista:");
            foreach (int numero in numeros)
            {
                valores = numero;
                Console.WriteLine(valores);
            }
            return valores;
           
        }
        static int paresLista(int valores)
        {
            Console.WriteLine();
            Console.Write("Quantos valores pares deseja adicionar na lista: ");
            int totalRepeticao = int.Parse(Console.ReadLine());
            List<int> numeros = new List<int>();
            for (int i = 0; i < totalRepeticao; i++)
            {
                Console.WriteLine("Digite um número: ");
                int numeroUsuario = int.Parse(Console.ReadLine());

                if (numeroUsuario % 2 == 0)
                {
                    numeros.Add(numeroUsuario);
                }
                else
                {
                    i--;
                }
            }
            Console.WriteLine("Números armazenados na lista:");
            foreach (int numero in numeros)
            {
                valores = numero;
                Console.WriteLine(valores);
            }
            return valores;
        }
        static double Media(double media)
        {
            Console.WriteLine();
            media = 0;
            double soma = 0;
            List<double> numeros = new List<double>();
            Console.WriteLine("Digite 10 números:");
            for (int i = 0; i < 10; i++)
            {
                numeros.Add(double.Parse(Console.ReadLine()));
            }
            foreach(double numero in numeros)
            {
                soma+=numero;
            }
            media = soma / 10;
            Console.WriteLine("Média: {0}", media);
            return media;   
        }

    }
}
