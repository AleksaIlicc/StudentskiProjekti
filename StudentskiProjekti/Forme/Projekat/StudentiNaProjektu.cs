using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml;
using static StudentskiProjekti.DTOs;

namespace StudentskiProjekti.Forme;

public partial class StudentiNaProjektu : Form
{
	TeorijskiProjekatPregled tp = new TeorijskiProjekatPregled();
    PrakticniProjekatPregled pp = new PrakticniProjekatPregled();
    string vrsta;
    public StudentiNaProjektu(TeorijskiProjekatPregled tp)
    {
        InitializeComponent();
        this.tp = tp;
        this.vrsta = "teorijski";
    }

    public StudentiNaProjektu(PrakticniProjekatPregled pp)
    {
        InitializeComponent();
        this.pp = pp;
        this.vrsta = "prakticni";
    }

    private void StudentiNaProjektu_Load(object sender, EventArgs e)
    {
        PopuniPodacima();
        if (pp.TipProjekta == "grupni" || tp.TipProjekta == "grupni")
        {
            TipProj_LB.Text = "Studenti u grupi koja radi na projektu:";
        }
        else if (pp.TipProjekta == "pojedinacni" || tp.TipProjekta == "pojedinacni")
        {
            TipProj_LB.Text = "Studenti koji rade na projektu:";
        }

        if (vrsta == "prakticni")
        {
            Naziv_LB.Text = pp.Naziv;
            SkolskaGodZad_LB.Text = pp.SkolskaGodinaZadavanja.ToString();
            DodatnaLit_Izvestaji_Btn.Text = "Prikazi izvestaje koje je student predao na projektu";
        }
        else if (vrsta == "teorijski")
        {
            Naziv_LB.Text = tp.Naziv;
            SkolskaGodZad_LB.Text = tp.SkolskaGodinaZadavanja.ToString();
            DodatnaLit_Izvestaji_Btn.Text = "Prikazi preporucenu literaturu na projektu za studenta";
        }
    }

    private void DodatnaLit_Izvestaji_Btn_Click(object sender, EventArgs e)
    {
        if (vrsta == "prakticni")
        {
            if (Studenti_ListV.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite studenta za kog zelite da vidite izvestaje!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            StudentPregled st = DTOManager.VratiStudenta(Studenti_ListV.SelectedItems[0].SubItems[0].Text);
            PredatiIzvestaji izvestaji = new PredatiIzvestaji(st, pp)
            {
                StartPosition = FormStartPosition.CenterParent
            };
            izvestaji.ShowDialog();
        }
        else if (vrsta == "teorijski")
        {
            if (Studenti_ListV.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite studenta za kog zelite da vidite dopunsku literaturu!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
           
            string opisIzvestaja = DTOManager.VratiDopunskuLiteraturu(tp.Id, Studenti_ListV.SelectedItems[0].SubItems[0].Text);
            if (string.IsNullOrEmpty(opisIzvestaja))
            {
                MessageBox.Show("Student nema dopunsku literaturu.", "Opis izveštaja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(opisIzvestaja, "Opis izveštaja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }


    private void PopuniPodacima()
    {
        Studenti_ListV.Items.Clear();
        List<StudentPregled> studenti = new List<StudentPregled>();
        if (vrsta == "prakticni")
        {
            studenti = DTOManager.VratiStudenteNaProjektu(pp.Id);
        }
        else if (vrsta == "teorijski")
        {
            studenti = DTOManager.VratiStudenteNaProjektu(tp.Id);
        }

        foreach (StudentPregled s in studenti)
        {
            ListViewItem item = new ListViewItem(new string[] { s.BrIndeksa, s.LIme, s.ImeRoditelja, s.Prezime, s.Smer });
            Studenti_ListV.Items.Add(item);
        }
        Studenti_ListV.Refresh();
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
                Sheet sheet = new Sheet() { Id = workbookPart.GetIdOfPart(worksheetPart), SheetId = 1, Name = "Studenti" };
                sheets.Append(sheet);

                SheetData sheetData = worksheetPart.Worksheet.GetFirstChild<SheetData>();

                foreach (ListViewItem item in Studenti_ListV.Items)
                {
                    Row row = new Row();
                    row.Append(
                        new Cell() { CellValue = new CellValue(item.SubItems[0].Text), DataType = CellValues.String },
                        new Cell() { CellValue = new CellValue(item.SubItems[1].Text), DataType = CellValues.String },
                        new Cell() { CellValue = new CellValue(item.SubItems[2].Text), DataType = CellValues.String },
                        new Cell() { CellValue = new CellValue(item.SubItems[3].Text), DataType = CellValues.String },
                        new Cell() { CellValue = new CellValue(item.SubItems[4].Text), DataType = CellValues.String }
                    );
                    sheetData.Append(row);
                }

                workbookPart.Workbook.Save();
                MessageBox.Show("Fajl je uspešno kreiran.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
