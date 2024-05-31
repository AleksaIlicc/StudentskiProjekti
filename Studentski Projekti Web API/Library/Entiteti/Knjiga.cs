namespace Library.Entiteti;
internal class Knjiga
{
    internal protected virtual required string ISBN { get; set; }
    internal protected virtual string? Izdavac { get; set; }
    internal protected virtual int? GodinaIzdanja { get; set; }
    internal protected virtual required Literatura Literatura { get; set; }

    internal Knjiga()
    {

    }
}
