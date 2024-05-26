namespace Library.Entiteti;

internal class Literatura
{
    internal protected virtual int LitId { get; protected set; }
    internal protected virtual required string Naziv { get; set; }

    internal protected virtual Knjiga Knjiga { get; set; }
    internal protected virtual Rad Rad { get; set; }
    internal protected virtual ClanakUCasopisu ClanakUCasopisu { get; set; }

    internal protected virtual IList<LitAutor> Autori { get; set; }
    internal protected virtual IList<Sadrzi> PripadaProjektu { get; set; }

    internal Literatura()
    {
        Autori = new List<LitAutor>();
        PripadaProjektu = new List<Sadrzi>();
    }
}
