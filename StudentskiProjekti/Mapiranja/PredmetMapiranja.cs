namespace StudentskiProjekti.Mapiranja
{
    public class PredmetMapiranja: ClassMap<Predmet>
    {
        public PredmetMapiranja()
        {
            Table("PREDMET");

            Id(x => x.Id, "SIFRA").GeneratedBy.Assigned();
            Map(x => x.Naziv, "NAZIV");
            Map(x => x.Semestar, "SEMESTAR");
            Map(x => x.Katedra, "KATEDRA");

            HasMany(x => x.Projekti).KeyColumn("S_PREDMETA").Cascade.All().Inverse();
        }

    }
}
