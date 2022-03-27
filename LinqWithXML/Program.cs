using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinqWithXML
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentsXML =
                @"<Students>
                    <Student>
                        <Name>Toni</Name>
                        <Age>21</Age>
                        <University>Yale</University>
                        <YearOfStart>2022</YearOfStart>
                    </Student>
                    <Student>
                        <Name>Carla</Name>
                        <Age>17</Age>
                        <University>Yale</University>
                        <YearOfStart>2021</YearOfStart>
                    </Student>
                    <Student>
                        <Name>Leyla</Name>
                        <Age>19</Age>
                        <University>Beijing Tech</University>
                        <YearOfStart>2020</YearOfStart>
                    </Student>
                    <Student>
                        <Name>Adam</Name>
                        <Age>32</Age>
                        <University>BME</University>
                        <YearOfStart>2022</YearOfStart>
                    </Student>
                </Students>";

            XDocument studentsXdoc = new XDocument();
            studentsXdoc = XDocument.Parse(studentsXML);

            var students = from student in studentsXdoc.Descendants("Student")
                           select new
                           {
                               Name = student.Element("Name").Value,
                               Age = student.Element("Age").Value,
                               University = student.Element("University").Value,
                               YearOfStart = student.Element("YearOfStart").Value
                           };

            foreach(var student in students)
            {
                Console.WriteLine("Student {0} with age {1} from University {2} started in the year of {3}", 
                                    student.Name, student.Age, student.University, student.YearOfStart);
            }
            // from i in someInt orderby i select i
            var studentsSorted = from student in students 
                                 orderby student.Age 
                                 select student;

            Console.WriteLine("Sorted students by age: ");

            foreach(var student in studentsSorted)
            {
                Console.WriteLine("Student {0} with age {1} from University {2}", student.Name, student.Age, student.University);
            } 

            Console.ReadLine();

        }
    }
}
