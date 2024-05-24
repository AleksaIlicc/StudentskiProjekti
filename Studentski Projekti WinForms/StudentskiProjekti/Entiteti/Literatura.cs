namespace StudentskiProjekti.Entiteti;

public class Literatura
{
    public virtual int LitId { get; protected set; }
    public virtual required string Naziv { get; set; }

    public virtual Knjiga Knjiga { get; set; }
    public virtual Rad Rad { get; set; }
    public virtual ClanakUCasopisu ClanakUCasopisu { get; set; }

    public virtual IList<LitAutor> Autori { get; set; }
    public virtual IList<Sadrzi> PripadaProjektu { get; set; }

    public Literatura()
    {
        Autori = new List<LitAutor>();
        PripadaProjektu = new List<Sadrzi>();
    }
}
