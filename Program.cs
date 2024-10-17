using projetoCalculadoraCmd.models;

bool vControle = true;
while(vControle)
{
    int opcao;
    Console.WriteLine("ESCOLHA UMA OPÇÃO ABAIXO: ");
    Console.WriteLine("1 - SOMAR");
    Console.WriteLine("2 - SUBTRAIR");
    Console.WriteLine("3 - MULTIPLICAR");
    Console.WriteLine("4 - DIVIDIR");
    Console.WriteLine("0 - SAIR");
    string ?opc = Console.ReadLine();
    int.TryParse(opc, out opcao);
    switch (opcao)
    {
        case 0:
            vControle = false;
            Console.Clear();
            break;
        case 1:
            
    }
}