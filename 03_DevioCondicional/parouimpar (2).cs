using System;

class par_ou_impar
{
		static void Main()
	   {
			Console.Write("Digite um Numero:");
			int numero = int.Parse(Console.ReadLine());
			
			if(numero%2 == 0)
			   Console.WriteLine("o numero é par");
		   else
			   Console.WriteLine("O numero é impar");
	   }
			   
}