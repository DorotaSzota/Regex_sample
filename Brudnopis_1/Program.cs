using System.Text.RegularExpressions;

namespace Brudnopis_1
{
    internal class Program
    {
        public static List<string> list = new List<string>();
        
        static void Main(string[] args)
        {
            Console.Title ="Email check";

            //adding items to the list
            list.Add("dkowalski9@gmail.com");
            list.Add("elopomelo123@icloud.com");
            list.Add("yahoo@yahoo.com");
            list.Add("hammy@chubby");

            foreach (var item in list) { Console.WriteLine(item); }

            // creating a regular expression (this one was found on StackOverflow) to validate elements of the List.
            string reg1 = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            Regex regex = new Regex(reg1);
            
            foreach (var item in list) 
            {
                if (regex.IsMatch(item)) 
                { MatchCollection match1 = regex.Matches(item);
                    Console.WriteLine($"{list.IndexOf(item)} is a valid email address!");
                }
                else { Console.WriteLine($"{list.IndexOf(item)} is not an email address :("); }
                

            }


        }
    }
        
}