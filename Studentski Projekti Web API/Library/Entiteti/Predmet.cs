namespace Library.Entiteti;
internal class Predmet
{
    internal protected required virtual string Id { get; set; }
    internal protected required virtual string Naziv { get; set; }
    internal protected required virtual int Semestar { get; set; }
    internal protected virtual string? Katedra { get; set; }

    internal protected virtual IList<Projekat>? Projekti { get; set; }

    internal Predmet()
    {
        Projekti = new List<Projekat>();
    }
}

