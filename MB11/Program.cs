using MB11.EinfuehrungsBeispiel;
using MB11.ZifferSortierAufgabe;

public class Program
{
    public static void Main()
    {
        // Einführungsbeispiel
        //LogView.PrintReadAllLogs();
        //Console.ReadLine();



        var input = Console.ReadLine();
        var output = ZifferMaschine.Methode(input);
        Console.WriteLine(output);

        Console.ReadLine();
    }




}


