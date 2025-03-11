using System;
using System.Collections.Generic;

namespace WindowsFormsApp1
{
    // คลาสสำหรับเก็บข้อมูลอาจารย์ที่ปรึกษา
    public class Advisor
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Department { get; set; }

        public Advisor(string name, string surname, string department)
        {
            Name = name;
            Surname = surname;
            Department = department;
        }

        public override string ToString()
        {
            return $"{Name} {Surname} ({Department})";
        }
    }

    // คลาสสำหรับจัดการรายการอาจารย์ที่ปรึกษา
    public class AdvisorManager
    {
        private List<Advisor> advisorList = new List<Advisor>();

        // เพิ่มอาจารย์ที่ปรึกษาเข้าไปใน List
        public void AddAdvisor(string name, string surname, string department)
        {
            advisorList.Add(new Advisor(name, surname, department));
        }

        // ดึงรายการอาจารย์ที่ปรึกษา
        public List<Advisor> GetAdvisors()
        {
            return advisorList;
        }
    }
}
