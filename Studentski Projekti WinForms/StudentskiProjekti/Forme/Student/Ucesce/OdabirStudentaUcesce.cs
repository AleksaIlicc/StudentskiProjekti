using static StudentskiProjekti.DTOs;

namespace StudentskiProjekti.Forme;

public partial class OdabirStudentaUcesce : Form
{
    ProjekatPregled projp; 
    public OdabirStudentaUcesce(ProjekatPregled projp)
    {
        InitializeComponent();
        this.projp = projp;
    }
    private void PopuniPodacima()
    {
        Studenti_ListV.Items.Clear();
        List<StudentPregled> studenti = DTOManager.VratiSveStudente();

        foreach (StudentPregled s in studenti)
        {
            ListViewItem item = new ListViewItem(new string[] { s.BrIndeksa, s.LIme, s.ImeRoditelja, s.Prezime, s.Smer });
            Studenti_ListV.Items.Add(item);
        }

        Studenti_ListV.Refresh();
    }
    private void OdabirStudentaUcesce_Load(object sender, EventArgs e)
    {
        PopuniPodacima();
    }

    private void Ocisti_Btn_Click(object sender, EventArgs e)
    {
        BrojIndeksa_TB.Clear();
        Ime_TB.Clear();
        Prezime_TB.Clear();
        Smer_TB.Clear();
        PopuniPodacima();
    }

    private void Sortiraj_Btn_Click(object sender, EventArgs e)
    {
        string brIndeksaTB = BrojIndeksa_TB.Text;
        string imeTB = Ime_TB.Text;
        string prezimeTB = Prezime_TB.Text;
        string smerTB = Smer_TB.Text;
        if (string.IsNullOrEmpty(brIndeksaTB) && string.IsNullOrEmpty(imeTB) && string.IsNullOrEmpty(prezimeTB) && string.IsNullOrEmpty(smerTB))
        {
            MessageBox.Show("Izaberite po čemu želite da sortirate.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        IList<StudentPregled> studenti = DTOManager.VratiSortiraneStudente(brIndeksaTB, imeTB, prezimeTB, smerTB);

        Studenti_ListV.Items.Clear();
        foreach (StudentPregled s in studenti)
        {
            ListViewItem item = new ListViewItem(new string[] { s.BrIndeksa, s.LIme, s.ImeRoditelja, s.Prezime, s.Smer });
            Studenti_ListV.Items.Add(item);
        }

        Studenti_ListV.Refresh();
    }

    private void Ime_TB_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
        {
            e.Handled = true;
        }
    }

    private void Prezime_TB_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
        {
            e.Handled = true;
        }
    }


    private void Izaberi_Btn_Click(object sender, EventArgs e)
    {
        if (Studenti_ListV.SelectedItems.Count == 0)
        {
            MessageBox.Show("Izaberite projekat za koji zelite da dodate ucesce!");
            return;
        }
        this.Hide();
        DodajUcesce dodajUcesce = new DodajUcesce(projp, DTOManager.VratiStudenta(Studenti_ListV.SelectedItems[0].SubItems[0].Text))
        {
            StartPosition = FormStartPosition.CenterParent,
            Owner = this
        };
        dodajUcesce.ShowDialog();
        this.Close();
    }
}
