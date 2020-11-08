using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree.Common
{
   //static class можем да извикваме без да го инициализираме. Яде рам памет (живее за целия живот на програмата), но в много случаи е доста полезен!
    public static class GlobalConstants
    {
        public const string EmptyNameExsMsg = "Name cannot be empty";
        public const string NegativeMoneyExsMsg = "Money cannot be negative";  
    }
}
