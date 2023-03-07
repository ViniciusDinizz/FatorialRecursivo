internal class Program
{
    private static void Main(string[] args)
    {
        int fatori = 0;

        Console.Write("Digite o número: ");
        fatori = int.Parse(Console.ReadLine());

        Console.WriteLine($"O fatorial de {fatori} = {funcFat(fatori, fatori)}");

        int funcFat(int fatori, int value)
        {
            if (fatori == 1)
            {
                return value;
            }
            else
            {
                return funcFat(fatori - 1, value *= fatori - 1);
            }
        }
    }
}