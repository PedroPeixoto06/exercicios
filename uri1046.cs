using System;
using System.Security.Cryptography;

class URI
{
    static void Main(String[] args)
    {
        int hi, hf;
        int duração = 0;

        string[] vet = Console.ReadLine().Split(' ');

        hi = int.Parse(vet[0]);
        hf = int.Parse(vet[1]);

        if (hi == hf)
        {
            duração = 24;
        }
        else if (hi > hf)
        {
            duração = 24 - hi + hf;
        }
        else if (hi < hf)
        {
            duração = hf - hi;
        }
        Console.WriteLine("O JOGO DUROU " + duração + " HORA(S)");
    }
    }


