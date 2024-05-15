namespace StudentskiProjekti.Entiteti;
public class LitAutor
{
	public virtual int Id { get; set; }
	public virtual string Autor { get; set; }

	public virtual Literatura Literatura { get; set; }

	public LitAutor()
	{

	}
}
