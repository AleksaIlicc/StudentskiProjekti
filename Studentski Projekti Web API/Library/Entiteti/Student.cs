namespace Library.Entiteti;
internal class Student
{
    internal protected required virtual string BrIndeksa { get; set; }
    internal protected required virtual string LIme { get; set; }
    internal protected virtual string? ImeRoditelja { get; set; }
    internal protected required virtual string Prezime { get; set; }
    internal protected virtual string? Smer { get; set; }

    internal protected virtual IList<Ucestvuje>? UcestvujeProjekti { get; set; }
    internal protected virtual IList<Predao>? PredaoIzvestaji { get; set; }

    internal Student()
    {
        UcestvujeProjekti = new List<Ucestvuje>();
        PredaoIzvestaji = new List<Predao>();
	}
}

