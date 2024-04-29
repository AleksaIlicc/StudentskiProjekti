namespace StudentskiProjekti.Entiteti;

public abstract class Projekat
{
    public virtual int Id { get; protected set; }   
    public required virtual string TipProjekta { get; set; }
    public required virtual string Naziv { get; set; }
    public required virtual string SkolskaGodinaZadavanja { get; set; }
	public required virtual string VrstaProjekta { get; set; }

	public required virtual Predmet PripadaPredmetu { get; set; }
	public virtual IList<Ucestvuje> UcestvujeStudenti { get; set; }
    public virtual IList<Predao> PredaoIzvestaji { get; set; }

	public Projekat() 
    {
		UcestvujeStudenti = new List<Ucestvuje>();
        PredaoIzvestaji = new List<Predao>();
	}
}

