namespace StudentskiProjekti.Entiteti;
public class Predao
{
    public virtual int Id { get; protected set; }
	public virtual int? BrojIzvestaja { get; set; }

	public required virtual Student Student { get; set; }
	public required virtual Projekat Projekat { get; set; }
	public required virtual Izvestaj Izvestaj { get; set; }

	public Predao()
	{

	}
}

