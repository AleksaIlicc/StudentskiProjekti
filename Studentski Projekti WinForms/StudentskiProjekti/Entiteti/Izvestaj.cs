namespace StudentskiProjekti.Entiteti;
public class Izvestaj
{
    public virtual int Id { get; protected set; }
    public required virtual string Opis { get; set; }
    public required virtual DateTime DatumPredaje { get; set; }

    public virtual Predao PredaoIzvestaj { get; set; }

    public Izvestaj()
    {
    }
}
