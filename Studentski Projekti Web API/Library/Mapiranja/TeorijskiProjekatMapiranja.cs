namespace Library.Mapiranja;
internal class TeorijskiProjekatMapiranja : SubclassMap<TeorijskiProjekat>
{
    public TeorijskiProjekatMapiranja()
    {
        Table("TEORIJSKI_PROJEKAT");

		KeyColumn("ID");

		Map(x => x.MaksBrojStrana, "MAKS_BROJ_STRANA");

        HasMany(p => p.PreporucenaLiteratura).KeyColumn("TPROJ_ID").Cascade.All().Inverse();
    }
}
