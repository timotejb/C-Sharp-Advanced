using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.OOP.Class4.Exercise.Classes
{
    public class PetStore<T> where T : Pet
    {
        public List<T>? Pets { get; set; }

        public void PrintPets(List<T> pets)
        {
            foreach (T pet in pets)
            {
                Console.WriteLine(pet);
            }
        }
        public void BuyPet(string name)
        {
            T pet = Pets.FirstOrDefault(x => x.Name == name);
           if(pet != null)  
           {
                Pets.Remove(pet);
                Console.WriteLine("Successfull buy");
           }
           else
                Console.WriteLine("Pet doesn't exist");
        }
      


    }
}
