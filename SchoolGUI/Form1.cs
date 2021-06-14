using School.DAL;
using School.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolGUI
{
    public partial class Form1 : Form
    {
        StudentRepository repository = new StudentRepository();
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreashListBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentForm studentForm = new StudentForm();
            studentForm.ShowDialog();
            RefreashListBox();
        }

        public void RefreashListBox()
        {
            studentsListbox.Items.Clear();
            List<StudentDTO> studentDTOs = new List<StudentDTO>();
            foreach (var item in repository.GetStudents())
            {
                studentDTOs.Add(new StudentDTO() { Name = item.Name, SurName = item.SurName });
            }

            foreach (var item in studentDTOs)
            {
                studentsListbox.Items.Add(item.Name + " " + item.SurName);
            }
        }
    }
}
