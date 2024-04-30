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
}
