using static StudentskiProjekti.DTOs;

namespace StudentskiProjekti.Forme
{
    public partial class IzmeniUcesce : Form
    {
        UcestvujePregled up;
        ProjekatPregled projp;
        StudentPregled sp;
        int projid;
        public IzmeniUcesce(int projid, string sp)
        {
            InitializeComponent();
            this.projid = projid;
            this.sp = DTOManager.VratiStudenta(sp);
        }

        private void IzmeniUcesce_Load(object sender, EventArgs e)
        {
            projp = DTOManager.VratiProjekat(projid);
            up = DTOManager.VratiUcesce(projid, sp.BrIndeksa);

            DatmuPocetkaIzrade_DP.Value = up.DatumPocetkaIzrade;
            RokZaZavr_DP.Value = up.RokZaZavrsetak;
            if (up.DatumZavrsetka == null)
            {
                DatumZavrsetkaIzrade_DP.Checked = false;
                DatumZavrsetkaIzrade_DP.Value = DateTime.Now;
            }
            else if (up.DatumZavrsetka != null)
            {
                DatumZavrsetkaIzrade_DP.Checked = true;
                DatumZavrsetkaIzrade_DP.Value = up.DatumZavrsetka ?? DateTime.Now;
            }
    
            DatumZavrsetkaIzrade_DP.Checked = up.DatumZavrsetka.HasValue;

            if (projp.VrstaProjekta == "prakticni")
            {
                ProgJ_DodLit_LBL.Text = "Odabrnani programski jezik:";
                ProgJ_DodLit_TB.Text = up.OdabranProgramskiJezik;
                URL_TB.Text = up.UrlDokumentacijeProgJezika;
            }
            else if (projp.VrstaProjekta == "teorijski")
            {
                ProgJ_DodLit_LBL.Text = "Dopunska literatura:";
                ProgJ_DodLit_TB.Text = up.DopunskaLiteratura;
                UrlDok_LBL.Visible = false;
                URL_TB.Visible = false;
            }
        }

        private void Izmeni_Btn_Click(object sender, EventArgs e)
        {
            string poruka = "Da li želite da izmenite postojeće učešće?";
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

                up.DatumPocetkaIzrade = DatmuPocetkaIzrade_DP.Value;
                if (DatumZavrsetkaIzrade_DP.Checked)
                {
                    up.DatumZavrsetka = DatumZavrsetkaIzrade_DP.Value;
                }
                else
                {
                    up.DatumZavrsetka = null;
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

                DTOManager.AzurirajUcesce(up);
                MessageBox.Show("Uspešno ste izmenili učešće!");
                this.Close();
            }
        }

        private bool IsValidUrl(string url)
        {
            return Uri.TryCreate(url, UriKind.Absolute, out Uri uriResult)
                   && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
        }
    }
}
