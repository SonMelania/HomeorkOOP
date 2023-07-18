using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temaweek4
{
    public class Faculty
    {

        public Faculty(string nume, string prenume , int id, List<string> subiecteInvatate) 
                
        {
            firstName = nume;
            lastName = prenume;
            employeeID = id;
            subjectsTaught = subiecteInvatate;

        }

        public string firstName;
        public string lastName;
        public int employeeID;
        public List<string> subjectsTaught=new List<string>();

        public string GetFullName()
        {
            return firstName +" "+ lastName;
        }

        public List<string> GetSubjectsTaught()
        {
            return subjectsTaught;
        }


    }
}
