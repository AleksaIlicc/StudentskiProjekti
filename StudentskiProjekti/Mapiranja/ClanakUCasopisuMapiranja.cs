namespace StudentskiProjekti.Mapiranja;
public class ClanakUCasopisuMapiranja : ClassMap<ClanakUCasopisu>
{
    public ClanakUCasopisuMapiranja()
    {
        Table("CLANAK_U_CASOPISU");

        Id(x => x.ISSN, "ISSN").GeneratedBy.Assigned();
        Map(x => x.ImeCasopisa, "IME_CASOPISA");
        Map(x => x.Broj, "BROJ");
        Map(x => x.Godina, "GODINA");

		References(x => x.Literatura).Column("LIT_ID");
	}
}
