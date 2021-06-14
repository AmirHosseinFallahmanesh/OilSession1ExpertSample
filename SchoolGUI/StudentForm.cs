using School.DAL;
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
    public partial class StudentForm : Form
    {
        StudentRepository studentRepository = new StudentRepository();
        public StudentForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string surname = surNameTextBox.Text;
            int age = int.Parse(ageTextBox.Text);
            studentRepository.AddStudent(name, surname, age);
            MessageBox.Show("Insert Student !!!","App sayes");
            this.Close();
        }
    }
}
