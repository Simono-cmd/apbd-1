Console.WriteLine("Hello, World!");
Console.WriteLine("Modyfikacja numero uno");
Console.WriteLine("Modyfikacja numero dos");
Console.WriteLine("Modyfikacja numero tres");

static double ObliczSrednia(int[] liczby)
{
    return liczby.Length == 0 ? 0 : liczby.Average();
}


static double ObliczMaximum(int[] liczby)
{
    int n = liczby.Length;
    return liczby.Length == 0 ? 0 : liczby.Max();
}
//poprawione

