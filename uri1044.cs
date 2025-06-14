using System;

class URI
{

    static void Main(string[] args)
    {
        int a, b;

        string[] numeros = Console.ReadLine().Split(' ');
        a = Convert.ToInt32(numeros[0]);
        b = Convert.ToInt32(numeros[1]);

        if(a%b == 0 || b%a == 0)
        {
            Console.WriteLine("Sao multiplos");
        } else
        {
            Console.WriteLine("Nao sao multiplos");
        }

    }

}
