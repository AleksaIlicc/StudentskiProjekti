namespace StudentskiProjekti.Mapiranja;
public class RadMapiranja : ClassMap<Rad>
{
    public RadMapiranja()
    {
        Table("RAD");

        Id(x => x.Id, "ID").GeneratedBy.SequenceIdentity("RAD_ID_SEQ");
        Map(x => x.Url, "URL");
        Map(x => x.KonferencijaObjavljivanja, "KONFERENCIJA_OBJAVLJIVANJA");
        Map(x => x.Format, "FORMAT");

		References(x => x.Literatura).Column("LIT_ID");
	}
}
