using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetClinic.Helper;
using VetClinic.Models;

namespace VetClinic.Factories
{
    public class AnimalFactory
    {
        private readonly InputHelper _inputHelper = new InputHelper();


        public Animal CreateAnimal()
        {
            Console.WriteLine("What animal do you want to create?");
            Console.WriteLine("1) Cat");
            Console.WriteLine("2) Dog");
            Console.WriteLine("3) Snake");
            var chosenAnimal = Console.ReadKey(true);
            Animal createdAnimal = null;
            switch (chosenAnimal.Key)
            {
                case ConsoleKey.D1:
                    createdAnimal = CreateCat();
                    break;
                case ConsoleKey.D2:
                    createdAnimal = CreateDog();
                    break;
                case ConsoleKey.D3:
                    createdAnimal = CreateSnake();
                    break;
                default:
                    Console.WriteLine("Wrong option chosen!");
                    break;
            }
            return createdAnimal;
        }

        private Animal CreateSnake()
        {
            var snake = new Snake();
            Console.WriteLine("Creating snake!");
            FillAnimalFields(snake);
            snake.Length = _inputHelper.GetIntFromConsole("Length: ");
            return snake;
        }

        private  Animal CreateDog()
        {
            var dog = new Dog();
            Console.WriteLine("Creating dog!");
            FillAnimalFields(dog);
            Console.WriteLine("Race:");
            dog.Race = Console.ReadLine();
            Console.WriteLine("Color:");
            dog.Color = Console.ReadLine();

            return dog;
        }

        private  Animal CreateCat()
        {
            var cat = new Cat();
            Console.WriteLine("Creating cat!");

            FillAnimalFields(cat);

            Console.WriteLine("Race:");
            cat.Race = Console.ReadLine();
            Console.WriteLine("Color:");
            cat.Color = Console.ReadLine();

            return cat;
        }

        private void FillAnimalFields(Animal animal)
        {
            Console.WriteLine("Name:");
            animal.Name = Console.ReadLine();
            animal.Age = _inputHelper.GetIntFromConsole("Age: ");
        }
    }
}
