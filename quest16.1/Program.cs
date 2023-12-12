struct Notebook
{
    public void Print(string model, string producer, int cost)
    {
        Console.WriteLine($"Model - {model}");
        Console.WriteLine($"Producer - {producer}");
        Console.WriteLine($"Cost - {cost}");
    }
}

class Programm
{
    static void Main(string[] args)
    {
        Notebook notebook = new Notebook();
        notebook.Print("nitro 5", "acer", 50);
        Console.ReadKey();
    }
}