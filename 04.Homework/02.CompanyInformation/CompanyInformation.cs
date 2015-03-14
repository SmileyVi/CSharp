using System;

    class CompanyInformation
    {
        static void Main()
        {
            Console.WriteLine("Please enter company name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter company adress: ");
            string adress = Console.ReadLine();

            Console.WriteLine("Enter phone number: ");
            string phoneNum = Console.ReadLine();

            Console.WriteLine("Enter Fax: ");
            string fax = Console.ReadLine();

            Console.WriteLine("Enter website: ");
            string website = Console.ReadLine();

            Console.WriteLine("Enter manager's first and last name: ");
            string managersName = Console.ReadLine();

            Console.WriteLine("Enter manager's age: ");
            string age = Console.ReadLine();

            Console.WriteLine("Enter manager's phone number: ");
            string manPhone = Console.ReadLine();

            Console.WriteLine("\r\nCompany name: {0}\r\nAdress: {1}\r\nTel: {2}\n\rFax: {3}\r\nWeb site: {4}\r\nManager:{5}\r\n(age: {6}, tel.: {7})\r\n", name, adress,phoneNum,fax,website,managersName,age,manPhone);
                

        }
    }
