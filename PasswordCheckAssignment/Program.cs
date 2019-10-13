using System;


namespace PasswordCheckAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            ineligible:
            string name = "Oliver";
            string Password = "Oliver8677";
            string _Password;
            string _name;
            int _code;
            Console.WriteLine("Enter Name and Password");
            bool isLooping = false;
            do
            {
                _name = Console.ReadLine();
                _Password = Console.ReadLine();

                if(_name == name &&  (_Password == Password))
                {
                    Console.WriteLine("Welcome... Lets Continue");
                    break;
                }
                else
                {
                    isLooping = true;
                    Console.WriteLine("Sorry Try Again");
                }
            } while (isLooping);

            Random rand = new Random();
            int code = rand.Next(10, 1000);
            Console.WriteLine($"Enter This Code below {code}");

            do
            {
                _code = Convert.ToInt32(Console.ReadLine());
                if(_code == code)
                {
                    Console.WriteLine("Your Login Is A success");
                }
                else
                {
                    Console.WriteLine("Sorry Please Try Again");
                    isLooping = true;
                    goto ineligible;
                }
            } while (isLooping);

        }
    }
}
