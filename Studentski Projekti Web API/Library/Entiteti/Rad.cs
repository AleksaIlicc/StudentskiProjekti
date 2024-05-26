namespace Library.Entiteti;
internal class Rad
{
    internal protected virtual int Id { get; protected set; }
    internal protected virtual string Url { get; set; }
    internal protected virtual string KonferencijaObjavljivanja { get; set; }
    internal protected virtual string Format { get; set; }
    internal protected virtual required Literatura Literatura { get; set; }

    internal Rad()
    {

    }
}
