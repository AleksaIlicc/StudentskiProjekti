namespace Library.Mapiranja;
internal class IzvestajMapiranja : ClassMap<Izvestaj>
{
    public IzvestajMapiranja()
    {
        Table("IZVESTAJ");

        Id(x => x.Id, "ID").GeneratedBy.SequenceIdentity("IZVESTAJ_ID_SEQ");
        Map(x => x.Opis, "OPIS");
        Map(x => x.DatumPredaje, "DATUM_PREDAJE");

        HasOne(x => x.PredaoIzvestaj).PropertyRef(x => x.Izvestaj).Cascade.All();
    }
}
