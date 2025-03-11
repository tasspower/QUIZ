using System;
using System.Windows.Forms;

namespace StudentAdvisorApp
{
    static class Program
    {
        // The main entry point for the application.
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm()); // เรียกใช้งาน MainForm ซึ่งเป็นฟอร์มหลักของโปรแกรม
        }
    }
}
namespace StudentAdvisorApp
{ 
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ข้อมูลนักศึกษา = new System.Windows.Forms.Label();
            this.ชื่อหน้า = new System.Windows.Forms.Label();
            this.นามสกุลหน้า = new System.Windows.Forms.Label();
            this.รหัสนักศึกษาหน้า = new System.Windows.Forms.Label();
            this.สาขาที่เรียนหน้า = new System.Windows.Forms.Label();
            this.อาจารย์ที่ปรึกษาหน้า = new System.Windows.Forms.Label();
            this.คะแนนเกรดเฉลี่ยหน้า = new System.Windows.Forms.Label();
            this.textBoxStudentName = new System.Windows.Forms.TextBox();
            this.textBoxStudentSurname = new System.Windows.Forms.TextBox();
            this.textBoxStudentID = new System.Windows.Forms.TextBox();
            this.textBoxStudentMajor = new System.Windows.Forms.TextBox();
            this.textBoxStudentPoin = new System.Windows.Forms.TextBox();
            this.ชื่อหลัง = new System.Windows.Forms.Label();
            this.นามสกุลหลัง = new System.Windows.Forms.Label();
            this.สาขาที่สอนหลัง = new System.Windows.Forms.Label();
            this.รายชื่อนักศึกษาที่อยู่ในที่ปรึกษาหลัง = new System.Windows.Forms.Label();
            this.ข้อมูลอาจารย์ที่ปรึกษา = new System.Windows.Forms.Label();
            this.textBoxAdvisorName = new System.Windows.Forms.TextBox();
            this.textBoxAdvisorSurname = new System.Windows.Forms.TextBox();
            this.textBoxAdvisorDepartment = new System.Windows.Forms.TextBox();
            this.buttonAddStudent = new System.Windows.Forms.Button();
            this.buttonAddAdvisor = new System.Windows.Forms.Button();
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxStudentAdvisor = new System.Windows.Forms.TextBox();
            this.textBoxAdvisorStudent = new System.Windows.Forms.TextBox();
            this.dataGridViewAdvisor = new System.Windows.Forms.DataGridView();
            this.colAdvisorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAdvisorSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAdvisorDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAdvisorStudents = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdvisor)).BeginInit();
            this.SuspendLayout();
            // 
            // ข้อมูลนักศึกษา
            // 
            this.ข้อมูลนักศึกษา.AutoSize = true;
            this.ข้อมูลนักศึกษา.Location = new System.Drawing.Point(26, 44);
            this.ข้อมูลนักศึกษา.Name = "ข้อมูลนักศึกษา";
            this.ข้อมูลนักศึกษา.Size = new System.Drawing.Size(133, 16);
            this.ข้อมูลนักศึกษา.TabIndex = 0;
            this.ข้อมูลนักศึกษา.Text = "ข้อมูลนักศึกษา ( Student )";
            // 
            // ชื่อหน้า
            // 
            this.ชื่อหน้า.AutoSize = true;
            this.ชื่อหน้า.Location = new System.Drawing.Point(134, 81);
            this.ชื่อหน้า.Name = "ชื่อหน้า";
            this.ชื่อหน้า.Size = new System.Drawing.Size(20, 16);
            this.ชื่อหน้า.TabIndex = 1;
            this.ชื่อหน้า.Text = "ชื่อ";
            // 
            // นามสกุลหน้า
            // 
            this.นามสกุลหน้า.AutoSize = true;
            this.นามสกุลหน้า.Location = new System.Drawing.Point(109, 116);
            this.นามสกุลหน้า.Name = "นามสกุลหน้า";
            this.นามสกุลหน้า.Size = new System.Drawing.Size(45, 16);
            this.นามสกุลหน้า.TabIndex = 2;
            this.นามสกุลหน้า.Text = "นามสกุล";
            // 
            // รหัสนักศึกษาหน้า
            // 
            this.รหัสนักศึกษาหน้า.AutoSize = true;
            this.รหัสนักศึกษาหน้า.Location = new System.Drawing.Point(93, 148);
            this.รหัสนักศึกษาหน้า.Name = "รหัสนักศึกษาหน้า";
            this.รหัสนักศึกษาหน้า.Size = new System.Drawing.Size(66, 16);
            this.รหัสนักศึกษาหน้า.TabIndex = 3;
            this.รหัสนักศึกษาหน้า.Text = "รหัสนักศึกษา";
            // 
            // สาขาที่เรียนหน้า
            // 
            this.สาขาที่เรียนหน้า.AutoSize = true;
            this.สาขาที่เรียนหน้า.Location = new System.Drawing.Point(93, 182);
            this.สาขาที่เรียนหน้า.Name = "สาขาที่เรียนหน้า";
            this.สาขาที่เรียนหน้า.Size = new System.Drawing.Size(61, 16);
            this.สาขาที่เรียนหน้า.TabIndex = 4;
            this.สาขาที่เรียนหน้า.Text = "สาขาที่เรียน";
            // 
            // อาจารย์ที่ปรึกษาหน้า
            // 
            this.อาจารย์ที่ปรึกษาหน้า.AutoSize = true;
            this.อาจารย์ที่ปรึกษาหน้า.Location = new System.Drawing.Point(74, 219);
            this.อาจารย์ที่ปรึกษาหน้า.Name = "อาจารย์ที่ปรึกษาหน้า";
            this.อาจารย์ที่ปรึกษาหน้า.Size = new System.Drawing.Size(80, 16);
            this.อาจารย์ที่ปรึกษาหน้า.TabIndex = 5;
            this.อาจารย์ที่ปรึกษาหน้า.Text = "อาจารย์ที่ปรึกษา";
            // 
            // คะแนนเกรดเฉลี่ยหน้า
            // 
            this.คะแนนเกรดเฉลี่ยหน้า.AutoSize = true;
            this.คะแนนเกรดเฉลี่ยหน้า.Location = new System.Drawing.Point(69, 253);
            this.คะแนนเกรดเฉลี่ยหน้า.Name = "คะแนนเกรดเฉลี่ยหน้า";
            this.คะแนนเกรดเฉลี่ยหน้า.Size = new System.Drawing.Size(85, 16);
            this.คะแนนเกรดเฉลี่ยหน้า.TabIndex = 6;
            this.คะแนนเกรดเฉลี่ยหน้า.Text = "คะแนนเกรดเฉลี่ย";
            // 
            // textBoxStudentName
            // 
            this.textBoxStudentName.Location = new System.Drawing.Point(172, 78);
            this.textBoxStudentName.Name = "textBoxStudentName";
            this.textBoxStudentName.Size = new System.Drawing.Size(100, 22);
            this.textBoxStudentName.TabIndex = 7;
            this.textBoxStudentName.Text = " (  ใส่ชื่อครับ )";
            // 
            // textBoxStudentSurname
            // 
            this.textBoxStudentSurname.Location = new System.Drawing.Point(172, 116);
            this.textBoxStudentSurname.Name = "textBoxStudentSurname";
            this.textBoxStudentSurname.Size = new System.Drawing.Size(100, 22);
            this.textBoxStudentSurname.TabIndex = 8;
            this.textBoxStudentSurname.Text = " (  ใส่นามสกุลครับ )";
            // 
            // textBoxStudentID
            // 
            this.textBoxStudentID.Location = new System.Drawing.Point(172, 148);
            this.textBoxStudentID.Name = "textBoxStudentID";
            this.textBoxStudentID.Size = new System.Drawing.Size(100, 22);
            this.textBoxStudentID.TabIndex = 9;
            this.textBoxStudentID.Text = " (  ใส่รหัสครับ )";
            // 
            // textBoxStudentMajor
            // 
            this.textBoxStudentMajor.Location = new System.Drawing.Point(172, 182);
            this.textBoxStudentMajor.Name = "textBoxStudentMajor";
            this.textBoxStudentMajor.Size = new System.Drawing.Size(100, 22);
            this.textBoxStudentMajor.TabIndex = 10;
            this.textBoxStudentMajor.Text = " (  ใส่สาขาครับ )";
            // 
            // textBoxStudentPoin
            // 
            this.textBoxStudentPoin.Location = new System.Drawing.Point(172, 253);
            this.textBoxStudentPoin.Name = "textBoxStudentPoin";
            this.textBoxStudentPoin.Size = new System.Drawing.Size(100, 22);
            this.textBoxStudentPoin.TabIndex = 12;
            this.textBoxStudentPoin.Text = " (  ใส่คะแนนครับ )";
            // 
            // ชื่อหลัง
            // 
            this.ชื่อหลัง.AutoSize = true;
            this.ชื่อหลัง.Location = new System.Drawing.Point(604, 144);
            this.ชื่อหลัง.Name = "ชื่อหลัง";
            this.ชื่อหลัง.Size = new System.Drawing.Size(20, 16);
            this.ชื่อหลัง.TabIndex = 13;
            this.ชื่อหลัง.Text = "ชื่อ";
            // 
            // นามสกุลหลัง
            // 
            this.นามสกุลหลัง.AutoSize = true;
            this.นามสกุลหลัง.Location = new System.Drawing.Point(579, 179);
            this.นามสกุลหลัง.Name = "นามสกุลหลัง";
            this.นามสกุลหลัง.Size = new System.Drawing.Size(45, 16);
            this.นามสกุลหลัง.TabIndex = 14;
            this.นามสกุลหลัง.Text = "นามสกุล";
            // 
            // สาขาที่สอนหลัง
            // 
            this.สาขาที่สอนหลัง.AutoSize = true;
            this.สาขาที่สอนหลัง.Location = new System.Drawing.Point(565, 211);
            this.สาขาที่สอนหลัง.Name = "สาขาที่สอนหลัง";
            this.สาขาที่สอนหลัง.Size = new System.Drawing.Size(59, 16);
            this.สาขาที่สอนหลัง.TabIndex = 15;
            this.สาขาที่สอนหลัง.Text = "สาขาที่สอน";
            // 
            // รายชื่อนักศึกษาที่อยู่ในที่ปรึกษาหลัง
            // 
            this.รายชื่อนักศึกษาที่อยู่ในที่ปรึกษาหลัง.AutoSize = true;
            this.รายชื่อนักศึกษาที่อยู่ในที่ปรึกษาหลัง.Location = new System.Drawing.Point(478, 245);
            this.รายชื่อนักศึกษาที่อยู่ในที่ปรึกษาหลัง.Name = "รายชื่อนักศึกษาที่อยู่ในที่ปรึกษาหลัง";
            this.รายชื่อนักศึกษาที่อยู่ในที่ปรึกษาหลัง.Size = new System.Drawing.Size(146, 16);
            this.รายชื่อนักศึกษาที่อยู่ในที่ปรึกษาหลัง.TabIndex = 16;
            this.รายชื่อนักศึกษาที่อยู่ในที่ปรึกษาหลัง.Text = "รายชื่อนักศึกษาที่อยู่ในที่ปรึกษา";
            // 
            // ข้อมูลอาจารย์ที่ปรึกษา
            // 
            this.ข้อมูลอาจารย์ที่ปรึกษา.AutoSize = true;
            this.ข้อมูลอาจารย์ที่ปรึกษา.Location = new System.Drawing.Point(461, 107);
            this.ข้อมูลอาจารย์ที่ปรึกษา.Name = "ข้อมูลอาจารย์ที่ปรึกษา";
            this.ข้อมูลอาจารย์ที่ปรึกษา.Size = new System.Drawing.Size(163, 16);
            this.ข้อมูลอาจารย์ที่ปรึกษา.TabIndex = 19;
            this.ข้อมูลอาจารย์ที่ปรึกษา.Text = "ข้อมูลอาจารย์ที่ปรึกษา (Advisor)";
            // 
            // textBoxAdvisorName
            // 
            this.textBoxAdvisorName.Location = new System.Drawing.Point(630, 141);
            this.textBoxAdvisorName.Name = "textBoxAdvisorName";
            this.textBoxAdvisorName.Size = new System.Drawing.Size(100, 22);
            this.textBoxAdvisorName.TabIndex = 22;
            this.textBoxAdvisorName.Text = " (  ใส่ชื่อครับ )";
            // 
            // textBoxAdvisorSurname
            // 
            this.textBoxAdvisorSurname.Location = new System.Drawing.Point(630, 173);
            this.textBoxAdvisorSurname.Name = "textBoxAdvisorSurname";
            this.textBoxAdvisorSurname.Size = new System.Drawing.Size(100, 22);
            this.textBoxAdvisorSurname.TabIndex = 23;
            this.textBoxAdvisorSurname.Text = " (  ใส่นามสกุลครับ )";
            // 
            // textBoxAdvisorDepartment
            // 
            this.textBoxAdvisorDepartment.Location = new System.Drawing.Point(630, 208);
            this.textBoxAdvisorDepartment.Name = "textBoxAdvisorDepartment";
            this.textBoxAdvisorDepartment.Size = new System.Drawing.Size(100, 22);
            this.textBoxAdvisorDepartment.TabIndex = 24;
            this.textBoxAdvisorDepartment.Text = " (  ใส่สาขาครับ )";
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.Location = new System.Drawing.Point(72, 292);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(221, 23);
            this.buttonAddStudent.TabIndex = 25;
            this.buttonAddStudent.Text = "เพิ่มรายชื่อนักศึกษา";
            this.buttonAddStudent.UseVisualStyleBackColor = true;
            this.buttonAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // buttonAddAdvisor
            // 
            this.buttonAddAdvisor.Location = new System.Drawing.Point(481, 282);
            this.buttonAddAdvisor.Name = "buttonAddAdvisor";
            this.buttonAddAdvisor.Size = new System.Drawing.Size(143, 23);
            this.buttonAddAdvisor.TabIndex = 26;
            this.buttonAddAdvisor.Text = "เพิ่มรายชื่ออาจารย์";
            this.buttonAddAdvisor.UseVisualStyleBackColor = true;
            this.buttonAddAdvisor.Click += new System.EventHandler(this.btnAddAdvisor_Click);
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dataGridViewStudents.Location = new System.Drawing.Point(29, 326);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.RowHeadersWidth = 51;
            this.dataGridViewStudents.RowTemplate.Height = 24;
            this.dataGridViewStudents.Size = new System.Drawing.Size(786, 112);
            this.dataGridViewStudents.TabIndex = 27;
            this.dataGridViewStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudents_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ชื่อ";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "นามสกุล";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "รหัสนักศึกษา";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "สาขาที่เรียน";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "อาจารย์ที่ปรึกษา";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "คะแนนเกรดเฉลี่ย";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "ชื่อ ( อาจารย์ )";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "นามสกุล ( อาจารย์ )";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "สาขาที่สอน ( อาจารย์ )";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 125;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "รายชื่อนักศึกษาที่อยู่ในที่ปรึกษา ( อาจารย์ )";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 125;
            // 
            // textBoxStudentAdvisor
            // 
            this.textBoxStudentAdvisor.Location = new System.Drawing.Point(172, 220);
            this.textBoxStudentAdvisor.Name = "textBoxStudentAdvisor";
            this.textBoxStudentAdvisor.Size = new System.Drawing.Size(100, 22);
            this.textBoxStudentAdvisor.TabIndex = 28;
            this.textBoxStudentAdvisor.Text = " (  ใส่อาจารย์ครับ )";
            // 
            // textBoxAdvisorStudent
            // 
            this.textBoxAdvisorStudent.Location = new System.Drawing.Point(630, 245);
            this.textBoxAdvisorStudent.Name = "textBoxAdvisorStudent";
            this.textBoxAdvisorStudent.Size = new System.Drawing.Size(100, 22);
            this.textBoxAdvisorStudent.TabIndex = 29;
            this.textBoxAdvisorStudent.Text = " (  ใส่นักศึกษาครับ )";
            // 
            // dataGridViewAdvisor
            // 
            this.dataGridViewAdvisor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdvisor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAdvisorName,
            this.colAdvisorSurname,
            this.colAdvisorDepartment,
            this.colAdvisorStudents});
            this.dataGridViewAdvisor.Location = new System.Drawing.Point(278, 12);
            this.dataGridViewAdvisor.Name = "dataGridViewAdvisor";
            this.dataGridViewAdvisor.RowHeadersWidth = 51;
            this.dataGridViewAdvisor.RowTemplate.Height = 24;
            this.dataGridViewAdvisor.Size = new System.Drawing.Size(552, 85);
            this.dataGridViewAdvisor.TabIndex = 30;
            // 
            // colAdvisorName
            // 
            this.colAdvisorName.HeaderText = "ชื่อ";
            this.colAdvisorName.MinimumWidth = 6;
            this.colAdvisorName.Name = "colAdvisorName";
            this.colAdvisorName.ReadOnly = true;
            this.colAdvisorName.Width = 125;
            // 
            // colAdvisorSurname
            // 
            this.colAdvisorSurname.HeaderText = "นามสกุล";
            this.colAdvisorSurname.MinimumWidth = 6;
            this.colAdvisorSurname.Name = "colAdvisorSurname";
            this.colAdvisorSurname.ReadOnly = true;
            this.colAdvisorSurname.Width = 125;
            // 
            // colAdvisorDepartment
            // 
            this.colAdvisorDepartment.HeaderText = "สาขา";
            this.colAdvisorDepartment.MinimumWidth = 6;
            this.colAdvisorDepartment.Name = "colAdvisorDepartment";
            this.colAdvisorDepartment.ReadOnly = true;
            this.colAdvisorDepartment.Width = 125;
            // 
            // colAdvisorStudents
            // 
            this.colAdvisorStudents.HeaderText = "รายชื่อนักศึกษา";
            this.colAdvisorStudents.MinimumWidth = 6;
            this.colAdvisorStudents.Name = "colAdvisorStudents";
            this.colAdvisorStudents.ReadOnly = true;
            this.colAdvisorStudents.Width = 125;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 450);
            this.Controls.Add(this.dataGridViewAdvisor);
            this.Controls.Add(this.textBoxAdvisorStudent);
            this.Controls.Add(this.textBoxStudentAdvisor);
            this.Controls.Add(this.dataGridViewStudents);
            this.Controls.Add(this.buttonAddAdvisor);
            this.Controls.Add(this.buttonAddStudent);
            this.Controls.Add(this.textBoxAdvisorDepartment);
            this.Controls.Add(this.textBoxAdvisorSurname);
            this.Controls.Add(this.textBoxAdvisorName);
            this.Controls.Add(this.ข้อมูลอาจารย์ที่ปรึกษา);
            this.Controls.Add(this.รายชื่อนักศึกษาที่อยู่ในที่ปรึกษาหลัง);
            this.Controls.Add(this.สาขาที่สอนหลัง);
            this.Controls.Add(this.นามสกุลหลัง);
            this.Controls.Add(this.ชื่อหลัง);
            this.Controls.Add(this.textBoxStudentPoin);
            this.Controls.Add(this.textBoxStudentMajor);
            this.Controls.Add(this.textBoxStudentID);
            this.Controls.Add(this.textBoxStudentSurname);
            this.Controls.Add(this.textBoxStudentName);
            this.Controls.Add(this.คะแนนเกรดเฉลี่ยหน้า);
            this.Controls.Add(this.อาจารย์ที่ปรึกษาหน้า);
            this.Controls.Add(this.สาขาที่เรียนหน้า);
            this.Controls.Add(this.รหัสนักศึกษาหน้า);
            this.Controls.Add(this.นามสกุลหน้า);
            this.Controls.Add(this.ชื่อหน้า);
            this.Controls.Add(this.ข้อมูลนักศึกษา);
            this.Name = "MainForm";
            this.Text = "( ใส่ชื่อครับ )";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdvisor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ข้อมูลนักศึกษา;
        private System.Windows.Forms.Label ชื่อหน้า;
        private System.Windows.Forms.Label นามสกุลหน้า;
        private System.Windows.Forms.Label รหัสนักศึกษาหน้า;
        private System.Windows.Forms.Label สาขาที่เรียนหน้า;
        private System.Windows.Forms.Label อาจารย์ที่ปรึกษาหน้า;
        private System.Windows.Forms.Label คะแนนเกรดเฉลี่ยหน้า;
        private System.Windows.Forms.TextBox textBoxStudentName;
        private System.Windows.Forms.TextBox textBoxStudentSurname;
        private System.Windows.Forms.TextBox textBoxStudentID;
        private System.Windows.Forms.TextBox textBoxStudentMajor;
        private System.Windows.Forms.TextBox textBoxStudentPoin;
        private System.Windows.Forms.Label ชื่อหลัง;
        private System.Windows.Forms.Label นามสกุลหลัง;
        private System.Windows.Forms.Label สาขาที่สอนหลัง;
        private System.Windows.Forms.Label รายชื่อนักศึกษาที่อยู่ในที่ปรึกษาหลัง;
        private System.Windows.Forms.Label ข้อมูลอาจารย์ที่ปรึกษา;
        private System.Windows.Forms.TextBox textBoxAdvisorName;
        private System.Windows.Forms.TextBox textBoxAdvisorSurname;
        private System.Windows.Forms.TextBox textBoxAdvisorDepartment;
        private System.Windows.Forms.Button buttonAddStudent;
        private System.Windows.Forms.Button buttonAddAdvisor;
        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.TextBox textBoxStudentAdvisor;
        private System.Windows.Forms.TextBox textBoxAdvisorStudent;
        private DataGridView dataGridViewAdvisor;
        private DataGridViewTextBoxColumn colAdvisorName;
        private DataGridViewTextBoxColumn colAdvisorSurname;
        private DataGridViewTextBoxColumn colAdvisorDepartment;
        private DataGridViewTextBoxColumn colAdvisorStudents;
    }
}

