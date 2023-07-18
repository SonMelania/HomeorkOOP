using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temaweek4
{
    public  class Book
    {

        public Book(string cartea, string autorul, int anul) 
        {


            Title = cartea;
            Author = autorul;
            Year = anul;



        }




        public string Title;
        public string Author;
        public int Year;

        public string GetTitle()
        {
            return Title;
        }

        public string GetAuthor()
        {
            return Author;
        }

        public int GetYaer()
        {
            return Year;
        }

        public void SetTitle(string title)
        {
            Title = title;
        }

        public void SetAuthor (string author)
        {
            Author = author;    
        }
        public void SetYear(int year)
        {
            Year = year;
        }
             
            
    }
}
