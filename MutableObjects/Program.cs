using System;
using System.Collections.Generic;

namespace RecursionProperty
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog sharo = new Dog(new Dog());
            Console.WriteLine(sharo.Friends[0]);
            var sharoFriends = sharo.Friends;
            sharoFriends[0] = null;
            Console.WriteLine(sharo.Friends[0]);
        }
    }
    class Dog
    {

        private List<Dog> friends;

        public Dog(Dog friend = null)
        {
            friends = new List<Dog>()
            {
                friend,//.AsReadOnly(); и ще гърми ако някой се опита да го промени!
            };
        }

        public List<Dog> Friends //IReadOnlyCollection вместо List и е енкапсулино! (това е интерфейс, който листа наследява)
        {
            get
            {
                return this.friends;//като върнем референтен тип така, стойността се взима по референция и стойността всеки може да я променя, екапсулация няма! За да нямаме този проблем трябва да използваме IReadOnlyCollection за да енкапсулираме колекции!
            } 
        }
    }
}
