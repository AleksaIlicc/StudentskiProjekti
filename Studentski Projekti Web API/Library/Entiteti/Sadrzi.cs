namespace Library.Entiteti;
internal class Sadrzi
{
    internal protected virtual int Id { get; protected set; }

    internal protected required virtual TeorijskiProjekat TProjekat { get; set; }
    internal protected required virtual Literatura Literatura { get; set; }

    internal Sadrzi()
	{

	}
}
