namespace Library.DTOs;
public class TeorijskiProjekatView : ProjekatView
{
	public int? MaksBrojStrana { get; set; }

	internal TeorijskiProjekatView(TeorijskiProjekat tp) : base(tp)
	{
		base.VrstaProjekta = "teorijski";
		MaksBrojStrana = tp.MaksBrojStrana;
	}

	public TeorijskiProjekatView() : base() { }
}
