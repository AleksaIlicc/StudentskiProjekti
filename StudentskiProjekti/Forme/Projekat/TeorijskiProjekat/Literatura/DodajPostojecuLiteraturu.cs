using static StudentskiProjekti.DTOs;

namespace StudentskiProjekti.Forme;
public partial class DodajPostojecuLiteraturu : Form
{
    int projekatId;
    public DodajPostojecuLiteraturu(int projekatId)
    {
        InitializeComponent();
        this.projekatId = projekatId;
    }


    private void DodajPostojecuLiteraturu_Load(object sender, EventArgs e)
    {
        PopuniPodacima();
    }

    public void PopuniPodacima()
    {
        Literature_ListV.Items.Clear();
        List<LiteraturaPregled> literature = DTOManager.VratiLiteratureZaProjekat();

        foreach (LiteraturaPregled l in literature)
        {
            ListViewItem item = new ListViewItem(new string[] { l.Naziv });
            item.Tag = l.Id;
            Literature_ListV.Items.Add(item);
        }

        Literature_ListV.Refresh();
    }

}
