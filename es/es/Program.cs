namespace es
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ctel tele = new Ctel("1234567890", 5);
            Csim sim = new Csim("0987654321", 10);
            sim.addCtel(tele);
            sim.addCtel(new Ctel("1234567890", 10));
            sim.addCtel(new Ctel("1284564213", 15));
            Console.WriteLine(sim.totale_minuti());
        }
    }
}
