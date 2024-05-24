namespace StudentskiProjekti.Entiteti;
public class ClanakUCasopisu
{
    public virtual required string ISSN { get; set; }
    public virtual required string ImeCasopisa { get; set; }
    public virtual int Broj { get; set; }
    public virtual int Godina { get; set; }
    public virtual required Literatura Literatura { get; set; }

    public ClanakUCasopisu()
    {

    }
}
