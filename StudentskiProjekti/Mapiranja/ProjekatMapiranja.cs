

namespace StudentskiProjekti.Mapiranja
{
    public abstract class ProjekatMapiranja : ClassMap<Projekat>
    {
        public ProjekatMapiranja()
        {
            Table("PROJEKAT");

            // TO DO, DODATI SEKVENCU ZA GENERISANJE PK
            Id(x => x.Id, "ID");
            Map(x => x.TipProjekta, "TIP_PROJEKTA");
            Map(x => x.Naziv, "NAZIV");
            Map(x => x.SkolskaGodinaZadavanja, "SKOLSKA_GODINA_ZADAVANJA");

            References(x => x.PripadaPredmetu).Column("S_PREDMETA").LazyLoad();
			HasMany(x => x.UcestvujeStudenti).KeyColumn("PROJEKAT_ID").Cascade.All().Inverse();
		}
	}
}
