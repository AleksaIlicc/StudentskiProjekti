using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static StudentskiProjekti.DTOs;

namespace StudentskiProjekti.Forme
{
    public partial class StudentiNaProjektu : Form
    {
        DTOs.TeorijskiProjekatPregled tp = new DTOs.TeorijskiProjekatPregled();
        DTOs.PrakticniProjekatPregled pp = new DTOs.PrakticniProjekatPregled();
        string vrsta;
        public StudentiNaProjektu(DTOs.TeorijskiProjekatPregled tp)
        {
            InitializeComponent();
            this.tp = tp;
            this.vrsta = "teorijski";

        }
        public StudentiNaProjektu(DTOs.PrakticniProjekatPregled pp)
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

            if (this.vrsta == "prakticni")
            {
                Naziv_LB.Text = pp.Naziv;
                SkolskaGodZad_LB.Text = pp.SkolskaGodinaZadavanja.ToString();
                DodatnaLit_Izvestaji_Btn.Text = "Prikazi izvestaje koje je student predao na projektu";
            }
            else if (this.vrsta == "teorijski")
            {
                Naziv_LB.Text = tp.Naziv;
                SkolskaGodZad_LB.Text = tp.SkolskaGodinaZadavanja.ToString();
                DodatnaLit_Izvestaji_Btn.Text = "Prikazi preporucenu literaturu na projektu za studenta";
            }
        }

        private void DodatnaLit_Izvestaji_Btn_Click(object sender, EventArgs e)
        {
            if (this.vrsta == "prakticni")
            {
                if (Studenti_ListV.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Izaberite studenta za kog zelite da vidite izvestaje!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                StudentPregled st = DTOManager.VratiStudenta(Studenti_ListV.SelectedItems[0].SubItems[0].Text);
                PredatiIzvestaji izvestaji = new PredatiIzvestaji(st, pp, DTOManager.VratiUcesceNaProj(st.BrIndeksa, pp.Id))
                {
                    StartPosition = FormStartPosition.CenterParent
                };
                izvestaji.ShowDialog();
            }
            else if (this.vrsta == "teorijski")
            {
                if (Studenti_ListV.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Izaberite studenta za kog zelite da vidite dopunsku literaturu!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (Studenti_ListV.SelectedItems.Count > 0)
                {
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
        }


        private void PopuniPodacima()
        {
            Studenti_ListV.Items.Clear();
            List<StudentPregled> studenti = new List<StudentPregled>();
            if (this.vrsta == "prakticni")
            {
                studenti = DTOManager.VratiStudenteNaProjektu(pp.Id);
            }
            else if (this.vrsta == "teorijski")
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
                MessageBox.Show("Izaberite po čemu želite da sortirate.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            IList<StudentPregled> studenti = new List<StudentPregled>();
            if (this.vrsta == "prakticni")
            {
               studenti = DTOManager.VratiSortiraneStudenteNaProjektu(brIndeksaTB, imeTB, prezimeTB, smerTB, pp.Id);
            }
            else if (this.vrsta == "teorijski")
            {
               studenti = DTOManager.VratiSortiraneStudenteNaProjektu(brIndeksaTB, imeTB, prezimeTB, smerTB, tp.Id);
            }

            Studenti_ListV.Items.Clear();
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
}
