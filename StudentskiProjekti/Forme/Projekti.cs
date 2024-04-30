using static StudentskiProjekti.DTOs;

namespace StudentskiProjekti.Forme;

public partial class Projekti : Form
{

    private PredmetPregled izabraniPredmet;
    public Projekti(PredmetPregled izabraniPredmet)
    {
        InitializeComponent();
        this.izabraniPredmet = izabraniPredmet;
    }

    private void Projekti_Load(object sender, EventArgs e)
    {
        PopuniPodacima();
        Naziv_Lbl.Text = izabraniPredmet.Naziv;
        Sifra_Lbl.Text = izabraniPredmet.Id;
        Katedra_Lbl.Text = izabraniPredmet.Katedra;
        Semestar_Lbl.Text = izabraniPredmet.Semestar.ToString() + ".";
    }

    public void PopuniPodacima()
    {

        Projekti_ListV.Items.Clear();
        IList<ProjekatPregled> projekti = DTOManager.VratiProjekteZaPredmet(izabraniPredmet.Id);
        projekti = projekti.OrderBy(p => p.SkolskaGodinaZadavanja).ToList();

        foreach (ProjekatPregled p in projekti)
        {
            ListViewItem item = new ListViewItem(new string[] { p.Naziv, p.SkolskaGodinaZadavanja, p.VrstaProjekta, p.TipProjekta });
            Projekti_ListV.Items.Add(item);
        }

        Projekti_ListV.Refresh();
    }

    private void Sortiraj_Btn_Click(object sender, EventArgs e)
    {
        if (!Prakticni_RB.Checked && !Teorijski_RB.Checked && !Grupni_RB.Checked && !Pojedinacni_RB.Checked && SkoslkaGodZad_TB.Text == "")
        {
            MessageBox.Show("Izaberite po čemu želite da sortirate.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        string vrstaProjekta = Prakticni_RB.Checked ? "prakticni" : Teorijski_RB.Checked ? "teorijski" : "";
        string tipProjekta = Grupni_RB.Checked ? "grupni" : Pojedinacni_RB.Checked ? "pojedinacni" : "";
        string skolskaGodina = SkoslkaGodZad_TB.Text;

        IList<ProjekatPregled> projekti = DTOManager.VratiProjekteZaPredmet(izabraniPredmet.Id)
            .Where(p => (string.IsNullOrEmpty(vrstaProjekta) || p.VrstaProjekta == vrstaProjekta) &&
                        (string.IsNullOrEmpty(tipProjekta) || p.TipProjekta == tipProjekta) &&
                        (string.IsNullOrEmpty(skolskaGodina) || p.SkolskaGodinaZadavanja == skolskaGodina))
            .OrderBy(p => p.SkolskaGodinaZadavanja)
            .ToList();

        Projekti_ListV.Items.Clear();
        foreach (ProjekatPregled p in projekti)
        {
            ListViewItem item = new ListViewItem(new string[] { p.Naziv, p.SkolskaGodinaZadavanja, p.VrstaProjekta, p.TipProjekta });
            Projekti_ListV.Items.Add(item);
        }

        Projekti_ListV.Refresh();
    }

    private void Ocisti_Btn_Click(object sender, EventArgs e)
    {

        Prakticni_RB.Checked = false;
        Teorijski_RB.Checked = false;
        Grupni_RB.Checked = false;
        Pojedinacni_RB.Checked = false;
        SkoslkaGodZad_TB.Text = "";
        PopuniPodacima();
    }
}
