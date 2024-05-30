namespace Library.DTOs;
public class AutorView
{
	public string? Autor { get; set; }

	internal AutorView(LitAutor a)
	{
		Autor = a.Autor;
	}

	public AutorView() { }
}
