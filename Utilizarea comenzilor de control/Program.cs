using System;

class Program
{
    static void Main()
    {
        int[] array = { 12, 23, -22, -765, 43, 545, -4, -55, 43, 12, 351, -999, -87 };

        // Initializează două liste pentru numerele pozitive și negative
        System.Collections.Generic.List<int> numerePozitive = new System.Collections.Generic.List<int>();
        System.Collections.Generic.List<int> numereNegative = new System.Collections.Generic.List<int>();

        // Parcurge fiecare element din șir și le plasează în listele corespunzătoare
        foreach (int numar in array)
        {
            if (numar >= 0)
            {
                numerePozitive.Add(numar);
            }
            else
            {
                numereNegative.Add(numar);
            }
        }

        // Afișează numerele pozitive
        Console.WriteLine("Numerele pozitive sunt:");
        foreach (int pozitiv in numerePozitive)
        {
            Console.Write(pozitiv + " ");
        }

        // Afișează numerele negative
        Console.WriteLine("\nNumerele negative sunt:");
        foreach (int negativ in numereNegative)
        {
            Console.Write(negativ + " ");
        }
    }
}
