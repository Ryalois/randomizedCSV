using System.IO;
using System.Text.RegularExpressions;

String filename = "C:/test/users-" + Regex.Replace( ""+DateTime.Now, "[:.]", "_") + ".csv";

String[] names = ["Ania", "Kasia", "Basia", "Zosia"];
String[] surnames = ["Kowalska", "Nowak"];

try
{
    StreamWriter writer = new StreamWriter(filename);
    Random r = new Random();

    writer.WriteLine("LP,Imie,Nazwisko,Rok Urodzenia");

    for (int i = 0; i < 100; i++)
    {
        writer.WriteLine(i + "," + names[r.Next(4)] + "," + surnames[r.Next(2)] + "," + r.Next(1990, 2001));
    }
    writer.Flush();
}
catch(Exception e)
{
    Console.WriteLine(e);
}