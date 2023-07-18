using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temaweek4
{
    public class Student
    {
        public Student( string nume, string prenume, int stundetId, double gpa) 
        
        {
            FirstName = nume;
            LastName = prenume;
            StudentId = stundetId;
            GPA = gpa;
        
        }

        public string FirstName;
        public string LastName;
        public int StudentId;
        public double GPA;


    public string GetFullName()
        {
            return (FirstName +" "+ LastName);
        }

        public bool HasHonors()
        {
            return GPA>3.5;
        } 




    }
}
