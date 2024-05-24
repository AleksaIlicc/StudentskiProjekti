using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using static StudentskiProjekti.DTOs;

namespace StudentskiProjekti.Forme;
public partial class Studenti : Form
{
    public Studenti()
    {
        InitializeComponent();
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

    private void DodajStudenta_Btn_Click(object sender, EventArgs e)
    {
        DodajStudenta dodajPredmet = new DodajStudenta()
        {
            StartPosition = FormStartPosition.CenterParent
        };
        dodajPredmet.ShowDialog();
        PopuniPodacima();
    }

    private void Studenti_Load(object sender, EventArgs e)
    {
        PopuniPodacima();
    }

    private void ObrisiStudenta_Btn_Click(object sender, EventArgs e)
    {
        if (Studenti_ListV.SelectedItems.Count == 0)
        {
            MessageBox.Show("Izaberite studenta kojeg zelite da obrisete!");
            return;
        }

        string idStudenta = Studenti_ListV.SelectedItems[0].SubItems[0].Text;
        string poruka = "Da li zelite da obrisete izabranog studenta?";
        string title = "Pitanje";
        MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
        DialogResult result = MessageBox.Show(poruka, title, buttons);

        if (result == DialogResult.OK)
        {
            DTOManager.ObrisiStudenta(idStudenta);
            MessageBox.Show("Brisanje studenta je uspesno obavljeno!");
            PopuniPodacima();
        }
    }

    private void IzmeniStudenta_Btn_Click(object sender, EventArgs e)
    {
        if (Studenti_ListV.SelectedItems.Count == 0)
        {
            MessageBox.Show("Izaberite studenta cije informacije zelite da izmenite!");
            return;
        }

        string brIndeksaStudenta = Studenti_ListV.SelectedItems[0].SubItems[0].Text;
        StudentPregled sp = DTOManager.VratiStudenta(brIndeksaStudenta);

        IzmeniStudenta formaUpdate = new IzmeniStudenta(sp)
        {
            StartPosition = FormStartPosition.CenterParent
        };
        formaUpdate.ShowDialog();
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

    private void Prikazi_Btn_Click(object sender, EventArgs e)
    {
        if (Studenti_ListV.SelectedItems.Count == 0)
        {
            MessageBox.Show("Izaberite studenta za kojeg zelite da vidite vise detalja!");
            return;
        }

        string brIndeksa = Studenti_ListV.SelectedItems[0].SubItems[0].Text;
        StudentPregled izabraniPredmet = DTOManager.VratiStudenta(brIndeksa);

        StudentDetalji projekti = new StudentDetalji(izabraniPredmet)
        {
            StartPosition = FormStartPosition.CenterParent
        };
        projekti.ShowDialog();
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
