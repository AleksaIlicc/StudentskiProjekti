namespace Library.Entiteti;
internal class PrakticniProjekat : Projekat
{
    internal protected virtual string? KratakOpis { get; set; }
    internal protected virtual string? PreporuceniProgramskiJezik { get; set; }
	internal protected virtual IList<PProjektiWebStranice>? PreporuceneWebStranice { get; set; }

	internal PrakticniProjekat()
	{
		PreporuceneWebStranice = new List<PProjektiWebStranice>();
	}
}
