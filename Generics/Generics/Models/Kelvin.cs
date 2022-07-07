using System;
using System.Collections.Generic;
using System.Text;

namespace Generics.Models
{
    public class Kelvin
    {
        public double Degree { get; set; }

        public Kelvin(double degree)
        {
            Degree = degree;
        }
        
        //Bu formadada yaza bilerik eyni weydi))
        
        //public static implicit operator Celsius(Kelvin kelvin)
        //{
        //    return new Celsius(kelvin.Degree + 273.15);
        //}
    }
}
