using Newtonsoft.Json;
using StudentInfo.StudentModel;
using System.Drawing;

namespace StudentInfo
{
    public class StudentLogicLayer : IStudentLogicLayer
    {
        public List<colour> getAll()
        {
            string filepath = @"D:\Csharpwork\student.json";
            string read = File.ReadAllText(filepath);
            List<Student> products = JsonConvert.DeserializeObject<List<Student>>(read);

            var studetRecord = products.GroupBy(a => a.Color);
            List<colour> Color = new List<colour>();

            foreach (var color in studetRecord)
            {

                colour type = new colour
                {
                    colorName = color.Key,
                    ColourType = color.ToList()
              
                };
                Color.Add(type);
            }
            return Color;

        }

        public object GetProduct()
        {
            string filepath = @"D:\Csharpwork\sampledatafoodsales.json";
            string read = File.ReadAllText(filepath);
            List<product> sampledatafoodsales = JsonConvert.DeserializeObject<List<product>>(read);

            var food = sampledatafoodsales.Where(a => a.Product == "Carrot" && a.TotalPrice<=100 ).ToList();

            var carrotproduct = food.GroupBy(a => a.City).Select(x => new
            {
                City = x.Key,
                TotalQuantity = x.Sum(a => a.Qty),
                TotalPrice = x.Sum(a => a.TotalPrice),
                MaximumPrice = x.Max(a => a.TotalPrice),
                MinumunPrice = x.Min(a => a.TotalPrice),
                Average = x.Average(a => a.TotalPrice)
            });
            
            
            

            return carrotproduct;
        }
    }
}