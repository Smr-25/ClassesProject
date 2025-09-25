// See https://aka.ms/new-console-template for more information
using ClassesCode;

DoctorService doctorService = new();
Console.WriteLine("Welcome");

while (true) { 
    
    Console.WriteLine();
    Console.WriteLine("1. Add Doctors");
    Console.WriteLine("2. Show Doctors");
    Console.WriteLine("3. Search by Full Name");
    Console.WriteLine("4. Sort Doctor for Age");
    Console.WriteLine("5. Get Avarage by Age");
    Console.WriteLine("6. Quit");
    Console.WriteLine();
    Console.WriteLine("Please enter option number: ");
    string op = Console.ReadLine();
    switch (op)
    {
        case "1":
            Console.WriteLine("Input full name");
        FullName: string fullName = Console.ReadLine();

            bool isText = fullName.All(char.IsLetter);
            if (!isText)
            {
                Console.WriteLine("Incorrect Full Name");
                goto FullName;

            }

            Console.WriteLine("Input Age");
        Age: string input1 = Console.ReadLine();

            bool isNumber = int.TryParse(input1, out int age);

            if (!isNumber || age < 20 || age > 65)
            {
                Console.WriteLine("Incorrect age");
                goto Age;
            }

            Console.WriteLine("Input Email");
        Email: string email = Console.ReadLine();

            //bool isCorrectEmail = email.Contains("@") || email.Substring(email.IndexOf("@")).Contains(".");
            //if (!isCorrectEmail)
            //{
            //    Console.WriteLine("Incorrect Email");
            //    goto Email;

            //}
            Console.WriteLine("Input Address");
            string address = Console.ReadLine();
            doctorService.Add(fullName, age, email, address);
            break;
        case "2":
            Console.WriteLine();
            doctorService.ShowAllDoctors();
            break;
        case "3":
            Console.WriteLine("Input Text");
        SearchText: string searchingTxt = Console.ReadLine();

            bool isSearchingText = searchingTxt.All(char.IsLetter);
            if (!isSearchingText)
            {
                Console.WriteLine("Incorrect Text");
                goto SearchText;

            }

            doctorService.SearchByFullName(doctorService.GetAll(),searchingTxt);
            break;
        case "4":
            Console.WriteLine("Input asc or desc");
         KeyValue: string keyValue = Console.ReadLine();

            bool isKeyValue = keyValue.All(char.IsLetter);
            if (!isKeyValue)
            {
                Console.WriteLine("Incorrect Option");
                goto KeyValue;

            }

            doctorService.SortByAge(doctorService.GetAll(), keyValue);
            Console.WriteLine();
            break;

        case "5":
            double result = doctorService.GetAvarageByAge(doctorService.GetAll());
            Console.WriteLine(result);
            break;
        case "6":
            return;
        default:
            Console.WriteLine("Incorrect option");
            break;
    }

}











