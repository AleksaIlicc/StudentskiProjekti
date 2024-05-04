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
        public int Id { get; protected set; }
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

}

