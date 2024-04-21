namespace StudentskiProjekti.Entiteti
{
    public class Predmet
    {
        public virtual int Id { get; protected set; }
        public virtual string Naziv { get; set; }
        public virtual int Semestar { get; set; }
        public virtual string Katedra { get; set; }

        // not null ima na naziv nzm jel to moze ovde da se dodaje
        public Predmet()
        {

        }
    
    }
}
