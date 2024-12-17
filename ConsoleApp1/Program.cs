internal class Program
{
    private static void Main(string[] args)
    {
        Menu();

    }

    static void Menu() 
    {
        Console.Clear();

        Console.WriteLine("Qual operador deseja utilizar?");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtracao");
        Console.WriteLine("3 - Multiplicacao");
        Console.WriteLine("4 - Divisao");
        Console.WriteLine("0 - Sair");

        Console.WriteLine("-----------");
        Console.WriteLine("Selecione uma opcao");

        short res = short.Parse(Console.ReadLine());

        switch (res) 
        {
            case 0: System.Environment.Exit(0); break;
            case 1: Soma(); break;
            case 2: Subtracao(); break;
            case 3: Multiplicacao(); break;
            case 4: Divisao(); break;
            default: Menu(); break;
        
        }



    }

       

    static void Soma()
    {
        Console.Clear();
        Console.WriteLine("Primeiro Valor");
        float v1 = float.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Segundo Valor");
        float v2 = float.Parse(Console.ReadLine());

        float resultado = v1 + v2;

        Console.Clear();
        Console.WriteLine($"O Resultado é: {resultado} ");
    }

    static void Subtracao()
    {
        Console.Clear();
        Console.WriteLine("Primeiro Valor");
        float v1 = float.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Segundo Valor");
        float v2 = float.Parse(Console.ReadLine());

        float resultado = v1 - v2;

        Console.Clear();
        Console.WriteLine($"O resultado da subtracao é {resultado}");
    }

    static void Multiplicacao()
    {
        Console.Clear();
        Console.WriteLine("Primeiro Valor");
        float v1 = float.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Segundo Valor");
        float v2 = float.Parse(Console.ReadLine());

        float resultado = v1 * v2;

        Console.Clear();
        Console.WriteLine($"O Resultado da Multiplicacao é : {resultado}");
    }

    static void Divisao()
    {
        Console.Clear();
        Console.WriteLine("Primeiro Valor");
        float v1 = float.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Segundo Valor");
        float v2 = float.Parse(Console.ReadLine());

        float resultado = v1 / v2;

        Console.Clear();
        Console.WriteLine($"O resultado da divisao é: {resultado}");
    }
}