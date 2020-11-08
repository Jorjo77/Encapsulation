using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBoxData
{
    public class Box
    {
        //това е част от надграждането, да си направим динамична константа (която може да си променя стойността). По конвенция константите са най-отгоре:
        private const string INVALIDE_SIDE_EXC_MDG = "{0} cannot be zero or negative.";
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length 
        {
            get 
            {
                return this.length;
            }
            private set
            {
                this.ValidateSide(value, nameof(Length));
                this.length = value;
            }
        }

        public double Width 
        {
            get
            {
                return this.width;
            }
            private set
            {
                this.ValidateSide(value, nameof(Width));
                this.width = value;
            } 
        }
        public double Height 
        {
            get
            {
                return this.height;
            }
            private set
            {
                this.ValidateSide(value, nameof(Height));
                this.height = value;
            }
        }
        //ще запишем инлайн метод с "гоус то (=>)", когато метод не прави друго освен да връща някаква стойност от пресмятане е препоръчително да се използва такъв инлайн метод (повдига четимостта в кода)!
        public double CalculateSurfaceArea() =>
            (2 * this.Length * this.Width) + this.CalculateLateralArea();

        public double CalculateLateralArea() =>
     (2 * this.Length * this.Height) + (2 * this.Width
    * this.Height);

        public double CalculateVolume() =>
        this.Length * this.Height * this.Width;
        private void ValidateSide(double side, string paramName)
        {
            if (side <= 0)
            {
                //throw new ArgumentException($"A box’s {paramName} should not be zero or a negative number!");
                //това можем да надградим по следния начин:
                throw new ArgumentException(String.Format (INVALIDE_SIDE_EXC_MDG, paramName));//този String.Format замества горе във плейсхолдера каквото му подадем, в случая paramName. Това е много удобно за да си правим динамични константи!
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb
                .AppendLine($"Surface Area - {CalculateSurfaceArea():f2}")
                .AppendLine($"Lateral Surface Area - {CalculateLateralArea():f2}")
                .AppendLine($"Volume - {CalculateVolume():f2}");
            return sb.ToString().TrimEnd();//винаги след .ToString() да слагам .TrimEnd(); за да махам празния ред който ми слага отдолу стринг билдера (за да не ми чупи резултата)
        }
    }
}
