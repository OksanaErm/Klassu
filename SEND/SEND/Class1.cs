using System;

public class account_базаданныхсайта
{

    public class ValidationAttribute : System.Attribute
    {
        public string Name { get; set; }

        public ValidationAttribute()
        { }

        public ValidationAttribute(string name)
        {
            name = name;
        }
    }
  }
[ValidationAttribute(KristianBerg)]

{
    public string name { get; set; }
    public string login { get; set; }
   
    {
        name = KristianBerg;
        login=Kristian;
    }
}

