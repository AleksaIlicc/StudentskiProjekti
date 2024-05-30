namespace Library.DTOs;
public class StudentiView
{
    public string? BrIndeksa { get; set; }
    public string? LIme { get; set; }
    public string? ImeRoditelja { get; set; }
    public string? Prezime { get; set; }
    public string? Smer { get; set; }

    internal StudentiView(Student s)
    {
        this.BrIndeksa = s.BrIndeksa;
        this.LIme = s.LIme;
        this.ImeRoditelja = s.ImeRoditelja;
        this.Prezime = s.Prezime;
        this.Smer = s.Smer;
    }

    public StudentiView()
    {
    }
}