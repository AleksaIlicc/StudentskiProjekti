using static StudentskiProjekti.DTOs;
namespace StudentskiProjekti.Forme;
public partial class OstaliIzvestaji : Form
{
    ProjekatPregled pp = new PrakticniProjekatPregled();
    StudentPregled sp = new StudentPregled();
    public OstaliIzvestaji(ProjekatPregled pp, StudentPregled sp)
    {
        InitializeComponent();
        this.pp = pp;
        this.sp = sp;
    }

    private void OstaliIzvestaji_Load(object sender, EventArgs e)
    {
        PopuniPodacimaListView();
    }

    private void PopuniPodacimaListView()
    {
        Izvestaji_ListV.Items.Clear();

        List<StudentPregled> studenti = DTOManager.VratiStudenteNaProjektu(pp.Id);

        foreach (StudentPregled student in studenti)
        {
            if (student.BrIndeksa == sp.BrIndeksa)
            {
                continue;
            }
            List<IzvestajPregled> izvestaji = DTOManager.VratiIzvestajeZaGrupu(student.BrIndeksa , pp.Id);

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
