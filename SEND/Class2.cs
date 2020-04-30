using System;

public class account_базаданныхсайта
{
    [ValidationAttribute("KristianBerg")]

    public class ValidationAttribute : System.Attribute
    {
    }
    [ValidationAttribute(KristianBerg)]


    public string name { get; set; }
}


