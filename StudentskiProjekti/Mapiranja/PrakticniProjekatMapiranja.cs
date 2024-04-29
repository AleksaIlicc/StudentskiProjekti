namespace StudentskiProjekti.Mapiranja;
public class PrakticniProjekatMapiranja : SubclassMap<PrakticniProjekat>
{
    public PrakticniProjekatMapiranja()
    {
        Table("PRAKTICNI_PROJEKAT");

        KeyColumn("ID");

        Map(x => x.KratakOpis, "KRATAK_OPIS");
        Map(x => x.PreporuceniProgramskiJezik, "PREPORUCENI_PROGRAMSKI_JEZIK");

		HasMany(x => x.PreporuceneWebStranice).KeyColumn("PPROJ_ID").Cascade.All().Inverse();
	}
}
