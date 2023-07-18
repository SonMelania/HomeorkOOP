using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temaweek4
{
    public class University
    {

        public University(string univesitati) 
        
        {
            Name = univesitati;
        }

        public string Name;
        public List<Student> ListaStudenti=new List<Student>();
        public List<Faculty> Faculties=new List<Faculty>();

        public void AddStudent(Student std)
        {
            ListaStudenti.Add(std);
                
        }

        public void AddFaculty (Faculty faculty)
        {
            Faculties.Add(faculty);
        }
        public int GetStudentCount()
        {
            return ListaStudenti.Count;
        }
        public int GetFacultyCount()
        {
            return Faculties.Count;
        }

    }
}
