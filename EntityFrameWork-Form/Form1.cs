using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameWork_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DbEntities entities = new DbEntities();             //model ismi uzerinden ilerledik.

        private void BtnListele_Click(object sender, EventArgs e)
        {
            tblStudent student = new tblStudent(); //ogrenci sinifi
            student.FirstName = TxtStudentName.Text;
            student.Surname = TxtStudentSurname.Text;
            entities.tblStudent.Add(student);
            entities.SaveChanges();
            MessageBox.Show("Student Added!");

            tblLectures lectures = new tblLectures();
            lectures.LectureName = TxtLectureName.Text;
            entities.tblLectures.Add(lectures);
            entities.SaveChanges();
            MessageBox.Show("Lecture Added!");

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnLectureList_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DbExam-Student;Integrated Security=True");
            SqlCommand command = new SqlCommand("Select * from tblLectures", connection); //veri tabanini iliskilendirdik
            SqlDataAdapter adapter = new SqlDataAdapter(command); //Baglayici olusturduk.
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void BtnStudentList_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = entities.tblStudent.ToList();
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
        }

        private void BtnNoteList_Click(object sender, EventArgs e)
        {
            var query = from item in entities.tblNotes
                        select new
                        {
                            item.NoteId,
                            item.tblStudent.FirstName,
                            item.tblStudent.Surname,
                            item.tblLectures.LectureName,
                            item.Exam1,
                            item.Exam2,
                            item.Exam3,
                            item.Average,
                            item.Condition
                        };
            dataGridView1.DataSource = query.ToList(); //bizim sactigimiz degiskenler listede gozukuyor.
                                                       //dataGridView1.DataSource = entities.tblNotes.ToList();

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TxtStudentId.Text);
            var x = entities.tblStudent.Find(id);
            entities.tblStudent.Remove(x);
            entities.SaveChanges();
            MessageBox.Show("Student Deleted!");
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TxtStudentId.Text);
            var find = entities.tblStudent.Find(id);
            find.FirstName = TxtStudentName.Text;
            find.Surname = TxtStudentSurname.Text;
            find.Photo = TxtStudentPhoto.Text;
            entities.SaveChanges();
            MessageBox.Show("Student Updated!");



        }

        private void btnProcedure_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = entities.NOTELIST();

        }

        private void BtnBul_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = entities.tblStudent.Where(x => x.FirstName == TxtStudentName.Text & x.Surname == TxtStudentSurname.Text).ToList();
        }

        private void TxtStudentName_TextChanged(object sender, EventArgs e)
        {
            string search = TxtStudentName.Text;
            var values = from value in entities.tblStudent
                         where value.FirstName.Contains(search)
                         select value;
            dataGridView1.DataSource = values.ToList();

        }

        private void BtnLinqEntities_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                List<tblStudent> list1 = entities.tblStudent.OrderBy(p => p.FirstName).ToList();
                dataGridView1.DataSource = list1;

            }

            if (radioButton2.Checked == true)
            {
                List<tblStudent> list2 = entities.tblStudent.OrderByDescending(p => p.FirstName).ToList();
                dataGridView1.DataSource = list2;
            }

            if (radioButton3.Checked == true)
            {
                List<tblStudent> list3 = entities.tblStudent.OrderBy(p => p.FirstName).Take(3).ToList();
                dataGridView1.DataSource = list3;
            }

            if (radioButton4.Checked == true)
            {
                List<tblStudent> list4 = entities.tblStudent.Where(p => p.Id == 5).ToList();
                dataGridView1.DataSource = list4;
            }

            if (radioButton5.Checked == true)
            {
                List<tblStudent> list5 = entities.tblStudent.Where(p => p.FirstName.StartsWith("a")).ToList();
                dataGridView1.DataSource = list5;
            }
            if (radioButton6.Checked == true)
            {
                List<tblStudent> list6 = entities.tblStudent.Where(p => p.FirstName.EndsWith("a")).ToList();
                dataGridView1.DataSource = list6;
            }

            if (radioButton7.Checked == true)
            {
                bool value = entities.tblStudent.Any();
                MessageBox.Show(value.ToString(), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (radioButton8.Checked == true)
            {
                int total = entities.tblStudent.Count();
                MessageBox.Show(total.ToString(), "Total Students", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }

            if (radioButton9.Checked == true)
            {
                var total = entities.tblNotes.Sum(p => p.Exam1);
                MessageBox.Show("Total Exam1 Results: " + total.ToString());
            }

            if (radioButton10.Checked == true)
            {
                var average = entities.tblNotes.Average(p => p.Exam1);
                MessageBox.Show("Average of Exam1: " + average.ToString());
            }
            if (radioButton11.Checked == true)
            {
                var maximum = entities.tblNotes.Max(p => p.Exam1);
                MessageBox.Show("Maximum Exm1 : " + maximum.ToString());
            }
            if (radioButton12.Checked == true)
            {
                var minumum = entities.tblNotes.Min(p => p.Exam1);
                MessageBox.Show("Minumum Exm1 : " + minumum.ToString());
            }

        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnJoin_Click(object sender, EventArgs e)
        {
            var query = from d1 in entities.tblNotes
                        join d2 in entities.tblStudent
                        on d1.Student equals d2.Id
                        join d3 in entities.tblLectures
                        on d1.Lecture equals d3.LectureId
                        
                        
                        select new
                        {
                            STUDENT = d2.FirstName, 
                            SURNAME = d2.Surname,
                            DERS = d3.LectureName,
                            EXAM1 =    d1.Exam1,
                            EXAM2=    d1.Exam2,
                            EXAM3=    d1.Exam3,
                            AVERAGE = d1.Average

                        };
            dataGridView1.DataSource = query.ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
