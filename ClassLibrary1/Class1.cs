using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public string ourStudentName;
        public string ourStudentFamili;
        public int ourStudenEge;
        public string ourNameVNZ;
        public int Price;
        public string ourCountry;
        public bool Prava;
        public static void Student() {
            Console.WriteLine("Введіть ім'я студента: ");
            string studentName = Console.ReadLine();
            Console.WriteLine("Введiть прізвище студента: ");
            string famili = Console.ReadLine();
            Console.WriteLine("Введiть вік студента: ");
            string ege = Console.ReadLine();
            Console.WriteLine("Введiть назву навчального закладу: ");
            string nameVNZ = Console.ReadLine();
            Console.WriteLine("Введiть ціну навчання за рік: ");
            string sPrice = Console.ReadLine();
            Console.WriteLine("Введiть країну навчання: ");
            string Country = Console.ReadLine();
            Console.Write("Мае водійські права?(t - так , n - ні) ");
            ConsoleKeyInfo keyPrava = Console.ReadKey();

            Class1 OurStudent = new Class1
            {
                ourStudentName = studentName,
                ourStudentFamili = famili,
                ourStudenEge = int.Parse(ege),
                ourNameVNZ = nameVNZ,
                Price = int.Parse(sPrice),
                ourCountry = Country,
                Prava = keyPrava.Key == ConsoleKey.T,
            };

            Console.WriteLine();
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Данi про об`ект: ");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("ім'я студента: " + OurStudent.ourStudentName);
            Console.WriteLine("прізвище студента: " + OurStudent.ourStudentFamili);
            Console.WriteLine("вік студента: " + OurStudent.ourStudenEge);
            Console.WriteLine("назва навчального закладу: " + OurStudent.ourNameVNZ);
            Console.WriteLine("Ціна навчання в рік: " + OurStudent.Price + "грн.");
            Console.WriteLine("Країна навчання: " + OurStudent.ourCountry);
            Console.WriteLine(OurStudent.Prava ? "Цей студент має водійські права" : "Цей студент не має водійських прав");
            Console.ReadKey();

        }
    }
}
