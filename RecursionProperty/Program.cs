using System;

namespace RecursionProperty
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Dog().Age);
        }
    }
    class Dog
    {
       //това е безкрайна рекурсия, грешката е Stack Overflow, трябва да внимаваме с тази грешка че трудно се забелязва!
        public int Age 
        { get 
            { 
                return Age; 
            }  
        }
    }
}
