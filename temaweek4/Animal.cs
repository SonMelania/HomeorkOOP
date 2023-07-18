using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temaweek4
{
    public  class Animal
    {


        public Animal(string numele, string specia, string rasa, int anul, string culoarea, int inaltimea, bool esteNueste ) 
        
             
        {
            Name = numele;
            Species = specia;
            Breed = rasa;
            Age = anul;
            Color = culoarea;
            Weight = inaltimea;
            IsSayedOrNeutered = esteNueste;
        }
        public string Name;
        public string Species;
        public string Breed;
        public int Age;
        public string Color;
        public int Weight;
        public bool IsSayedOrNeutered;

        public void SetName(string name)
        {
           Name = name;
           
        }
        public void SetSpecies(string species)
        {
            Species = species;
        }
        public void SetBreed(string breed)
        {
            Breed = breed;
        }

        public void SetAge(int age)
        {
            Age = age;
        }

        public void SetColor(string color)
        {
            Color = color;
        }

        public void SetWeight(int weight)
        {
            Weight = weight;
        }
        public void SetIsSpayedOrNeutered( bool isSpayedOrNeutered)
        {
            IsSayedOrNeutered= isSpayedOrNeutered;
        }

        public string GetSpecies()
        {
            return Species;
        }

        public string GetBreed()
        {
            return Breed;
        }
        public int GetAge()
        {
            return Age;
        }

        public string GetColor() 
        { 
            return Color;
        }

        public int SetWeight()
        {
            return Weight;
        }

        public string GetName()
        {
            return Name;

        }

        public bool GetIsSpayedOrNeutered() 
        {
            return IsSayedOrNeutered;
        }
    }
}
