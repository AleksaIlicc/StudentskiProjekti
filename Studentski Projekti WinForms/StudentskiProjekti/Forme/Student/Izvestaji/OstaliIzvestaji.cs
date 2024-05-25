using static StudentskiProjekti.DTOs;
namespace StudentskiProjekti.Forme;
public partial class OstaliIzvestaji : Form
{
    int projekatId;
    string brojIndeksa;
    public OstaliIzvestaji(int projekatId, string brojIndeksa)
    {
        InitializeComponent();
        this.projekatId = projekatId;
        this.brojIndeksa = brojIndeksa;
    }

    private void OstaliIzvestaji_Load(object sender, EventArgs e)
    {
        PopuniPodacimaListView();
    }

    private void PopuniPodacimaListView()
    {
        Izvestaji_ListV.Items.Clear();

        List<StudentPregled> studenti = DTOManager.VratiStudenteNaProjektu(projekatId);

        foreach (StudentPregled student in studenti)
        {
            if (student.BrIndeksa == brojIndeksa)
            {
                continue;
            }
            List<IzvestajPregled> izvestaji = DTOManager.VratiIzvestajeZaStudenta(student.BrIndeksa, projekatId);

            foreach (IzvestajPregled izvestaj in izvestaji)
            {
                ListViewItem item = new ListViewItem(new string[] { student.BrIndeksa, student.LIme, student.Prezime , izvestaj.Opis , izvestaj.DatumPredaje.ToString("dd.MM.yyyy")});
                Izvestaji_ListV.Items.Add(item);
            }
        }
        Izvestaji_ListV.Refresh();
    }

    private void Izvestaji_ListV_DoubleClick(object sender, EventArgs e)
    {
        if (Izvestaji_ListV.SelectedItems.Count > 0)
        {
            string opisIzvestaja = Izvestaji_ListV.SelectedItems[0].SubItems[3].Text;
            MessageBox.Show(opisIzvestaja, "Opis izveštaja", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
