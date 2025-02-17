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

        //var 1
        var z = new ZifferMaschine();
        var resultat2 = z.AlgoNichtStatic(input);
        //var 2
        var resultat = ZifferMaschine.Algo(input);

        Console.WriteLine(resultat);





    }




}


