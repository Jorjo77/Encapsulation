using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    public class Engine 
    {
        private Oil oil;//тук като напишем Oil и Ctrl+. ще ни генерира файла (класа)!!!
        public void Start()
        {
            oil.Use()//С Ctrl+. върху Use и ни генерира метода
        }

        public void Stop()
        {

        }
        public void Accelerate()
        {

        }
    }
}
