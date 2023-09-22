﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryCircus.Enums;

namespace ClassLibraryCircus.Classes
{
    public class InitializeAnimal
    {
        private readonly AnimalGenerator _animalGenerator = new();

        public static void MakeDummyContentAnimals(Train train)
        {
            train.Animals.Add(new Animal(AnimalType.Carnivore, AnimalSize.Small));
            train.Animals.Add(new Animal(AnimalType.Carnivore, AnimalSize.Small));
            train.Animals.Add(new Animal(AnimalType.Carnivore, AnimalSize.Small));

            train.Animals.Add(new Animal(AnimalType.Herbivore, AnimalSize.Large));
            train.Animals.Add(new Animal(AnimalType.Herbivore, AnimalSize.Large));
            train.Animals.Add(new Animal(AnimalType.Herbivore, AnimalSize.Large));

            train.Animals.Add(new Animal(AnimalType.Herbivore, AnimalSize.Medium));
            train.Animals.Add(new Animal(AnimalType.Herbivore, AnimalSize.Medium));
        }

        private void MakeAnimals(Train train)
        {
            _animalGenerator.MakeRandomAnimals(train);
        }
    }
}
