using System;

namespace Udemy_Section_4_oppaver
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("waht is the temprature?");
            //int temprature = Convert.ToInt32(Console.ReadLine());

            //if (temprature < 10)
            //{
            //    Console.WriteLine("take the coat");
            //}

            //if (temprature == 10)
            //{
            //    Console.WriteLine("its's 10C");
            //}

            //if (temprature > 10 && temprature <20)
            //{
            //    Console.WriteLine("It's not to warm but not cold");
            //}

            //if (temprature > 20)
            //{
            //    Console.WriteLine("It's cozy and warm!");
            //}
            //Console.Read();

            //string numberAsStraing = "128";
            //int parsedValue;

            //bool success = int.TryParse(numberAsStraing, out parsedValue);

            //if (success)
            //{
            //    Console.WriteLine("parsing succesful");
            //}
            //else
            //{
            //    Console.WriteLine("Paring did not work");
            //}

            //login Challenge

            //    Console.WriteLine("login or register");
            //    string loginOrRegister = Console.ReadLine();
            //    string username;
            //    string password;
            //    var registerdusername = "user";
            //    var registerdpassword = "password";


            //    if (loginOrRegister == "login")
            //    {
            //        Console.WriteLine("Enter username");
            //        username = Console.ReadLine();
            //        Console.WriteLine("Enter Password");
            //        password = Console.ReadLine();
            //        if (username == registerdusername && password == registerdpassword)
            //        {
            //            login(registerdusername);
            //        }
            //        else
            //        {
            //            Console.WriteLine("Username or password was wrong!");
            //            Console.Read();


            //        }

            //    }
            //    else if (loginOrRegister == "register")
            //    {
            //        Console.WriteLine("Enter username");
            //        registerdusername = Console.ReadLine();
            //        Console.WriteLine("Enter Password");
            //        registerdpassword = Console.ReadLine();
            //        login(registerdusername);


            //    }
            //    else
            //    {
            //        Console.WriteLine("You did not ender login or register");
            //        Console.Read();
            //    }

            //}
            //public static void login(string registerdusername)
            //{
            //    Console.WriteLine($"you are loged in as {registerdusername}");
            //    Console.Read();
            //}
            //login challenge end;
            //switch statement;
            int age = int.Parse(Console.ReadLine());

            switch (age)
            {
                case 15:
                    Console.WriteLine("too young to party in the club");
                    break;

                case 25:
                    Console.WriteLine("go to go");
                    break;

                default:
                    Console.WriteLine("how old are you then?");
                    break;
            }
            //if statement challange2;

        }
    }
}
