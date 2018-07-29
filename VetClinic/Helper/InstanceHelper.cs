using System;
using System.Linq;
using System.Reflection;
using VetClinic.Attriubte;

namespace VetClinic.Helpers
{
    public static class InstanceHelper
    {
        public static T CreateInstance<T>()
        {
            // Pobierzemy wartość CreatePromptAttribute z klasy i ją wyswietlimy
            var classCreatePromptMessage = GetClassCreatePrompt<T>();
            Console.WriteLine(classCreatePromptMessage);

            // Stworzenie pustej instancji typu (Activator)
            var instance = Activator.CreateInstance<T>();

            // Pobranie wszystkich property, wyświetlenie prompt i pobranie wartość
            var properties = typeof(T).GetProperties();

            foreach (var property in properties)
            {
                if (!property.PropertyType.IsClass || property.PropertyType == typeof(string))
                {
                    // pobieramy wartość prompta i ją wypisujemy
                    var propertyCreatePromptMessage = GetPropertyCreatePrompt(property);
                    Console.WriteLine(propertyCreatePromptMessage);

                    // pobieramy wartość od użytkownika (console.readline)
                    var propertyValue = Console.ReadLine();

                    // Ustawiamy wartość property na instancji
                    var convertedPropertyValue = Convert.ChangeType(propertyValue, property.PropertyType);
                    property.SetValue(instance, convertedPropertyValue);
                }
                
            }

            return instance;
        }

        private static string GetPropertyCreatePrompt(PropertyInfo property)
        {
            var attribute = (CreatePromptAttribute)property.GetCustomAttributes(typeof(CreatePromptAttribute), false).FirstOrDefault();

            if (attribute == null)
            {
                return $"{property.Name}:";
            }
            else
            {
                return attribute.Prompt;
            }
        }

        private static string GetClassCreatePrompt<T>()
        {
            var attribute = (CreatePromptAttribute)typeof(T).GetCustomAttributes(typeof(CreatePromptAttribute), false).FirstOrDefault();

            if (attribute == null)
            {
                return $"Creating {typeof(T).Name}...";
            }
            else
            {
                return attribute.Prompt;
            }

        }
    }
}