namespace StudentskiProjekti.Entiteti;
public class Knjiga
{
    public virtual string ISBN { get; set; }
    public virtual string Izdavac { get; set; }
    public virtual int GodinaIzdanja { get; set; }
	public required Literatura Literatura { get; set; }

	public Knjiga()
    {

    }
}
