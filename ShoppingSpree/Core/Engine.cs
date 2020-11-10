
using ShoppingSpree.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree.Core
{
    //тук разписваме бизнес логиката (класа по конвенция си се казва Engine) This class :
    //Read data from the console
    //Process data -> Manipulate, save to db
    //Print data on the console
    
    public class Engine
    {
        private readonly ICollection<Person> people;
        private readonly ICollection<Product> products;
        public Engine()
        {
            this.people = new List<Person>();
            this.products = new List<Product>();
        }

        public void Run()//това е метод за стартиране на енджина!
        {
            //Place business logic here
            try
            {
                this.ParsePeopleInput();
                this.ParseProductsInput();

                while (true)
                {
                    string command = Console.ReadLine();
                    if (command=="END")
                    {
                        break;
                    }
                    string[] splittedCommand = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    string personName = splittedCommand[0];
                    string productName = splittedCommand[1];
                    Person person = this.people.FirstOrDefault(people => people.Name == personName);
                    Product product = this.products.FirstOrDefault(products => products.Name == productName);
                    if (person!=null&&product!=null)
                    {
                        string result = person.BuyProduct(product);
                        Console.WriteLine(result);
                    }
                }

                foreach (var person in people)
                {
                    Console.WriteLine(person);
                }

            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
        private void ParsePeopleInput()
        {
            string[] peopleArgs = Console.ReadLine().Split(";");
            foreach (string personStr in peopleArgs)
            {
                string[] personArgs = personStr.Split('=');
                string personName = personArgs[0];
                decimal personMoney = decimal.Parse(personArgs[1]);
                //We may have an exception и е хубаво да си го трай кечнем, но първо да си го изведем в метод!
                Person person = new Person(personName, personMoney);
                this.people.Add(person);
            }
        }

        private void ParseProductsInput()
        {
            string[] productsArgs = Console.ReadLine().Split(";");
            foreach (string productStr in productsArgs)
            {
                string[] personArgs = productStr.Split('=');
                string productName = personArgs[0];
                decimal productCost = decimal.Parse(personArgs[1]);

                Product product = new Product(productName, productCost);
                this.products.Add(product);
            }
        }
    }
}
