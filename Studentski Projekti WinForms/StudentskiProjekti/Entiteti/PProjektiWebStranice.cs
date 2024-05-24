namespace StudentskiProjekti.Entiteti;
public class PProjektiWebStranice
{
    public virtual int Id { get; set; }
    public virtual string PreporucenaWebStrana { get; set; }

    public virtual PrakticniProjekat PProjekat { get; set; }

    public PProjektiWebStranice()
    {

    }
}
