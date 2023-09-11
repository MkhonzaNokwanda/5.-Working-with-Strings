using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Working_with_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This will be in one line");
            Console.WriteLine("Skies are blue \n Roses are Red \n I Love You!");
            Console.WriteLine("Hi my name is \"Kwandenhle\"");

            //declarations
            string firstname = "Kwandenhle";
            string lastname = "Mudau";

            //the + is used to concatinate
            Console.WriteLine(firstname + " " + lastname);

            //functions on strings
            Console.WriteLine("The length of the name is " +firstname.Length);

            //Change name to uppercase,change last name to lowercase
            Console.WriteLine("Name as upper case " + firstname.ToUpper());
            Console.WriteLine("Last name as lower case " + lastname.ToLower());
            Console.WriteLine(firstname.Contains("kw"));

            //know the first letter of the name 
            Console.WriteLine("The first letter of the name is " + firstname[0]);

            //finding the position(index) of e
            Console.WriteLine("The position of e  is " + firstname.IndexOf("e"));
            //freeze console
            Console.ReadLine();
        }
    }
}
