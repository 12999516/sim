using static System.Console;

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
            WriteLine("informazioni telefonata\n\r" + tele.informazioni());
            WriteLine("");
            WriteLine("informazioni della sim\n\r" + sim.info());
            WriteLine("ricerca del numero 1234567890\n\r" + sim.cerca("1234567890"));
            WriteLine("totale dei minuti telefonati" + sim.totale_minuti());
        }
    }
}
