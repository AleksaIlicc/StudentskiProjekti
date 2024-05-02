namespace StudentskiProjekti;

public class DTOs
{
    #region Predmet

    public class PredmetPregled
    {
        public string Id { get; set; }
        public string Naziv { get; set; }
        public int Semestar { get; set; }
        public string Katedra { get; set; }

        public PredmetPregled(string id, string naziv, int semestar, string katedra)
        {
            this.Id = id;
            this.Naziv = naziv;
            this.Semestar = semestar;
            this.Katedra = katedra;
        }

        public PredmetPregled()
        {

        }
    }
    #endregion

    #region Projekat
    public class ProjekatPregled
    {
        public int Id { get; protected set;}
        public string TipProjekta { get; set; }
        public string Naziv { get; set; }
        public string SkolskaGodinaZadavanja { get; set; }
        public string VrstaProjekta { get; set; }
        public Predmet PripadaPredmetu { get; set; }
        public ProjekatPregled(int id, string naziv, string skolskaGodinaZadavanja, string vrstaProjekta, string tipProjekta, Predmet predmet)
        {
            this.Id = id;
            this.TipProjekta = tipProjekta;
            this.Naziv = naziv;
            this.SkolskaGodinaZadavanja = skolskaGodinaZadavanja;
            this.VrstaProjekta = vrstaProjekta;
            this.PripadaPredmetu = predmet;
        }
        public ProjekatPregled(int id, string naziv, string skolskaGodinaZadavanja, string vrstaProjekta, string tipProjekta)
        {
            this.Id = id;
            this.TipProjekta = tipProjekta;
            this.Naziv = naziv;
            this.SkolskaGodinaZadavanja = skolskaGodinaZadavanja;
            this.VrstaProjekta = vrstaProjekta;
        }
        public ProjekatPregled(int id ,string naziv, string skolskaGodinaZadavanja, string tipProjekta)
        {
            this.Id= id;
            this.TipProjekta = tipProjekta;
            this.Naziv = naziv;
            this.SkolskaGodinaZadavanja = skolskaGodinaZadavanja;
        }
        public ProjekatPregled()
        {
        }
    }
    #endregion

    #region TeorijskiProjekat
    public class TeorijskiProjekatPregled : ProjekatPregled
    {
        public virtual int MaksBrojStrana { get; set; }



        public TeorijskiProjekatPregled(int id, string naziv, string skolskaGodinaZadavanja, string vrstaProjekta, string tipProjekta, int maksBrojStrana, Predmet predmet) : base(id ,naziv, skolskaGodinaZadavanja, vrstaProjekta, tipProjekta, predmet)
        {
            MaksBrojStrana = maksBrojStrana;
        }

        public TeorijskiProjekatPregled(int id, string naziv, string skolskaGodinaZadavanja, string tipProjekta, int maksBrojStrana) : base(id ,naziv, skolskaGodinaZadavanja, tipProjekta)
        {
            MaksBrojStrana = maksBrojStrana;
        }
        public TeorijskiProjekatPregled() : base() { }
    }
    #endregion

    #region PrakticniProjekat
    public class PrakticniProjekatPregled : ProjekatPregled
    {
        public virtual string KratakOpis { get; set; }
        public virtual string PreporuceniProgramskiJezik { get; set; }
        public virtual IList<PProjektiWebStranice> PreporuceneWebStranice { get; set; }

        public PrakticniProjekatPregled(int id, string naziv, string skolskaGodinaZadavanja, string vrstaProjekta, string tipProjekta, string kratakOpis, string preporuceniProgramskiJezik, IList<PProjektiWebStranice> preporuceneWebStranice , Predmet predmet) : base(id, naziv, skolskaGodinaZadavanja, vrstaProjekta, tipProjekta, predmet)
        {
            KratakOpis = kratakOpis;
            PreporuceniProgramskiJezik = preporuceniProgramskiJezik;
            PreporuceneWebStranice = preporuceneWebStranice;
        }

        public PrakticniProjekatPregled(int id, string naziv, string skolskaGodinaZadavanja, string tipProjekta, string preporuceniProgramskiJezik) : base(id, naziv, skolskaGodinaZadavanja, tipProjekta)
        {
            PreporuceniProgramskiJezik = preporuceniProgramskiJezik;
        }
        public PrakticniProjekatPregled() : base() { }
    }
    #endregion

	#region Student

	public class StudentPregled
	{
		public string BrIndeksa { get; set; }
		public string LIme { get; set; }
		public string ImeRoditelja { get; set; }
		public string Prezime { get; set; }
		public string Smer { get; set; }

		public StudentPregled(string brIndeksa, string ime, string imeRoditelja, string prezime, string smer)
		{
			this.BrIndeksa = brIndeksa;
			this.LIme = ime;
			this.ImeRoditelja = imeRoditelja;
			this.Prezime = prezime;
			this.Smer = smer;
		}

		public StudentPregled()
		{

		}
	}

	#endregion
}

