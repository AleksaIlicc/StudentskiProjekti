namespace StudentskiProjekti.Mapiranja;
public class ProjekatMapiranja : ClassMap<Projekat>
{
    public ProjekatMapiranja()
    {
        Table("PROJEKAT");

        Id(x => x.Id, "ID").GeneratedBy.SequenceIdentity("PROJEKAT_ID_SEQ");

        Map(x => x.TipProjekta, "TIP_PROJEKTA");
		Map(x => x.VrstaProjekta, "VRSTA_PROJEKTA");
		Map(x => x.Naziv, "NAZIV");
        Map(x => x.SkolskaGodinaZadavanja, "SKOLSKA_GODINA_ZADAVANJA");

        References(x => x.PripadaPredmetu).Column("S_PREDMETA").LazyLoad();
        HasMany(x => x.UcestvujeStudenti).KeyColumn("PROJEKAT_ID").Cascade.All().Inverse();
        HasMany(x => x.PredaoIzvestaji).KeyColumn("PROJEKAT_ID").Cascade.All().Inverse();
    }
}