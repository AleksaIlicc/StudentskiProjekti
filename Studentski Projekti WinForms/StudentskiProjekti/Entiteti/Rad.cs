namespace StudentskiProjekti.Entiteti;
public class Rad
{
    public virtual int Id { get; protected set; }
    public virtual string Url { get; set; }
    public virtual string KonferencijaObjavljivanja { get; set; }
    public virtual string Format { get; set; }
    public virtual required Literatura Literatura { get; set; }

    public Rad()
    {

    }
}
