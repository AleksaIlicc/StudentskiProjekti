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
        public int Id { get; set; }
        public string TipProjekta { get; set; }
        public string Naziv { get; set; }
        public string SkolskaGodinaZadavanja { get; set; }
        public string VrstaProjekta { get; set; }
        public PredmetPregled PripadaPredmetu { get; set; }

        public ProjekatPregled(int id, string naziv, string skolskaGodinaZadavanja, string tipProjekta, string vrstaProjekta)
        {
            this.Id = id;
            this.TipProjekta = tipProjekta;
            this.Naziv = naziv;
            this.SkolskaGodinaZadavanja = skolskaGodinaZadavanja;
            this.VrstaProjekta = vrstaProjekta;
        }
        public ProjekatPregled(int id, string naziv, string skolskaGodinaZadavanja, string tipProjekta)
        {
            this.Id = id;
            this.TipProjekta = tipProjekta;
            this.Naziv = naziv;
            this.SkolskaGodinaZadavanja = skolskaGodinaZadavanja;
        }
        public ProjekatPregled()
        {
        }
    }
    public class ProjekatUcesceDetalji
    {
        public int Id { get; set; }
        public string NazivProjekta { get; set; }
        public DateTime DatumPocetkaIzrade { get; set; }
        public DateTime? DatumZavrsetkaIzrade { get; set; }
        public DateTime RokZaZavrsetak { get; set; }
        public string ProjekatZavrsen { get; set; }
        public string VrstaProjekta { get; set; }
        public string NazivPredmeta {  get; set; }
    }
    #endregion

    #region TeorijskiProjekat

    public class TeorijskiProjekatPregled : ProjekatPregled
    {
        public int MaksBrojStrana { get; set; }

        public TeorijskiProjekatPregled(int id, string naziv, string skolskaGodinaZadavanja, string tipProjekta, int maksBrojStrana) : base(id, naziv, skolskaGodinaZadavanja, tipProjekta)
        {
            base.VrstaProjekta = "teorijski";
            MaksBrojStrana = maksBrojStrana;
        }

        public TeorijskiProjekatPregled() : base() { }


    }

    #region Literatura

    public class LiteraturaPregled 
    {
        public int Id { get; set; }
        public string Naziv { get; set; }

        public LiteraturaPregled(string naziv)
        { 
            this.Naziv = naziv;
        }
        public LiteraturaPregled() { }
	}

	#region Autor

    public class AutorPregled
    {
		public string Autor { get; set; }

        public AutorPregled(string autor)
        {
            this.Autor = autor;
        }
	}

	#endregion

	#region Rad

	public class RadPregled : LiteraturaPregled
    {
        public int Id { get; set; }
		public string Url { get; set; }
		public string KonferencijaObjavljivanja { get; set; }
		public string Format { get; set; }

        public RadPregled(int id, string naziv, string url, string konferencijaObjavljivanja, string format) : base(naziv)
		{
            this.Id = id;
            this.Url = url;
            this.Naziv = naziv;
            this.KonferencijaObjavljivanja = konferencijaObjavljivanja;
            this.Format = format;
		}

        public RadPregled() { }
    }

    #endregion

    #region ClanakUCasopisu

    public class ClanakUCasopisuPregled : LiteraturaPregled
    {
        public string ISSN { get; set; }
        public string ImeCasopisa { get; set; }
        public int Broj { get; set; }
        public int Godina { get; set; }

        public ClanakUCasopisuPregled(string naziv, string issn , string imeCasopisa, int Broj, int godina) : base(naziv)
        {
            this.Naziv= naziv;
            this.ImeCasopisa = imeCasopisa;
            this.ISSN = issn;
            this.Broj = Broj;
            this.Godina = godina;
        }
        public ClanakUCasopisuPregled() { }
    }

    #endregion

    #region Knjiga

    public class KnjigaPregled : LiteraturaPregled
    {
        public string ISBN { get; set; }
        public string Izdavac { get; set; }
        public int GodinaIzdanja { get; set; }

        public KnjigaPregled(string naziv, string isbn , string izdavac, int godinaizdanja): base(naziv)
        {
            this.ISBN= isbn;
            this.Izdavac= izdavac;
            this.GodinaIzdanja = godinaizdanja;
        }

        public KnjigaPregled() { }
    }

    #endregion

    #endregion

    #endregion

    #region PrakticniProjekat
    public class PrakticniProjekatPregled : ProjekatPregled
    {
        public string KratakOpis { get; set; }
        public string PreporuceniProgramskiJezik { get; set; }

        public PrakticniProjekatPregled(int id, string naziv, string skolskaGodinaZadavanja, string tipProjekta, string preporuceniProgramskiJezik) : base(id, naziv, skolskaGodinaZadavanja, tipProjekta)
        {
            PreporuceniProgramskiJezik = preporuceniProgramskiJezik;
        }
        public PrakticniProjekatPregled() : base() { }
    }

    public class PreporucenaWebStranicaPregled
    {
        public string Naziv { get; set; }
        public PreporucenaWebStranicaPregled(string naziv)
        {
            this.Naziv = naziv;
        }
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

    #region Izvestaj
    public class IzvestajPregled
    {

        public int Id { get; set; }
        public DateTime DatumPredaje { get; set; }
        public string Opis { get; set; }

        public IzvestajPregled(DateTime datumPredmeta, string opis)
        {
            Opis = opis;
            DatumPredaje = datumPredmeta;
        }
        public IzvestajPregled() { }
    }

    #endregion
}

