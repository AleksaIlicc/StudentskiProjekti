namespace StudentskiProjekti
{
    public class DTOs
    {
        #region Predmet

        public class PredmetPregled
        {
            public string Id { get; set; }
            public string Naziv { get; set; }
            public int? Semestar { get; set; }
            public string? Katedra { get; set; }

            public PredmetPregled(string id, string naziv, int? semestar, string? katedra)
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
    }
}
