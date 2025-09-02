using System;

namespace _07_TempoDownload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float tamanhoArquivo=0;
            float MBps=0;
            float segundos=0;
            float minuto=0;
            bool Digitacaovalida = false;


            while (!Digitacaovalida)

            {
                Console.WriteLine("Digite O Tamanho do seu arquivo");
                Digitacaovalida = float.TryParse(Console.ReadLine(), out tamanhoArquivo);
            }
        
            Console.WriteLine("Digite o MBps por segundo: ");
            MBps = float.Parse(Console.ReadLine());

            segundos = (tamanhoArquivo * 8) / MBps;
            minuto = segundos / 60;
            
            Console.Write("segundos: ");
            Console.Write(segundos);
            
             Console.WriteLine("Minutos: ");
            Console.WriteLine(minuto);















        }
    }
}
