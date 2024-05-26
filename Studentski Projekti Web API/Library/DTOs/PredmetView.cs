namespace Library.DTOs;
public class PredmetView
{
	public string? Id { get; set; }
	public string? Naziv { get; set; }
	public int? Semestar { get; set; }
	public string? Katedra { get; set; }

	internal PredmetView(Predmet p)
	{
		Id = p.Id;
		Naziv = p.Naziv;
		Semestar = p.Semestar;
		Katedra = p.Katedra;
	}

	public PredmetView()
	{

	}
}