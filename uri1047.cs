using System;

class URI
{
    static void Main(string[] args)
    {
        string[] vet = Console.ReadLine().Split(' ');

        int hi = int.Parse(vet[0]);
        int mi = int.Parse(vet[1]);
        int hf = int.Parse(vet[2]);
        int mf = int.Parse(vet[3]);

        int inicio = hi * 60 + mi;
        int fim = hf * 60 + mf;

        int totalMinutos;

        if (fim > inicio)
        {
            totalMinutos = fim - inicio;
        }
        else
        {
            totalMinutos = (24 * 60 - inicio) + fim;
        }

        int duraçãoH = totalMinutos / 60;
        int duraçãoM = totalMinutos % 60;

        Console.WriteLine("O JOGO DUROU " + duraçãoH + " HORA(S) E " + duraçãoM + " MINUTO(S)");
    }
}
