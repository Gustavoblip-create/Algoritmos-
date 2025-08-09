using System;
using System.Linq;


namespace _05_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Criação de um vetor para armazenamneto de 100 elementos
            //string [] nomes = ("fulano","beltrano","ciclano");
            string[] nomes = new string [100];
            String continuar = "S";
            int contador = 0;

            //Loop while
            //Sintaxe: while( Expressão Boleana)

            while (continuar .ToUpper() == "S")
            {

                Console.WriteLine("Digite o {0}ª nome: ", contador+1);
                //Append: adiciona um item no vetor
                nomes[contador] = Console.ReadLine();

                // Incremenetar o contador
                contador++;
                

                Console.WriteLine("Deseja continuar? (S/N)");
                continuar = Console.ReadLine();
            }

            Console.WriteLine("nome informado");
            foreach (string str in nomes)
            {
                //!= signigica Diferente
                if (str != null)
                {
                    Console.WriteLine(str);
                }
            }

        }
    }
}
