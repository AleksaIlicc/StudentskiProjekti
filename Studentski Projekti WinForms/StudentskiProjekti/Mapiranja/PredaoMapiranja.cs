namespace StudentskiProjekti.Mapiranja;
public class PredaoMapiranja : ClassMap<Predao>
{
    public PredaoMapiranja()
    {
        Table("PREDAO");

        Id(x => x.Id, "ID").GeneratedBy.SequenceIdentity("PREDAO_ID_SEQ");
        Map(x => x.BrojIzvestaja, "BROJ_IZVESTAJA");

        References(x => x.Projekat).Column("PROJEKAT_ID");
        References(x => x.Izvestaj).Column("IZVESTAJ_ID").Unique().Cascade.All();
        References(x => x.Student).Column("STUDENT_ID");
    }
}
