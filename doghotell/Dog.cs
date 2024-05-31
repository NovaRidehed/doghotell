using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doghotell
{
    internal class Dog
    {
        public string name;
        public string chipNumber;
        public Owner owner;
        public List<Meal> mealList;
        public Visit visit;

        public Dog(string n, string c, Owner o, Visit visit)
        {
            name = n;
            chipNumber = c;
            owner = o;
            mealList = new List<Meal>();
            this.visit = visit;
        }
        internal string GetName()
        {
            return name;
        }  
        internal string GetOwner()
        {
            string fn = owner.firstName;
            string ln = owner.lastName;
            string a = owner.GetAddress();
            string OWNER = fn + " " + ln + ", " + a;
            return OWNER;
        }
        public void AddMeal(Meal meal)
        {
            mealList.Add(meal);
        }
    }
}
