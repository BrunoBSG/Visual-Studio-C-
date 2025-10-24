int opcao1 = 0;
int enquanto = 1;
//Variveis usadas nas operações
int soma1, soma2 = 0;
int menos1, menos2 = 0;
int vezes1, vezes2 = 0;
//preguiça de mecher, mas o nome da variavel era para ser dividir.
int divir1, divir2 = 0;


while (enquanto == 1) 
{
    Console.WriteLine("Digite a operação\nLimpar - 0\nSoma - 1\nSubtrção - 2\nVezes - 3\nDivisão - 4 ");
    opcao1 = int.Parse(Console.ReadLine());
    //finalizar caso for diferente das operações
    if (opcao1 != 0 && opcao1 != 1 && opcao1 != 2 && opcao1 != 3 && opcao1 != 4  ) 
    {
        break;
    }
    switch (opcao1)
    {
        case 0:
            Console.Clear();
        break;
        case 1:
            Console.WriteLine("Digite o primeiro número a ser somado:");
            soma1 = int.Parse(Console.ReadLine());  
            Console.WriteLine("Digite o segundo número a ser somado:");
            soma2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"A soma entre {soma1} e {soma2} é {soma1+soma2}");
            break;
        case 2:
            Console.WriteLine("Digite o primeiro número a ser subtraido:");
            menos1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número a ser subtraido:");
            menos2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"A soma entre {menos1} e {menos2} é {menos1 - menos2}");
            break;
            case 3:
            Console.WriteLine("Digite o primeiro número a ser subtraido:");
            vezes1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número a ser subtraido:");
            vezes2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"A soma entre {vezes1} e {vezes2} é {vezes1 * vezes2}");
            break;
            case 4:
            Console.WriteLine("Digite o primeiro número a ser subtraido:");
            divir1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número a ser subtraido:");
            divir2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"A soma entre {divir1} e {divir2} é {divir1:divir2}");
            break;

    }



}


















