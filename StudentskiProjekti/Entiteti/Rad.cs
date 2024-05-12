namespace StudentskiProjekti.Entiteti;
public class Rad
{
    public virtual string Id { get; protected set; }
    public virtual string Url { get; set; }
    public virtual string KonferencijaObjavljivanja { get; set; }
    public virtual string Format { get; set; }
	public required Literatura Literatura { get; set; }

	public Rad()
    {

    }
}
