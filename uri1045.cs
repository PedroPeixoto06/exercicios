using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {
        double A, B, C;

        string[] valores = Console.ReadLine().Split(' ');

        A = double.Parse(valores[0],CultureInfo.InvariantCulture);
        B = double.Parse(valores[1], CultureInfo.InvariantCulture);
        C = double.Parse(valores[2], CultureInfo.InvariantCulture);

        double[] lados = { A, B, C };
        Array.Sort(lados);
        Array.Reverse(lados);

        A = lados[0];
        B = lados[1];
        C = lados[2];

        if (A >= B + C)
        {
            Console.WriteLine("Não forma triangulo");
        }
        else
        {
            if (Math.Pow(A, 2) == Math.Pow(B, 2) + Math.Pow(C, 2))
            {
                Console.WriteLine("Forma um triangulo retangulo");
            }
            if (Math.Pow(A, 2) > Math.Pow(B, 2) + Math.Pow(C, 2))
            {
                Console.WriteLine("Forma um triangulo obtusangulo");
            }
            if (Math.Pow(A, 2) < Math.Pow(B, 2) + Math.Pow(C, 2))
            {
                Console.WriteLine("Forma um triangulo acutangulo");
            }
            if (A == B && B == C)
            {
                Console.WriteLine("Forma um triangulo equilatero");
            }
            if ((A == B && A != C) || (B == C && C != A) || (A == C && C != B))
            {
                Console.WriteLine("Forma um triangulo isosceles");
            }
        }

    }

}
