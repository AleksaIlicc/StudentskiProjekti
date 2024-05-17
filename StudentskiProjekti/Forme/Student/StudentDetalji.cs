using static StudentskiProjekti.DTOManager;
using static StudentskiProjekti.DTOs;

namespace StudentskiProjekti.Forme;
public partial class StudentDetalji : Form
{
    StudentPregled sp = new StudentPregled();
    public StudentDetalji(StudentPregled sp)
    {
        InitializeComponent();
        this.sp = sp;
    }

    private void StudentDetalji_Load(object sender, EventArgs e)
    {
        PopuniPodacima();
    }

    public void PopuniPodacima()
    {
        StudentDetalji_ListV.Items.Clear();
        List<ProjekatDetalji> detalji = DTOManager.VratiProjekteZaStudenta(sp.BrIndeksa);

        foreach (ProjekatDetalji p in detalji)
        {

            ListViewItem item = new ListViewItem(new string[] { p.NazivProjekta, p.DatumPocetkaIzrade.ToString(), p.DatumZavrsetkaIzrade.ToString(), p.RokZaZavrsetak.ToString(), p.ProjekatZavrsen });
            StudentDetalji_ListV.Items.Add(item);
        }

        StudentDetalji_ListV.Refresh();
    }

}
