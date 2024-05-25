using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml;
using static StudentskiProjekti.DTOs;
namespace StudentskiProjekti.Forme;
public partial class StudentiNaProjektu : Form
{
    ProjekatPregled p = new ProjekatPregled();

    public StudentiNaProjektu(int idProjekta)
    {
        InitializeComponent();
        p = DTOManager.VratiProjekat(idProjekta);
    }

    private void StudentiNaProjektu_Load(object sender, EventArgs e)
    {
        PopuniPodacima();
        if (p.TipProjekta == "grupni")
        {
            TipProj_LB.Text = "Studenti u grupi koja radi na projektu:";
        }
        else if (p.TipProjekta == "pojedinacni")
        {
            TipProj_LB.Text = "Studenti koji rade na projektu:";
        }

        Naziv_LB.Text = p.Naziv;
        SkolskaGodZad_LB.Text = p.SkolskaGodinaZadavanja.ToString();
    }

    private void DetaljiUcesca_Btn_Click(object sender, EventArgs e)
    {
        if (Studenti_ListV.SelectedItems.Count == 0)
        {
            MessageBox.Show("Izaberite studenta za kog zelite da vidite detalje ucesca!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        StudentPregled st = DTOManager.VratiStudenta(Studenti_ListV.SelectedItems[0].SubItems[0].Text);
        if (p.VrstaProjekta == "prakticni")
        {
            PrakticniUcesceDetalji prakticnidet = new PrakticniUcesceDetalji(st, p)
            {
                StartPosition = FormStartPosition.CenterParent
            };
            prakticnidet.ShowDialog();
        }
        else if (p.VrstaProjekta == "teorijski")
        {
            TeorijskiUcesceDetalji teorijskidet = new TeorijskiUcesceDetalji(st, p)
            {
                StartPosition = FormStartPosition.CenterParent
            };
            teorijskidet.ShowDialog();
        }
    }

    private void PopuniPodacima()
    {
        Studenti_ListV.Items.Clear();
        List<StudentPregled> studenti = DTOManager.VratiStudenteNaProjektu(p.Id);

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

    private void DodajUcesce_Btn_Click(object sender, EventArgs e)
    {
        OdabirStudentaUcesce odabirStudentaUcesce = new OdabirStudentaUcesce(p)
        {
            StartPosition = FormStartPosition.CenterParent
        };
        odabirStudentaUcesce.ShowDialog();
        PopuniPodacima();
    }

    private void IzmeniUcesce_Btn_Click(object sender, EventArgs e)
    {
        if (Studenti_ListV.SelectedItems.Count == 0)
        {
            MessageBox.Show("Izaberite studenta cije ucesce zelite da izmenite!");
            return;
        }
        IzmeniUcesce izmeniUcesce = new IzmeniUcesce(p.Id, Studenti_ListV.SelectedItems[0].SubItems[0].Text)
        {
            StartPosition = FormStartPosition.CenterParent
        };
        izmeniUcesce.ShowDialog();
        PopuniPodacima();
    }

    private void ObrisiUcesce_Btn_Click(object sender, EventArgs e)
    {
        if (Studenti_ListV.SelectedItems.Count == 0)
        {
            MessageBox.Show("Izaberite studenta cije ucesce zelite da obrisete!");
            return;
        }

        UcestvujePregled ucestvujep = DTOManager.VratiUcesce(p.Id, Studenti_ListV.SelectedItems[0].SubItems[0].Text);
        string poruka = "Da li zelite da obrisete ucesce izabranog studenta?";
        string title = "Pitanje";
        MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
        DialogResult result = MessageBox.Show(poruka, title, buttons);

        if (result == DialogResult.OK)
        {
            DTOManager.ObrisiUcesce(ucestvujep);
            MessageBox.Show("Brisanje ucesca studenta je uspesno obavljeno!");
            PopuniPodacima();
        }
    }
}
