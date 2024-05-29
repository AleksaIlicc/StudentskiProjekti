namespace Library.DTOs;
public class PrakticniProjekatView : ProjekatView
{
    public string? KratakOpis { get; set; }
    public string? PreporuceniProgramskiJezik { get; set; }

    internal PrakticniProjekatView(PrakticniProjekat p) : base(p)
    {
        base.VrstaProjekta = "prakticni";
        PreporuceniProgramskiJezik = p.PreporuceniProgramskiJezik;
        KratakOpis = p.KratakOpis;
    }
    public PrakticniProjekatView() : base() { }
}
