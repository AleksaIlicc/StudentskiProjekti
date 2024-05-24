namespace StudentskiProjekti.Entiteti;
public class PrakticniProjekat : Projekat
{
    public virtual string KratakOpis { get; set; }
    public virtual string PreporuceniProgramskiJezik { get; set; }
	public virtual IList<PProjektiWebStranice> PreporuceneWebStranice { get; set; }

	public PrakticniProjekat()
	{
		PreporuceneWebStranice = new List<PProjektiWebStranice>();
	}
}
