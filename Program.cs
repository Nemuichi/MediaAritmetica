double media, num1, num2, num3, num4;
 
Console.WriteLine("----------Qual a média da sua nota bimestral?----------");

Console.Write("Digite sua primeira nota: ");
 num1 = Convert.ToDouble(Console.ReadLine()!);

Console.Write("Digite sua segunda nota: ");
 num2 = Convert.ToDouble(Console.ReadLine()!);

Console.Write("Digite sua terceira nota: ");
 num3 = Convert.ToDouble(Console.ReadLine()!);

Console.Write("Digite sua quarta nota: ");
 num4 = Convert.ToDouble(Console.ReadLine()!);

media = (num1 + num2 + num3 + num4) / 4;    

Console.WriteLine($"Sua média anual é: {media.ToString("N1")}");
