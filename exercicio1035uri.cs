﻿using System;

class URI
{

    static void Main(string[] args)
    {

        int a,b,c,d;

        string[] numeros = (Console.ReadLine().Split(' '));
        a = Convert.ToInt32(numeros[0]);
        b = Convert.ToInt32(numeros[1]);
        c = Convert.ToInt32(numeros[2]);
        d = Convert.ToInt32(numeros[3]);

        if (b > c && d > a && c + d > a + b && c > 0 && d > 0 && a%2 == 0 )  {
            Console.WriteLine("Valores aceitos");
        }
        else {
            Console.WriteLine("Valores nao aceitos");
             }
    }

}


