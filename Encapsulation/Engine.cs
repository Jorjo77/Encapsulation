using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    public class Engine 
    {
        private Oil oil;//тук като напишем Oil и Ctrl+. ще ни генерира файла (класа)!!!
        private Turbo turbo;

        private Karter karter;
        private Cilindri cilindri;
        public void Start()
        {
            oil.Use();//С Ctrl+. върху Use и ни генерира метода
            turbo.Start();
            //karter
            //cilindri
            //butala
        }

        public void Stop()
        {
            oil.Stop();//С Ctrl+. върху Use и ни генерира метода
            turbo.Stop();
            //karter
            //cilindri
            //butala
        }
        public void Accelerate()
        {

        }
    }
}
