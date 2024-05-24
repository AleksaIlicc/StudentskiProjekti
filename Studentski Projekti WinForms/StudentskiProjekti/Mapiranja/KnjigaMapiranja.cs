namespace StudentskiProjekti.Mapiranja;

public class KnjigaMapiranja : ClassMap<Knjiga>
{
    public KnjigaMapiranja()
    {
        Table("KNJIGA");

        Id(x => x.ISBN, "ISBN").GeneratedBy.Assigned();
        Map(x => x.Izdavac, "IZDAVAC");
        Map(x => x.GodinaIzdanja, "GODINA_IZDANJA");

        References(x => x.Literatura).Column("LIT_ID").Unique();
    }
}
