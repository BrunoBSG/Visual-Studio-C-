int idade = 0;
Console.WriteLine("Qual sua idade?");
idade = int.Parse(Console.ReadLine());
idade = 365*idade;
Console.WriteLine($"Você tem {idade} dias de vida");
Console.ReadKey();