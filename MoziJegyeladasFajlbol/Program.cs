using MoziJegyeladasFajlbol;
string[] sorok = File.ReadAllLines("filmek.txt");
Console.ForegroundColor = ConsoleColor.DarkBlue;
List<Film> filmek = new List<Film>();
bool h = true;
int u = 0;
int x = 0;
List<int> y = new List<int>();
foreach (string beolvasott in File.ReadAllLines("filmek.txt"))
{
    if (h)
    {
        h = false;
    }
    else
    {

    string[] vagas = beolvasott.Split(";");
    Film aktualis = new Film();
    aktualis.Cim = vagas[0];
    aktualis.Eladott = int.Parse(vagas[1]);
    aktualis.Ar = int.Parse(vagas[2]);
    u += (aktualis.Ar * aktualis.Eladott);
        x += aktualis.Eladott;
        y.Add(aktualis.Eladott);
    filmek.Add(aktualis);
    }
}
Console.WriteLine("========================================");
Console.WriteLine("Vetitett filmek és bevételek:");
foreach (Film aktualis in filmek)
{
    Console.WriteLine($"\t- {aktualis.Cim}: {aktualis.Eladott} db jegy -> Bevétel: {aktualis.Ar * aktualis.Eladott} Ft");
}
Console.WriteLine("----------------------------------------");
Console.WriteLine($"Összes eladott jegy: {x} db");
Console.WriteLine($"Összes bevétel: {u} Ft"); 
Console.WriteLine($"átlagos eladott db: {y.Average():F0} db");
Console.WriteLine("========================================");
Console.ForegroundColor = ConsoleColor.Black;