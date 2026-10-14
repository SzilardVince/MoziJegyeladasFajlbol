using MoziJegyeladasFajlbol;
string[] sorok = File.ReadAllLines("filmek.txt");
List<Film> filmek = new List<Film>();
foreach (string beolvasott in File.ReadAllLines("filmek.txt"))
{
    string[] vagas = beolvasott.Split(";");
    Film aktualis = new Film();
    aktualis.Cim = vagas[0];
    aktualis.Eladott = int.Parse(vagas[1]);
    aktualis.Ar = int.Parse(vagas[2]);
    filmek.Add(aktualis);
}