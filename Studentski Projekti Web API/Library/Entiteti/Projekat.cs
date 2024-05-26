namespace Library.Entiteti;
internal abstract class Projekat
{
    internal protected virtual int Id { get; protected set; }
    internal protected required virtual string TipProjekta { get; set; }
    internal protected required virtual string Naziv { get; set; }
    internal protected required virtual string SkolskaGodinaZadavanja { get; set; }
    internal protected required virtual string VrstaProjekta { get; set; }

    internal protected required virtual Predmet PripadaPredmetu { get; set; }
    internal protected virtual IList<Ucestvuje> UcestvujeStudenti { get; set; }
    internal protected virtual IList<Predao> PredaoIzvestaji { get; set; }

    internal Projekat() 
    {
		UcestvujeStudenti = new List<Ucestvuje>();
        PredaoIzvestaji = new List<Predao>();
	}
}

