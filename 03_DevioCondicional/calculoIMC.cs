using System;

class CalculoIMC
{
	static void Main()
	{
		double peso, altura, imc;
		
		Console.WriteLine("Digite seu peso(kg):");
		// ConsolerdLine() é equivalente ao leia do portugol
		peso = Double.Parse ( Console.ReadLine() );
		
		Console.WriteLine("Digite sua Altura (m)");
		altura = Double.Parse (Console.ReadLine() );
		imc = peso / (altura * altura);
		
		Console.WriteLine("seu IMC é {0:F3}", imc);
		if( imc < 18.6)
		{
		Console.WriteLine("Classificação: abaixo do peso");
		}else if( imc <25)
		{
		Console.WriteLine("Classificação : peso normal");
		}else
		{
		Console.WriteLine("Classificação: acima do peso");
		}
	
	
}