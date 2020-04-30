using System;
using System.Collections.Generic;
using System.Text;

namespace Калькулятор_исключения
{

    public class ValidationAttribute : System.Attribute
    {
        public double FirstValue { get; set; }

        public ValidationAttribute()
        { }

        public ValidationAttribute(double FirstValue)
        {
            FirstValue = FirstValue;
        }

    }
}
