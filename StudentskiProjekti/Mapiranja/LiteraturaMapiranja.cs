namespace StudentskiProjekti.Mapiranja;
public class LiteraturaMapiranja : ClassMap<Literatura>
{
    public LiteraturaMapiranja()
    {
        Table("LITERATURA");

        Id(x => x.Id, "LIT_ID").GeneratedBy.SequenceIdentity("LITERATURA_ID_SEQ");
        Map(x => x.Naziv, "NAZIV");

		HasMany(x => x.Radovi).KeyColumn("LIT_ID").Cascade.All().Inverse();
		HasMany(x => x.ClanciUCasopisu).KeyColumn("LIT_ID").Cascade.All().Inverse();
		HasMany(x => x.Knjige).KeyColumn("LIT_ID").Cascade.All().Inverse();
	}
}
