namespace Library.DTOs;
public class ProjekatView
{
	public int? Id { get; set; }
	public string? TipProjekta { get; set; }
	public string? Naziv { get; set; }
	public string? SkolskaGodinaZadavanja { get; set; }
	public string? VrstaProjekta { get; set; }
	public PredmetView? PripadaPredmetu { get; set; }

	internal ProjekatView(Projekat p)
	{
		this.Id = p.Id;
		this.TipProjekta = p.TipProjekta;
		this.Naziv = p.Naziv;
		this.SkolskaGodinaZadavanja = p.SkolskaGodinaZadavanja;
		this.VrstaProjekta = p.VrstaProjekta;
		this.PripadaPredmetu = new PredmetView(p.PripadaPredmetu);
	}
	public ProjekatView()
	{
	}
}

