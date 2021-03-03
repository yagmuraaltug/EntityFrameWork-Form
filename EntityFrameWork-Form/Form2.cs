using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameWork_Form
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        DbEntities entities = new DbEntities();
        private void BtnLinq_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                var results = entities.tblNotes.Where(p => p.Exam1 < 50);
                dataGridView2.DataSource = results.ToList();
            }


            if (radioButton2.Checked == true)
            {
                var results = entities.tblStudent.Where(p => p.FirstName == txtSearch.Text || p.Surname == txtSearch.Text);
                dataGridView2.DataSource = results.ToList();
            }

            if (radioButton3.Checked == true)
            {
                var results = entities.tblStudent.Select(p => new { surname = p.Surname });
                dataGridView2.DataSource = results.ToList();
            }

            if (radioButton4.Checked == true)
            {
                var results = entities.tblStudent.Select(p => new { Ad = p.FirstName.ToUpper(), Surname = p.Surname.ToLower() });
                dataGridView2.DataSource = results.ToList();
            }

            if (radioButton5.Checked == true)
            {
                var results = entities.tblStudent.Select(p => new { Ad = p.FirstName.ToUpper(), Surname = p.Surname.ToLower() }).Where(p => p.Ad != "Yagmur");
                dataGridView2.DataSource = results.ToList();
            }
            if (radioButton6.Checked == true)
            {
                var results = entities.tblNotes.Select(p => new
                {
                    StudentName = p.Student,
                    Average = p.Average,
                    Condition = p.Condition == true ? "PASS" : "FAIL"

                });
                dataGridView2.DataSource = results.ToList();
            }
            if (radioButton7.Checked == true)
            {
                var results = entities.tblNotes.SelectMany(p => entities.tblStudent.Where(y => y.Id == p.Student), (p, y) => new
                {
                    y.FirstName,
                    p.Average
                });
                dataGridView2.DataSource = results.ToList();
            }

            if (radioButton8.Checked == true)
            {
                var results = entities.tblStudent.OrderBy(p => p.Id).Take(3);
                dataGridView2.DataSource = results.ToList();

            }

            if (radioButton9.Checked == true)
            {
                var results = entities.tblStudent.OrderByDescending(p => p.Id).Take(3);
                dataGridView2.DataSource = results.ToList();

            }
            if (radioButton10.Checked == true)
            {
                var results = entities.tblStudent.OrderBy(p => p.FirstName);
                dataGridView2.DataSource = results.ToList();

            }
            if (radioButton11.Checked == true)
            {
                var results = entities.tblStudent.OrderBy(p => p.Id).Skip(5);
                dataGridView2.DataSource = results.ToList();

            }
        }
    }
}
