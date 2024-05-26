namespace Library.Mapiranja;

internal class LiteraturaMapiranja : ClassMap<Literatura>
{
    public LiteraturaMapiranja()
    {
        Table("LITERATURA");

        Id(x => x.LitId, "LIT_ID").GeneratedBy.SequenceIdentity("LITERATURA_ID_SEQ");
        Map(x => x.Naziv, "NAZIV");

        HasOne(x => x.Knjiga).PropertyRef(x => x.Literatura).Cascade.All();
        HasOne(x => x.Rad).PropertyRef(x => x.Literatura).Cascade.All();
        HasOne(x => x.ClanakUCasopisu).PropertyRef(x => x.Literatura).Cascade.All();

        HasMany(x => x.PripadaProjektu).KeyColumn("LIT_ID").Cascade.All().Inverse();
        HasMany(x => x.Autori).KeyColumn("LIT_ID").Cascade.All().Inverse();
    }
}
