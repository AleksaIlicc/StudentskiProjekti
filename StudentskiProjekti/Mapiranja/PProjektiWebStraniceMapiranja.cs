namespace StudentskiProjekti.Entiteti;
public class PProjektiWebStraniceMapiranja : ClassMap<PProjektiWebStranice>
{
    public PProjektiWebStraniceMapiranja()
    {
		Table("PPROJ_PREP_WEB");

		Id(x => x.Id).GeneratedBy.SequenceIdentity("PPROJ_PREP_WEB_ID_SEQ");

		Map(x => x.PreporucenaWebStrana, "PREP_WEB_STRANA");

		References(x => x.PProjekat).Column("PPROJ_ID");
	}
}
