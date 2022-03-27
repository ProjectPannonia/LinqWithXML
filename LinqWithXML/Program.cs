using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    </Student>
                    <Student>
                        <Name>Carla</Name>
                        <Age>17</Age>
                        <University>Yale</University>
                    </Student>
                    <Student>
                        <Name>Leyla</Name>
                        <Age>19</Age>
                        <University>Beijing Tech</University>
                    </Student>";
        }
    }
}
