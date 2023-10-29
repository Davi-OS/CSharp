using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curses.Entites
{
    internal class ProfessorAlex
    {
        List<Curso> cursos = new List<Curso>();
        HashSet<Students> studantesSet = new HashSet<Students>();

        public ProfessorAlex()
        {
            Curso A = new Curso();
            Curso B = new Curso();
            Curso C = new Curso();
            this.cursos.Add(A);
            this.cursos.Add(B);
            this.cursos.Add(C);
        }
        public int CountStudant()
        {
            foreach (Curso curso in cursos)
            {
                for (int i = 0; i < curso.StudentsOnCourse.Count; i++)
                {
                    studantesSet.Add(curso.StudentsOnCourse[i]);
                }
            }
            return studantesSet.Count();
        }
    }
}
