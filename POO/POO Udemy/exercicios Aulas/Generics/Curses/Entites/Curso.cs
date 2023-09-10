using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curses.Entites
{
    internal class Curso
    {
        public List<Students> StudentsOnCourse { get; set; }

        public Curso()
        {
            StudentsOnCourse=new List<Students>();
        }
        public void AddStudent(Students student)
        {
            StudentsOnCourse.Add(student);
        }
    }
}
