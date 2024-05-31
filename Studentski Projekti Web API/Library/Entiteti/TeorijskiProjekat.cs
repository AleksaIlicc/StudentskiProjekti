namespace Library.Entiteti;
internal class TeorijskiProjekat : Projekat
{
    internal protected virtual int? MaksBrojStrana { get; set; }

    internal protected virtual IList<Sadrzi>? PreporucenaLiteratura { get; set; }

    internal TeorijskiProjekat()
    {
        PreporucenaLiteratura = new List<Sadrzi>();
    }
}
