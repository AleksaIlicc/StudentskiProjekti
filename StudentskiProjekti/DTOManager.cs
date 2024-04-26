namespace StudentskiProjekti
{
    public class DTOManager
    {
        public static List<PredmetPregled> vratiSvePredmete()
        {
            List<PredmetPregled> predmeti = new List<PredmetPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Predmet> sviPredmeti = from o in s.Query<Predmet>() select o;

                foreach (Predmet p in sviPredmeti)
                {
                    predmeti.Add(new PredmetPregled(p.Id, p.Naziv, p.Semestar , p.Katedra));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec);
            }

            return predmeti;
        }
    }
}
