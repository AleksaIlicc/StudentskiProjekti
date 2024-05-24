namespace StudentskiProjekti.Entiteti;
public class Predao
{
    public virtual int Id { get; protected set; }
    public virtual int BrojIzvestaja { get; set; }

    public virtual Projekat Projekat { get; set; }
    public virtual Izvestaj Izvestaj { get; set; }
    public virtual Student Student { get; set; }

    public Predao()
    {
    }
}
