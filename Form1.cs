using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using WindowsFormsApp1;

namespace StudentAdvisorApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            string name = textBoxStudentName.Text;
            string surname = textBoxStudentSurname.Text;
            string studentID = textBoxStudentID.Text;
            string major = textBoxStudentMajor.Text;
            string Advisor = textBoxStudentAdvisor.Text;
            string Poin = textBoxStudentPoin.Text;

            if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(surname) &&
                !string.IsNullOrWhiteSpace(studentID) && !string.IsNullOrWhiteSpace(major))
            {
                dataGridViewStudents.Rows.Add(name, surname, studentID, major , Advisor, Poin);
                ClearStudentFields();
            }
            else
            {
                MessageBox.Show("กรุณากรอกข้อมูลนักศึกษาให้ครบถ้วน", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAddAdvisor_Click(object sender, EventArgs e)
        {
            string advisorName = textBoxAdvisorName.Text;
            string advisorSurname = textBoxAdvisorSurname.Text;
            string department = textBoxAdvisorDepartment.Text;
            string List  = textBoxAdvisorStudent.Text;

            if (!string.IsNullOrWhiteSpace(advisorName) && !string.IsNullOrWhiteSpace(advisorSurname) &&
                !string.IsNullOrWhiteSpace(department))
            {
                MessageBox.Show($"เพิ่มอาจารย์ที่ปรึกษา: {advisorName} {advisorSurname} (สาขา: {department})",
                    "เพิ่มอาจารย์", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridViewAdvisor.Rows.Add(advisorName, advisorSurname, department , List);
                ClearAdvisorFields();
            }
            else
            {
                MessageBox.Show("กรุณากรอกข้อมูลอาจารย์ให้ครบถ้วน", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ClearStudentFields()
        {
            textBoxStudentName.Clear();
            textBoxStudentSurname.Clear();
            textBoxStudentID.Clear();
            textBoxStudentMajor.Clear();
        }

        private void ClearAdvisorFields()
        {
            textBoxAdvisorName.Clear();
            textBoxAdvisorSurname.Clear();
            textBoxAdvisorDepartment.Clear();
        }

        private void dataGridViewStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}