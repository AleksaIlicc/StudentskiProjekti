

namespace StudentskiProjekti.Mapiranja
{
    public abstract class ProjekatMapiranja : ClassMap<Projekat>
    {
        public ProjekatMapiranja()
        {
            Table("PROJEKAT");

            Id(x => x.Id, "ID");
            Map(x => x.TipProjekta, "TIP_PROJEKTA");
            Map(x => x.Naziv, "NAZIV");
            Map(x => x.SkolskaGodinaZadavanja, "SKOLSKA_GODINA_ZADAVANJA");

            References(x => x.PripadaPredmetu).Column("S_PREDMETA").LazyLoad();
        }
    }
}
