namespace Library.Entiteti;
internal class ClanakUCasopisu
{
    internal protected virtual required string ISSN { get; set; }
    internal protected virtual required string ImeCasopisa { get; set; }
    internal protected virtual int? Broj { get; set; }
    internal protected virtual int? Godina { get; set; }
    internal protected virtual required Literatura Literatura { get; set; }

    internal ClanakUCasopisu()
    {

    }
}
