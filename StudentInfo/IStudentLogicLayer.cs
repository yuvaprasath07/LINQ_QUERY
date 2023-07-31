using StudentInfo.StudentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfo
{
    public interface IStudentLogicLayer
    {
        public List<colour> getAll();

        public object GetProduct();
    }
}
