using static StudentskiProjekti.DTOs;

namespace StudentskiProjekti.Forme;

public partial class OdabirPredmetaUcesce : Form
{
    StudentPregled sp =  new StudentPregled();
    public OdabirPredmetaUcesce(StudentPregled sp)
    {
        InitializeComponent();
        this.sp = sp;
    }

    private void OdabirPredmetaUcesce_Load(object sender, EventArgs e)
    {
        PopuniPodacima();
    }
    public void PopuniPodacima()
    {
        Predmeti_ListV.Items.Clear();
        List<PredmetPregled> predmeti = DTOManager.VratiSvePredmete();

        foreach (PredmetPregled p in predmeti)
        {
            ListViewItem item = new ListViewItem(new string[] { p.Id.ToString(), p.Naziv, p.Semestar.ToString(), p.Katedra });
            Predmeti_ListV.Items.Add(item);
        }

        Predmeti_ListV.Refresh();
    }
    private void Sortiraj_Btn_Click(object sender, EventArgs e)
    {
        string semestarFilter = Semestar_TB.Text;
        string katedraFilter = NazivKatedre_TB.Text;

        List<PredmetPregled> filtriraniPredmeti = DTOManager.VratiSortiranePredmete(semestarFilter, katedraFilter);

        Predmeti_ListV.Items.Clear();

        foreach (PredmetPregled p in filtriraniPredmeti)
        {
            ListViewItem item = new ListViewItem(new string[] { p.Id.ToString(), p.Naziv, p.Semestar.ToString(), p.Katedra });
            Predmeti_ListV.Items.Add(item);
        }
    }

    private void Ocisti_Btn_Click(object sender, EventArgs e)
    {
        Semestar_TB.Clear();
        NazivKatedre_TB.Clear();
        PopuniPodacima();
    }

    private void Prikazi_Btn_Click(object sender, EventArgs e)
    {
        if(Predmeti_ListV.SelectedItems.Count == 0) {
            MessageBox.Show("Izaberite predmet za koji zelite da dodate ucesce!");
            return;
        }
        this.Hide();
        PredmetPregled pred = DTOManager.VratiPredmet(Predmeti_ListV.SelectedItems[0].Text);
        OdabirProjektaUcesce odabirProjektaUcesce = new OdabirProjektaUcesce(pred , sp)
        {
            StartPosition = FormStartPosition.CenterParent,
            Owner = this
        };
        odabirProjektaUcesce.ShowDialog();
        this.Close();
    }
}
