namespace StudentskiProjekti.Entiteti;
public class Knjiga
{
    public virtual required string ISBN { get; set; }
    public virtual string Izdavac { get; set; }
    public virtual int GodinaIzdanja { get; set; }
	public virtual required Literatura Literatura { get; set; }

	public Knjiga()
    {

    }
}
