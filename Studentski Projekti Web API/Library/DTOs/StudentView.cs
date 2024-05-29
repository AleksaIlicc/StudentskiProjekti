namespace Library.DTOs;
public class StudentiView
{
    public string? BrIndeksa { get; set; }
    public string? LIme { get; set; }
    public string? ImeRoditelja { get; set; }
    public string? Prezime { get; set; }
    public string? Smer { get; set; }

    internal StudentiView(string brIndeksa, string ime, string imeRoditelja, string prezime, string smer)
    {
        this.BrIndeksa = brIndeksa;
        this.LIme = ime;
        this.ImeRoditelja = imeRoditelja;
        this.Prezime = prezime;
        this.Smer = smer;
    }

    public StudentiView()
    {
    }
}