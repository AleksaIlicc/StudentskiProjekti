namespace StudentskiProjekti.Entiteti;
public class TeorijskiProjekat : Projekat
{
    public virtual int MaksBrojStrana { get; set; }

    public virtual IList<Sadrzi> PreporucenaLiteratura { get; set; }

    public TeorijskiProjekat()
    {
        PreporucenaLiteratura = new List<Sadrzi>();
    }
}
