using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temaweek4
{
    public class Students
    {

        public string Name;
        public DateTime StartDate;
        public DateTime EndDate;
        public College Colage;
        public DateTime BirthDate;

        public Students(string nume, DateTime dataInceput, DateTime dataSfarsit, College colegiu, DateTime ziuadeNastere)

        {
            Name = nume;
            StartDate = dataInceput;
            EndDate = dataSfarsit;
            Colage = colegiu;
            BirthDate = ziuadeNastere;

        }

        public bool IsStillStudent()
        {
            if (StartDate < DateTime.Now && DateTime.Now < EndDate)
            {
                return true;
            }
            else return false;

        }

        public int GetAge()
        {
            var diferenta = DateTime.Now - BirthDate;
            return (int)(diferenta.TotalDays / 365);

        }
        private string GetPrint()
        {
            return $"Nume: {Name}\n Age: {GetAge()} \nStartDate: {StartDate} \nEndDate: {EndDate}\n Este student:{IsStillStudent()}\n Denumire Colegiu:{Colage.Name} ";
        }
        public void Print()
        {
            Console.Write(GetPrint());


        }

        public override string ToString()
        { 
            return GetPrint();
        }

    }
}
