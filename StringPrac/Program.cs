using System;
using Microsoft.VisualBasic;

namespace StringPrac
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Asia Gault ";
            Console.WriteLine("Trim: '{0}'", fullName.Trim());//got rid of space at end
            Console.WriteLine("Trim: '{0}'", fullName.ToUpper());//Each method on string class return new string bec string=immutable

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);// up to index of space
            var lastName = fullName.Substring(index + 1);

            Console.WriteLine("First Name: " + firstName);
            Console.WriteLine("Last Name: " + lastName);

            // can make splitting easier by using the split method

            var names = fullName.Split(' ');
            Console.WriteLine("First Name: " + names[0]);
            Console.WriteLine("Last Name: " +  names[1]);
            
            //Replace
            Console.WriteLine("First Names: "+ fullName.Replace("Asia", "Asia Shalin"));
            Console.WriteLine("A To Uppercase: "+fullName.Replace("a", "A"));

            //Empty or Null Strings
            //new version gets rid of empty/whitespace: no need to trim
            if (String.IsNullOrWhiteSpace(" "))// (String.IsNullOrEmpty(" ".Trim())) trim gets rid of empty space so returns null
            {
                Console.WriteLine("Invalid");
            }
            //# to strings:

            var str = "30";
            var age = Convert.ToByte(str);
            Console.WriteLine(age);

            float price = 29.95f;
            Console.WriteLine(price.ToString("C"));//decimal points
            Console.WriteLine(price.ToString("C0")); //rounds to 30$


        }
    }
}
