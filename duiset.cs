using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Randomly select an element from the distribution array:");

        int[] distribution = { 10, 20, 30, 40, 50 };
        Random random = new Random();
        
        // Select a random index
        int i = random.Next(distribution.Length);

        // Output the selected element
        Console.WriteLine($"Selected element at index {i}: {distribution[i]}");
    }
}
