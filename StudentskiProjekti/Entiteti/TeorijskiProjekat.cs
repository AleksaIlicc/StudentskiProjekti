namespace StudentskiProjekti.Entiteti;
public class TeorijskiProjekat : Projekat
{
    public virtual int MaksBrojStrana { get; set; }

    public virtual IList<Literatura> PreporucenaLiteratura { get; set; }

    public TeorijskiProjekat()
    {
        PreporucenaLiteratura = new List<Literatura>();
    }
}
