using System;

class ClassificacaoIdade
{
		static void Main()
		{
			Console.Write("Digite sua idade: ");
			int idade = int.Parse(Console.ReadLine());
			
			if(idade <12)
				Console.WriteLine("Criança");
			else if(idade<18)
				Console.WriteLine("Adolescente");
			else if (idade< 60)
				Console.WriteLine("Adulto");
			else
				Console.WriteLine("idoso");
		}
}