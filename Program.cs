using projetoCalculadoraCmd.models;


bool vControle = true;
Calculadora calc = new Calculadora();
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
    if(opcao >= 1 && opcao <= 4)
    {
            Console.Clear();
            Console.WriteLine("Primeiro número:  ");
            decimal primeiroValor = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Segundo número: ");
            decimal segundoValor = decimal.Parse(Console.ReadLine());
            if(opcao == 1)
            {
                Console.WriteLine($"Resultado = {calc.Somar(primeiroValor, segundoValor)}");
                Console.WriteLine("Aperte qualquer tecla para continuar... ");
                Console.ReadLine();
                Console.Clear();
            }else if(opcao == 2)
            {
                Console.WriteLine($"Resultado = {calc.Subtrair(primeiroValor, segundoValor)}");
                Console.WriteLine("Aperte qualquer tecla para continuar... ");
                Console.ReadLine();
                Console.Clear();
            }else if(opcao == 3)
            {
                Console.WriteLine($"Resultado = {calc.Multiplicar(primeiroValor, segundoValor)}");
                Console.WriteLine("Aperte qualquer tecla para continuar... ");
                Console.ReadLine();
                Console.Clear();
            }else if(opcao == 4)
            {
                Console.WriteLine($"Resultado = {calc.Dividir(primeiroValor, segundoValor)}");
                Console.WriteLine("Aperte qualquer tecla para continuar... ");
                Console.ReadLine();
                Console.Clear();
            }
    }else
    {
        vControle = false;
        Console.Clear();
    }
}