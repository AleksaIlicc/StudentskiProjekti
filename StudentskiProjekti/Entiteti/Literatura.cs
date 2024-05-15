namespace StudentskiProjekti.Entiteti;
public class Literatura
{
    public virtual int LitId { get; protected set; }
    public virtual required string Naziv { get; set; }

	public virtual IList<LitAutor> Autori { get; set; }
	public virtual IList<Sadrzi> PripadaProjektu { get; set; }
	public virtual IList<Knjiga> Knjige { get; set; }
	public virtual IList<ClanakUCasopisu> ClanciUCasopisu { get; set; }
	public virtual IList<Rad> Radovi { get; set; }

	public Literatura()
    {
		Autori = new List<LitAutor>();
		Knjige = new List<Knjiga>();
		ClanciUCasopisu = new List<ClanakUCasopisu>();
		Radovi = new List<Rad>();
		PripadaProjektu = new List<Sadrzi>();
	}
}
