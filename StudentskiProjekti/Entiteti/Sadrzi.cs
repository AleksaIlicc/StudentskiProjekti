namespace StudentskiProjekti.Entiteti;
public class Sadrzi
{
	public virtual int Id { get; protected set; }

	public required virtual TeorijskiProjekat TProjekat { get; set; }
	public required virtual Literatura Literatura { get; set; }

	public Sadrzi()
	{

	}
}
