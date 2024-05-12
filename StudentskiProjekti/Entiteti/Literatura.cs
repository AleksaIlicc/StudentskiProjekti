namespace StudentskiProjekti.Entiteti;
public abstract class Literatura
{
    public virtual string Id { get; protected set; }
    public virtual required string Naziv { get; set; }
	public virtual IList<Knjiga> Knjige { get; set; }
	public virtual IList<ClanakUCasopisu> ClanciUCasopisu { get; set; }
	public virtual IList<Rad> Radovi { get; set; }

	public Literatura()
    {
		Knjige = new List<Knjiga>();
		ClanciUCasopisu = new List<ClanakUCasopisu>();
		Radovi = new List<Rad>();
	}
}
