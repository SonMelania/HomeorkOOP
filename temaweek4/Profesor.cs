using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temaweek4
{
    public  class Profesor
    {
        public string Name;
        public string Faculty;
        public string specialization;
        public List<Students> Studenti=new List<Students>();



        public Profesor(string Name, string facultate, string specializare)
        {

            this.Name = Name;
            Faculty = facultate;
            specialization = specializare;
            


        }

        public Profesor (string nume,string facultate, string specializare, List<Students> studenti) 
        {
        
            Name = nume;
            Faculty = facultate;
            specialization = specializare;
            Studenti = studenti;
                 
        
        }


        public void Display()
        {

            Console.WriteLine($" Nume:{Name} Facultatea: {Faculty} ");

            Studenti.ForEach(x => Console.WriteLine(x));
        }
    }
}
