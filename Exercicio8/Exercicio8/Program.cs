int n = 0;
Console.WriteLine("Digite um número");
n = int.Parse(Console.ReadLine());
if (n>0) {
    Console.WriteLine ($"{n} é positivo")
    ;}
else if (n == 0) {Console.WriteLine("Número inválido");}
else if (n<0) { Console.WriteLine($"{n} é negativo"); }
