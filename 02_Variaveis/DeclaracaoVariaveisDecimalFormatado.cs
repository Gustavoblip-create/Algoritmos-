using System;

class DeclaracaoVariavelDecimalFormatado
{
	static void Main(string[] args)
	{
		decimal x = 0.999m;
		decimal y = 9999999999999999999999999999m;
		/*
		Ultilizando place Holder para demonstrar o coneudo de uma variavel no texto
		{0:c}
		0 = posição de marcação
		c= formatação de moedas (currency)
		*/
		
	
	    Console.WriteLine("Minha Quantia = {0:C}",x);
		Console.WriteLine("Sua Qauntia = {0:C}",y);
		Console.WriteLine("Valor de x = {0:F3} e valor de y = {1:c}",x,y);
		
		/*interpolação de string*/
		
		/* Console.WriteLine($"Minha Quantia = {x:C}");
Console.WriteLine($"Sua Quantia = {y:C}");
Console.WriteLine($"Valor de x = {x:F3} e valor de y = {y:C}");*/

	}
}