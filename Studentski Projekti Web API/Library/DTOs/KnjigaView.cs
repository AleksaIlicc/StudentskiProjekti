namespace Library.DTOs;

public class KnjigaView : LiteraturaView
{
	public string? ISBN { get; set; }
	public string? Izdavac { get; set; }
	public int? GodinaIzdanja { get; set; }

	internal KnjigaView(Knjiga k) : base(k.Literatura)
	{
		this.ISBN = k.ISBN;
		this.Izdavac = k.Izdavac;
		this.GodinaIzdanja = k.GodinaIzdanja;
	}

	public KnjigaView() { }
}