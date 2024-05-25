using static StudentskiProjekti.DTOs;

namespace StudentskiProjekti.Forme
{
    public partial class IzmeniUcesce : Form
    {
        ProjekatPregled projp;
        StudentPregled sp;
        UcestvujePregled up;
        int projid;
        public IzmeniUcesce(int projid, StudentPregled sp)
        {
            InitializeComponent();
            this.projid = projid;
            this.sp = sp;
        }

        private void IzmeniUcesce_Load(object sender, EventArgs e)
        {
            projp = DTOManager.VratiProjekat(projid);
            up = DTOManager.VratiUcesce(projid, sp.BrIndeksa);

            DatmuPocetkaIzrade_DP.Value = up.DatumPocetkaIzrade;
            RokZaZavr_DP.Value = up.RokZaZavrsetak;
            DatumZavrsetkaIzrade_DP.Value = up.DatumZavrsetka ?? DateTime.Now;
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
