int m  = 0;
double valorcompra = 0;
Console.WriteLine("Digite o número de maçãs que você comprou");
m =int.Parse(Console.ReadLine());
if (m<=12) {
    valorcompra = m;
    Console.WriteLine($"Sua compra ficou R${valorcompra}") ; }
else if (m>12) {
    
    valorcompra = m * 1.30;
    Console.WriteLine($"Sua compra ficou R${valorcompra}"); }
 