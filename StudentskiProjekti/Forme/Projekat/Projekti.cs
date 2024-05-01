using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml;
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

        IList<ProjekatPregled> projekti = DTOManager.VratiSortiraneProjekteZaPredmet(izabraniPredmet.Id, vrstaProjekta, tipProjekta, skolskaGodina);

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

    private void PrikazPrakticni_Btn_Click(object sender, EventArgs e)
    {
        PrakticniProjekti prakticniProjekti = new PrakticniProjekti(izabraniPredmet)
        {
            StartPosition = FormStartPosition.CenterParent
        };
        prakticniProjekti.ShowDialog();
    }

    private void PrikazTeorijski_Btn_Click(object sender, EventArgs e)
    {
        TeorijskiProjekti teorijskiProjekti = new TeorijskiProjekti(izabraniPredmet)
        {
            StartPosition = FormStartPosition.CenterParent
        };
        teorijskiProjekti.ShowDialog();
    }

    private void Excel_Btn_Click(object sender, EventArgs e)
    {
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
        saveFileDialog.FilterIndex = 1;
        saveFileDialog.RestoreDirectory = true;

        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            string putanjaDoDokumenta = saveFileDialog.FileName;

            using (SpreadsheetDocument document = SpreadsheetDocument.Create(putanjaDoDokumenta, SpreadsheetDocumentType.Workbook))
            {
                WorkbookPart workbookPart = document.AddWorkbookPart();
                workbookPart.Workbook = new Workbook();

                WorksheetPart worksheetPart = workbookPart.AddNewPart<WorksheetPart>();
                worksheetPart.Worksheet = new Worksheet(new SheetData());

                Sheets sheets = workbookPart.Workbook.AppendChild(new Sheets());
                Sheet sheet = new Sheet() { Id = workbookPart.GetIdOfPart(worksheetPart), SheetId = 1, Name = "Projekti" };
                sheets.Append(sheet);

                SheetData sheetData = worksheetPart.Worksheet.GetFirstChild<SheetData>();

                foreach (ListViewItem item in Projekti_ListV.Items)
                {
                    Row row = new Row();
                    row.Append(
                        new Cell() { CellValue = new CellValue(item.SubItems[0].Text), DataType = CellValues.String },
                        new Cell() { CellValue = new CellValue(item.SubItems[1].Text), DataType = CellValues.String }, 
                        new Cell() { CellValue = new CellValue(item.SubItems[2].Text), DataType = CellValues.String }, 
                        new Cell() { CellValue = new CellValue(item.SubItems[3].Text), DataType = CellValues.String } 
                    );
                    sheetData.Append(row);
                }

                workbookPart.Workbook.Save();
                MessageBox.Show("Fajl je uspešno kreiran.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
