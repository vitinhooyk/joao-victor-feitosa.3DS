namespace MeuSegundoApp
{
    class Program
    {
        static void Main(string[] args)
        {
        /*
        Exercicio 1
        
        Console.WriteLine("Insira o primeiro número: ");
        var num = int.Parse(Console.ReadLine());
        Console.WriteLine("Insira o segundo número: ");
        var num2 = int.Parse(Console.ReadLine());

        var soma = num + num2;
        var sub = num - num2;
        var mult = num * num2;
        double div = num / num2;

        Console.WriteLine($"Soma: {soma}");
        Console.WriteLine($"Subtração: {sub}");
        Console.WriteLine($"Multiplicação: {mult}");
        Console.WriteLine($"Divisão: {div}");
        */
        
        /* Exercicio 2
        Console.WriteLine("Insira o valor do produto: ");
        var num = int.Parse(Console.ReadLine());
        Console.WriteLine("Insira o valor do desconto: ");
        var num2 = int.Parse(Console.ReadLine());

        double valordesc = (num/100)*num2;
        var valor = num - valordesc;

        Console.WriteLine($"O valor do desconto é igual a {valordesc}");
        Console.WriteLine($"O valor do produto é igual a {valor}");
        */
        
       /* Exercicio 3
        int i = 0;
        for(i = 0; i<=20; i++)
        {
          if(i%2==0){
           Console.WriteLine($"  {i}");
          }
        }
       */
        
        /*Exercicio 4
        Console.Write("Digite o valor de A: ");
        int A = int.Parse(Console.ReadLine());
        
        Console.Write("Digite o valor de B: ");
        int B = int.Parse(Console.ReadLine());

        if (A > B)
        {
            int temp = A;
            A = B;
            B = temp;
        }

        int soma = 0;
        for (int i = A; i <= B; i++)
        {
            soma += i;
        }

        Console.WriteLine("SOMA: " + soma);

       */

       /* Exercicio 5
       int[] numeros = new int[5];

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Digite o número {0}: ", i + 1);
            numeros[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Valores na ordem inversa:");
        for (int i = 4; i >= 0; i--)
        {
            Console.Write(numeros[i] + " ");
        }
        */

        /*Exercicio 6 
        int[] numeros = new int[5];
        

        Console.WriteLine("Digite 5 números:");

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Digite o número que você deseja buscar: ");
        int numeroBuscar = int.Parse(Console.ReadLine());

  
        bool encontrado = false;
        foreach (int numero in numeros)
        {
            if (numero == numeroBuscar)
            {
                encontrado = true;
                break;
            }
        }

        if (encontrado)
        {
            Console.WriteLine($"O número {numeroBuscar} está na lista.");
        }
        else
        {
            Console.WriteLine($"O número {numeroBuscar} não está na lista.");
        }

        */

        /* Exercicio 7

        Console.WriteLine("Digite a primeira nota: ");
        var nt1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite a segunda nota: ");
        var nt2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite a terceira nota: ");
        var nt3 = int.Parse(Console.ReadLine());

        double med = nt1 + nt2 + nt3 / 3;
        if( med >= 7){
        Console.WriteLine(" O aluno foi aprovado !");

        } 
        
        else{
        Console.WriteLine(" O aluno foi reprovado !");
        }
        */

       /* Exercicio 8
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());

        if (EhPrimo(numero))
        {
            Console.WriteLine($"O número {numero} é primo.");
        }
        else
        {
            Console.WriteLine($"O número {numero} não é primo.");
        }
    }

    static bool EhPrimo(int numero)
    {
        if (numero <= 1)
        {
            return false; 
        }

        for (int i = 2; i <= Math.Sqrt(numero); i++)
        {
            if (numero % i == 0) 
            {
                return false; 
            }
        }

        return true; 
    } */
  
      /*  Exercicio  9
        Carro meuCarro = new Carro();
        
        meuCarro.Marca = "Toyota";
        meuCarro.Modelo = "Corolla";
        meuCarro.Ano = 2020;
        Console.WriteLine($"{meuCarro.Marca} {meuCarro.Modelo} - {meuCarro.Ano}");
    }
}

class Carro
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Ano { get; set; } */
    
 /*   }

  }
}
*/