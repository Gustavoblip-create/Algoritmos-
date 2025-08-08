using System;

namespace _04_Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //delcaração de variavev
            //sintaxe: tipo nomevariavel = valor
            string nome = "Fulano de Tal";
            //Reatribuiçaõ de Valores em uma variavel
            nome = "Beltrano"; 
               Console.WriteLine(nome);

            //Declaração de Vetores
            //Sintaxe tipo[] nomeVariavel = {valor1, valor2, valor3};
            
            string[] nomes = { "Fulano de tal","Beltrano","Sicrano","joão","josé","josé","Maria"};
            Console.WriteLine(nomes[0]);
            Console.WriteLine(nomes[1]);
            Console.WriteLine(nomes[2]);

            //loop for
            //sintaxe: for (indicador; controle incremento)
            for (int i = 0; i < nomes.Length; i++)
            { 
                    Console.WriteLine(nomes[i]);
            }
            //impressão dos 100 primeiros numeros pares
            for (int i = 0; i <= 100; i += 2) 
            {
                Console.WriteLine("Numero : {0}",i);
            }

            //Loop foreach
            //Sintaxe: foreatch (vatiavel in vetor)
            foreach (string varNome in nomes)
            {
                Console.WriteLine("Nome : {0}", varNome);
            }

        }
    }
}
