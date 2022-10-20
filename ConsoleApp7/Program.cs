using ConsoleApp7;

class Program{
    static void Main(string[] args) {
        Ford ford = new Ford("Mustang", 120, 12);
        Console.WriteLine(ford.VypocetCesty(200));
    }
}