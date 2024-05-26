namespace Library.Mapiranja;
internal class SadrziMapiranja : ClassMap<Sadrzi>
{
	public SadrziMapiranja()
	{
		Table("SADRZI");

		Id(x => x.Id, "ID").GeneratedBy.SequenceIdentity("SADRZI_ID_SEQ");

		References(x => x.TProjekat).Column("TPROJ_ID");
		References(x => x.Literatura).Column("LIT_ID");
	}
}
