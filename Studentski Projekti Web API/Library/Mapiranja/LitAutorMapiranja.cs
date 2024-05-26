namespace Library.Mapiranja;
internal class LitAutorMapiranja : ClassMap<LitAutor>
{
	public LitAutorMapiranja()
	{
		Table("LIT_AUTOR");

		Id(x => x.Id).GeneratedBy.SequenceIdentity("LIT_AUTOR_ID_SEQ");
		Map(x => x.Autor, "AUTOR");

		References(x => x.Literatura).Column("LIT_ID");
	}
}
