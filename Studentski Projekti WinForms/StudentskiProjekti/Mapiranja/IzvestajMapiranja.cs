namespace StudentskiProjekti.Mapiranja;
public class IzvestajMapiranja : ClassMap<Izvestaj>
{
    public IzvestajMapiranja()
    {
        Table("IZVESTAJ");

        Id(x => x.Id, "ID").GeneratedBy.SequenceIdentity("IZVESTAJ_ID_SEQ");
        Map(x => x.Opis, "OPIS");
        Map(x => x.DatumPredaje, "DATUM_PREDAJE");

        HasMany(x => x.PredaoIzvestaji).KeyColumn("IZVESTAJ_ID").Cascade.All().Inverse();
    }
}
