using static StudentskiProjekti.DTOs;

namespace StudentskiProjekti.Forme;

public partial class DodajUcesce : Form
{

    ProjekatPregled projp = new ProjekatPregled();
    StudentPregled sp = new StudentPregled();
    public DodajUcesce(ProjekatPregled projp, StudentPregled sp)
    {
        InitializeComponent();
        this.projp = projp;
        this.sp = sp;
    }

    private void DodajUcesce_Load(object sender, EventArgs e)
    {
        if (projp.VrstaProjekta == "prakticni")
        {
            ProgJ_DodLit_LBL.Text = "Odabrani programski jezik:";

        }
        else if (projp.VrstaProjekta == "teorijski")
        {
            ProgJ_DodLit_LBL.Text = "Dopunska literatura:";
            UrlDok_LBL.Visible = false;
            URL_TB.Visible = false;
        }
    }

    private void Dodaj_Btn_Click(object sender, EventArgs e)
    {
        string poruka = "Da li zelite da dodate novo ucesce?";
        string title = "Pitanje";
        MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
        DialogResult result = MessageBox.Show(poruka, title, buttons);

        if (result == DialogResult.OK)
        {
      
            if (DatmuPocetkaIzrade_DP.Value > RokZaZavr_DP.Value)
            {
                MessageBox.Show("Datum početka izrade ne može biti posle roka za završetak!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (DatumZavrsetkaIzrade_DP.Value < DatmuPocetkaIzrade_DP.Value)
            {
                MessageBox.Show("Datum zavrsetka izrade ne moze biti pre datuma pocetka izrade!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (DatumZavrsetkaIzrade_DP.Checked && DatumZavrsetkaIzrade_DP.Value > DateTime.Now)
            {
                MessageBox.Show("Datum završetka izrade ne može biti posle današnjeg datuma!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UcestvujePregled up = new UcestvujePregled();

            up.DatumPocetkaIzrade = DatmuPocetkaIzrade_DP.Value;
            if (DatumZavrsetkaIzrade_DP.Checked)
            {
                up.DatumZavrsetka = DatumZavrsetkaIzrade_DP.Value;
            }
            up.RokZaZavrsetak = RokZaZavr_DP.Value;

            if (projp.VrstaProjekta == "prakticni")
            {
                up.OdabranProgramskiJezik = ProgJ_DodLit_TB.Text;
                if (!string.IsNullOrEmpty(URL_TB.Text) && !IsValidUrl(URL_TB.Text))
                {
                    MessageBox.Show("Uneti URL nije validan!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                up.UrlDokumentacijeProgJezika = URL_TB.Text;
            }
            else if (projp.VrstaProjekta == "teorijski")
            {
                up.DopunskaLiteratura = ProgJ_DodLit_TB.Text;
            }
            if (projp.TipProjekta == "grupni")
            {
                poruka = "Projekat pod nazivom: " + projp.Naziv + " je grupni projekat!\nDodavanjem ucesca, student: " + sp.LIme + " " + sp.Prezime + " ce biti dodat/a u grupu studenata koji rade na projektu.";
                title = "Pitanje";
                buttons = MessageBoxButtons.OKCancel;
                result = MessageBox.Show(poruka, title, buttons);
                if (result != DialogResult.OK)
                {
                    this.Close();
                    return;
                }
            }

            DTOManager.DodajUcesce(sp.BrIndeksa, projp.Id, up);
            MessageBox.Show("Uspešno ste dodali novo učešće!");
            this.Close();
        }
    }
    private bool IsValidUrl(string url)
    {
        return Uri.TryCreate(url, UriKind.Absolute, out Uri uriResult)
               && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
    }
}
