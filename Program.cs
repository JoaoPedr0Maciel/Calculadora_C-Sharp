internal class Program
{
  private static void Main(string[] args)
  {

    Menu();

  }

  static void Menu()
  {
    Console.Clear();
    Console.WriteLine("O que deseja Fazer?: ");
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Multiplicação");
    Console.WriteLine("4 - Divisão");
    Console.WriteLine("----------------");
    Console.WriteLine("Escolha uma opção: ");

    var res = Console.ReadLine();

    switch (res)
    {
      case "1": Soma(); break;
      case "2": Subtracao(); break;
      case "3": Multiplicacao(); break;
      case "4": Divisao(); break;
      default: Menu(); break;

    }

  }

  static void Soma()
  {
    Console.Clear();

    Console.WriteLine("Primeiro Valor: ");
    float num1 = float.Parse(Console.ReadLine() ?? "0");

    Console.WriteLine("Segundo Valor: ");
    float num2 = float.Parse(Console.ReadLine() ?? "0");

    Console.WriteLine($"Resultado da soma entre {num1} e {num2} é {num1 + num2}");
  }

  static void Subtracao()
  {
    Console.Clear();

    Console.WriteLine("Primeiro Valor: ");
    float num1 = float.Parse(Console.ReadLine() ?? "0");

    Console.WriteLine("Segundo Valor: ");
    float num2 = float.Parse(Console.ReadLine() ?? "0");

    Console.WriteLine($"Resultado da subtração entre {num1} e {num2} é {num1 - num2}");
  }

  static void Multiplicacao()
  {
    Console.Clear();

    Console.WriteLine("Primeiro valor: ");
    float num1 = float.Parse(Console.ReadLine() ?? "0");

    Console.WriteLine("Segundo valor: ");
    float num2 = float.Parse(Console.ReadLine() ?? "0");

    Console.WriteLine($"Resultado da multiplicação entre {num1} e {num2} é {num1 * num2}");

  }

  static void Divisao()
  {
    Console.Clear();

    Console.WriteLine("Primeiro valor: ");
    float num1 = float.Parse(Console.ReadLine() ?? "0");

    Console.WriteLine("Segundo valor: ");
    float num2 = float.Parse(Console.ReadLine() ?? "0");

    Console.WriteLine($"Resultado da divisão entre {num1} e {num2} é {num1 / num2}");
  }
}