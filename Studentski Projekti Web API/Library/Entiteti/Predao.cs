namespace Library.Entiteti;
internal class Predao
{
    internal protected virtual int Id { get; protected set; }
    internal protected virtual int? BrojIzvestaja { get; set; }

    internal protected virtual Projekat? Projekat { get; set; }
    internal protected virtual Izvestaj? Izvestaj { get; set; }
    internal protected virtual Student? Student { get; set; }

    internal Predao()
    {
    }
}
