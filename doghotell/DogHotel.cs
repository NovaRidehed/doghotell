using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doghotell
{
    internal class DogHotel
    {
        public Dog[] dogArray = new Dog[10];
        double costPerNight = 300;

        public void SetDog(int cageNumber, Dog dog)
        {
            dogArray[cageNumber] = dog;
        }
        public Dog GetDog(int cageNumber)
        {
            return dogArray[cageNumber];
        }

        public void PrintInfo()
        {
            for (int i = 0; i < dogArray.Length; i++)
            {
                if (dogArray[i] != null)
                {
                    Console.WriteLine("Bur " + i + ": " + dogArray[i].GetName() + ", " + dogArray[i].GetOwner());
                }
            }
        }
        public void PrintFeedingSchedule()
        {
            for (int i = 0; i < 24; i++)
            {
                int t = 0;
                for (int j = 0; j < dogArray.Length; j++)
                {
                    Dog dog = dogArray[j];

                    if (dog != null)
                    {
                        foreach (Meal meal in dog.mealList)
                        {
                            if (meal.hourOfDay == i)
                            {
                                if (t == 0)
                                {
                                    Console.WriteLine("Tid: kl " + i);
                                    t++;
                                }
                                Console.WriteLine("Bur " + j + " - " + dog.GetName() + ": " + meal.foodType);
                            }
                        }
                    }
                }
            }
        }
        public void PrintPickups()
        {
            for(int i = 0; i < dogArray.Length; i++)
            {
                DateTime now = DateTime.Now;
                if(dogArray[i] != null)
                {
                    Dog dog = dogArray[i];
                    DateTime dropoff = dog.visit.dropoffTime;
                    DateTime pickup = dog.visit.pickupTime;
                    TimeSpan time = dropoff - now;
                    if(time.TotalSeconds < 0)
                    {
                        Console.WriteLine("Bur " + i + ": " + dog.GetName() + " - Hämta: " + pickup);
                    }
                    else
                    {
                        Console.WriteLine("Bur " + i + ": " + dog.GetName() + " - Lämna: " + dropoff + ". Hämta: " + pickup);
                    }
                }
            }
        }
    }
}


