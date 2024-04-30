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

