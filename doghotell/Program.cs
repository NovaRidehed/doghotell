using System;

namespace doghotell
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DogHotel dogHotel = new DogHotel();
            AddTestData(dogHotel);
            dogHotel.PrintInfo();
            dogHotel.PrintFeedingSchedule();
            dogHotel.PrintPickups();
        }
        static void AddTestData(DogHotel dogHotel)
        {
            Address address1 = new Address("gatuadress1", "stad1", "postnummer1");
            Address address2 = new Address("gatuadress2", "stad2", "postnummer2");
            Address address3 = new Address("gatuadress3", "stad3", "postnummer3");
            DateTime dropoffTime1 = new DateTime(2024, 2, 4, 6, 0, 0);
            DateTime pickupTime1 = new DateTime(2024, 2, 20, 14, 30, 0);
            DateTime dropoffTime2 = new DateTime(2024, 5, 1, 10, 0, 0);
            DateTime pickupTime2 = new DateTime(2024, 5, 17, 20, 0, 0);
            DateTime dropoffTime3 = new DateTime(2024, 9, 30, 13, 30, 0);
            DateTime pickupTime3 = new DateTime(2024, 10, 12, 15, 0, 0);


            Visit visit1 = new Visit(dropoffTime1, pickupTime1);
            Visit visit2 = new Visit(dropoffTime2, pickupTime2);
            Visit visit3 = new Visit(dropoffTime3, pickupTime3);
            Owner Owner1 = new Owner("Karl", "Bertilsson", address1);
            Owner Owner2 = new Owner("Maria", "Simonsson", address2);
            Owner Owner3 = new Owner("Nova", "Ridehed", address3);
            Meal meal1 = new Meal(7, "Pedigree Adult Maxi Beef & Rice - två skopor");
            Meal meal2 = new Meal(20, "Doggy paté med kalkon - en burk");
            Meal meal3 = new Meal(14, "rått kött - 3 kg");
            Meal meal4 = new Meal(14, "");
            Dog Dog1 = new Dog("Fido", "123456", Owner1, visit1);
            Dog Dog2 = new Dog("Lassie", "654321", Owner2, visit2);
            Dog Dog3 = new Dog("Bosse", "027488", Owner3, visit3);
            dogHotel.SetDog(2, Dog1);
            dogHotel.SetDog(5, Dog2);
            dogHotel.SetDog(6, Dog3);
            Dog1.AddMeal(meal1);
            Dog1.AddMeal(meal2);
            Dog2.AddMeal(meal3);
            Dog3.AddMeal(meal4);
        }
    }
}