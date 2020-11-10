using System;
using System.Collections;
using System.Collections.Generic;

using ShoppingSpree.Common;
namespace ShoppingSpree.Models
{
    public class Person
    {
        private const string NOT_ENOUGH_MONEY_MSG = "{0} can't afford {1}";
        private const string SUCC_BOUGHT_PRODUCT_MSG = "{0} bought {1}";
        private string name;
        private decimal money;
        private readonly ICollection<Product> bag;//това е интерфейс, който ще ни позволи да енкапсулираме за разлика от лист-а.

        //Var2 с вътрешен конструктор инициализиращ само листа и извикването му от долния с :this. Това ни позволява преизползването на код и се използва!
        private Person()
        {
            this.bag = new List<Product>();
        }
        public Person(string name, decimal money)
            :this () //с .this извикваме първо горния конструктор
        {
            //Var1
            //this.bag = new List<Product>();

            this.Name = name;
            this.Money = money;
        }
        public string  Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(GlobalConstants.EmptyNameExsMsg);
                }
                this.name = value;
            }
        }
        public decimal Money 
        {
            get
            {
                return this.money;
            }
            private set
            {
                if (value<0)
                {
                    throw new ArgumentException(GlobalConstants.NegativeMoneyExsMsg);
                }
                this.money = value;
            }
        }
        public IReadOnlyCollection<Product> Bag   
        {
            get 
            {
                return (IReadOnlyCollection<Product>)this.bag;//кастваме го към IReadOnlyCollection<Product> и работи, но вече енкапсулирано, за разлика от листа. По този начин сетер не ни трябва!
            }
        }

        public string BuyProduct(Product product)
        {
            if (this.Money<product.Cost)
            {
                return String.Format(NOT_ENOUGH_MONEY_MSG, this.Name, product.Name );
            }
            this.Money -= product.Cost;
            this.bag.Add(product);
            return String.Format(SUCC_BOUGHT_PRODUCT_MSG, this.Name, product.Name);

        }

        public override string ToString()
        {
            string productsOutput = this.Bag.Count > 0 ? String.Join(", ", this.Bag) : "Nothing bought";
            return $"{this.Name} - {productsOutput}";
        }
    }
}
