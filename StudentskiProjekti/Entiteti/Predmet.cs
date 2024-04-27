namespace StudentskiProjekti.Entiteti;
public class Predmet
{
    public required virtual string Id { get; set; }
    public required virtual string Naziv { get; set; }
    public required virtual int Semestar { get; set; }
    public virtual string Katedra { get; set; }

    public virtual IList<Projekat> Projekti { get; set; }

	public Predmet() 
    { 
        Projekti = new List<Projekat>();
    }
}

