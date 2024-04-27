namespace StudentskiProjekti.Mapiranja;
public class TeorijskiProjekatMapiranja : SubclassMap<TeorijskiProjekat>
{
    public TeorijskiProjekatMapiranja()
    {
        Table("TEORIJSKI_PROJEKAT");

		DiscriminatorValue("teorijski");

        Map(x => x.MaksBrojStrana, "MAKS_BROJ_STRANA");
    }
}
