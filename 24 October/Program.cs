//using System.Threading.Channels;

//namespace _24_October
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
              //Task 1
//            List<Person> people = new List<Person>()
//            {
//                new Person("Muslum","Khalilov",19),
//                new Person("Tofiq","Nesibli",20),
//                new Person("Murad","Qemberov",24),
//                new Person("Nigar","Gulmaliyeva",22),
//                new Person("Murad","Xasaddinov",21)

//            };

//            Console.WriteLine("--------------------------\r\n Axtarilan adi daxil edin\r\n--------------------------");
//            String searchedName = Console.ReadLine().ToLower();
//            var nameIs = people.FindAll(p => p.Name.ToLower() == searchedName);
//            foreach (Person person in nameIs)
//            {
//                Console.WriteLine($"Name: {person.Name}\r\nSurname:{person.Surname}\r\nAge: {person.Age}");
//                Console.WriteLine("");

//            }

//            Console.WriteLine("--------------------------------------\r\n Soyadi ov ve ova ile biten insanlar:\r\n--------------------------------------");
//            Console.WriteLine("");
//            var searchedSurname = people.FindAll(p => p.Surname.EndsWith("ov") || p.Surname.EndsWith("ova"));
//            foreach (Person person in searchedSurname)
//            {

//                Console.WriteLine($"Name: {person.Name}\r\nSurname:{person.Surname}\r\nAge: {person.Age}");
//                Console.WriteLine("");
//            }

//            var searchedAge = people.FindAll(p => p.Age > 20);
//            Console.WriteLine("-------------------------\r\n Yasi 20+ olan insanlar:\r\n-------------------------");
//            Console.WriteLine("");
//            foreach (Person person in searchedAge)
//            {
//                Console.WriteLine($"Name: {person.Name}\r\nSurname:{person.Surname}\r\nAge: {person.Age}");
//                Console.WriteLine("");
//            }








              //Task 2
//            List<Exam> exams = new List<Exam>
//            {
//                new Exam{Subject="Informatika", ExamDuration=2,StartDate=DateTime.Now.AddHours(-5) },
//                new Exam{Subject="Fizika", ExamDuration=4,StartDate=DateTime.Now.AddDays(-10) },
//                new Exam{Subject="Riyaziyyat", ExamDuration=2,StartDate=DateTime.Now.AddHours(-1) },
//                new Exam{Subject="Kimya", ExamDuration=5,StartDate=DateTime.Now.AddDays(-8) }
//            };

//            Console.WriteLine("------------------------------------------------\r\n Son 1 hefte erzinde olan examlarin siyahisini:\r\n------------------------------------------------");
//            var ExamsLastSevenDays = exams.FindAll(e=>e.StartDate>=DateTime.Now.AddDays(-7));
//            foreach(Exam exam in ExamsLastSevenDays)
//            {
//                Console.WriteLine($"Subject: {exam.Subject}   |   Exam duration: {exam.ExamDuration}");
                
//            }

//            Console.WriteLine("--------------------------------------------\r\n 2 saatdan uzun ceken imtahanlarin siyahisi\r\n--------------------------------------------");
//            var ExamsLastingMoreThanTwoHours = exams.FindAll(p=>p.ExamDuration>2);
//            foreach (Exam exam in ExamsLastingMoreThanTwoHours)
//            {
//                Console.WriteLine($"Subject: {exam.Subject}   |   Exam duration: {exam.ExamDuration}");
//            }
//            Console.WriteLine("------------------------\r\n Hal-hazirda devam eden\r\n------------------------");
//            var OngoingExams = exams.FindAll(e => e.StartDate <= DateTime.Now.AddHours(2) && e.EndDate >= DateTime.Now);
//            foreach (Exam exam in OngoingExams)
//            {
//                Console.WriteLine($"Subject: {exam.Subject}   |   Exam duration: {exam.ExamDuration}");
//            }
//        }
//    }
//}