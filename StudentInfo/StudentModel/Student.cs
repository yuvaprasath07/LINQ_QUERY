using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfo.StudentModel
{
    public class Student
    {
        public string? ID { get; set; }
        public string? Name { get; set; }
        public string? Gender { get; set; }
        public string? Class { get; set; }
        public string? Club { get; set; }
        public string? Persona { get; set; }
        public string? Crush { get; set; }
        public string? BreastSize { get; set; }
        public string? Strength { get; set; }
        public string? Hairstyle { get; set; }
        public string? Color { get; set; }
        public string? Stockings { get; set; }
        public string? Accessory { get; set; }
        public string? ScheduleTime { get; set; }
        public string? ScheduleDestination { get; set; }
        public string? ScheduleAction { get; set; }


    }


    public class colour
    {
        public string? colorName { get; set; }
        public List<Student>? ColourType { get; set; }
    }

    public class product
    {
        public string ID { get; set; }
        public double Date { get; set; }
        public string ?Region { get; set; }
        public string ?City { get; set; }
        public string? Category { get; set; }
        public string ?Product { get; set; }
        public double Qty { get; set; }
        public double UnitPrice { get; set; }
        public double TotalPrice { get; set; }
    }
}
