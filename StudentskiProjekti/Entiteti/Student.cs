namespace StudentskiProjekti.Entiteti
{
        public class Student
        {
            public virtual string BrIndeksa { get; protected set; }
            public virtual string LIme { get; set; }
            public virtual string ImeRoditelja { get; set; }
            public virtual string Prezime { get; set; }
            public virtual string Smer { get; set; }

    		public virtual IList<Ucestvuje> UcestvujeProjekti { get; set; }

            public Student()
            {
                UcestvujeProjekti = new List<Ucestvuje>();
			}
        }
}
