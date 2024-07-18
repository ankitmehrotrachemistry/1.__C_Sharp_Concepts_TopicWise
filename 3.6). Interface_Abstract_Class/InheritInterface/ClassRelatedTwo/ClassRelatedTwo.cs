using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRelatedTwo
{
    class Attributes
    {
        protected double weight;
        protected double height;
        public void setWeight(double w)
        {
            weight = w;
        }
        public void setHeight(double h)
        {
            height = h;
        }
    }

    public interface RetrieveAge
    {
        double retrieveAge(double age);
    }

    class BMI : Attributes, RetrieveAge
    {
        public double retrieveBMI()
        {
            return (weight / (height * height));
        }

        public double retrieveHeight()
        {
            return height;
        }

        public double retrieveWeight()
        {
            return weight;
        }

        public double retrieveAge(double age)
        {
            return age;
        }
    }

    class TotalBMI
    {
        static void Main()
        {
            BMI bmi = new BMI();
            bmi.setWeight(80);
            bmi.setHeight(2.07);

            Console.WriteLine("Your Height: {0} m", bmi.retrieveHeight());
            Console.WriteLine("Your Weight: {0} kg", bmi.retrieveWeight());
            Console.WriteLine("BMI: {0}", bmi.retrieveBMI());
            Console.WriteLine("Age: {0}", bmi.retrieveAge(40));
        }
    }
}
