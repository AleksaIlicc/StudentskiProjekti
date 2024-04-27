namespace StudentskiProjekti.Entiteti;

public class Student
{
    public required virtual string BrIndeksa { get; set; }
    public required virtual string LIme { get; set; }
    public virtual string ImeRoditelja { get; set; }
    public required virtual string Prezime { get; set; }
    public virtual string Smer { get; set; }

    public virtual IList<Ucestvuje> UcestvujeProjekti { get; set; }
    public virtual IList<Predao> PredaoIzvestaji { get; set; }

    public Student()
    {
        UcestvujeProjekti = new List<Ucestvuje>();
        PredaoIzvestaji = new List<Predao>();
	}
}

