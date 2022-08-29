﻿using AnimalAdoptionCenter.Models;

namespace AnimalAdoptionCenter.Services
{
    public class TempDataReposService : ITempDataReposService
    {
        public IEnumerable<Animal> GetAllAnimals()
        {
            return IntiailzieAnimalz();
        }

        private IEnumerable<Animal> IntiailzieAnimalz()
        {
            return new List<Animal>
            {
                new Animal
                {
                    Name = "bob",
                    Age = 3,
                    Breed = "Dalmaty",
                    AnimalSex = Models.Enums.Sex.Male,
                    AnimalSize = Models.Enums.Size.Avarage,
                    AnimalStatus = Models.Enums.Status.Ready_For_Adoption,
                },
                new Animal
                {
                    Name = "dan",
                    Age = 4,
                    Breed = "dani",
                    AnimalSex = Models.Enums.Sex.Male,
                    AnimalSize = Models.Enums.Size.Avarage,
                    AnimalStatus = Models.Enums.Status.Ready_For_Adoption,
                }
            };
        }
    }
}
