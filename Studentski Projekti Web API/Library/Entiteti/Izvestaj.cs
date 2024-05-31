namespace Library.Entiteti;
internal class Izvestaj
{
    internal protected virtual int Id { get; protected set; }
    internal protected required virtual string Opis { get; set; }
    internal protected required virtual DateTime DatumPredaje { get; set; }

    internal protected virtual Predao? PredaoIzvestaj { get; set; }

    internal Izvestaj()
    {
    }
}
