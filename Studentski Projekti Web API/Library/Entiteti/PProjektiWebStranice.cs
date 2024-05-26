namespace Library.Entiteti;
internal class PProjektiWebStranice
{
    internal protected virtual int Id { get; set; }
    internal protected virtual string PreporucenaWebStrana { get; set; }

    internal protected virtual PrakticniProjekat PProjekat { get; set; }

    internal PProjektiWebStranice()
    {

    }
}
