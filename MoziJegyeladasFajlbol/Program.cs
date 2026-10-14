using MoziJegyeladasFajlbol;
string[] sorok = File.ReadAllLines("filmek.txt");
List<Cim> filmek = new List<Cim>();
foreach (string beolvasott in File.ReadAllLines("filmek.txt"))
{
    string[] vagas = beolvasott.Split(";");
    Cim aktualis = new Cim();
    aktualis.Cim = aktualis[vagas];
    aktualis.Eladott = int.Parse(vagas[1]);
    aktualis.Ar = int.Parse(vagas[2]);
    filmek.Add(aktualis);
}