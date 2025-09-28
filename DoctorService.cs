namespace ClassesCode
{

    internal class DoctorService
    {
        Doctor[] doctors = new Doctor[0];

        public void Add(string fullName,int age,string email,string address)
        {
            Doctor doctor = new()
            {
                FullName = fullName,
                Age = age,
                Email = email,
                Address = address

            };

            Doctor[] newArray = new Doctor[doctors.Length + 1];

            Array.Copy(doctors,newArray,doctors.Length);
            newArray[newArray.Length - 1] = doctor;
            doctors = newArray;

            Console.WriteLine();
            Console.WriteLine("Doctor Added");

        }

        public Doctor[] GetAll() { 
         
            return doctors;
        }

        public void ShowAllDoctors()
        {
            foreach (var dctr in doctors)
            {
                Console.WriteLine($"FullName: {dctr.FullName}, Age: {dctr.Age}, Email: {dctr.Email}, Address: {dctr.Address}");
            }
        }

        public void SearchByFullName(Doctor[] doctorArray, string searchingText)
        {
            foreach (var doctor in doctorArray)
            {
                if (doctor.FullName.Contains(searchingText.Trim(), StringComparison.OrdinalIgnoreCase))
                {

                    Console.WriteLine($"FullName: {doctor.FullName}, Age: {doctor.Age}, Email: {doctor.Email}, Address: {doctor.Address}");
                }
            }
        }

        public void SortByAge(Doctor[] doctorArray, string keyValue)
        {
            switch (keyValue)
            {
                case "asc":
                    Array.Sort(doctorArray, (d1, d2) => d1.Age.CompareTo(d2.Age));
                    Console.WriteLine("Sorted Ascending order");
                    break;

                case "desc":
                    Array.Sort(doctorArray, (d1, d2) => d2.Age.CompareTo(d1.Age));
                    Console.WriteLine("Sorted Descending order");
                    break;
                
            }
        }

        public int GetAvarageByAge(Doctor[] doctorArray)
        {
            int result = 0;
            foreach (var doctor in doctorArray)
            {
                result += doctor.Age;
            }
            return result / doctorArray.Length;
        }
    }

}
