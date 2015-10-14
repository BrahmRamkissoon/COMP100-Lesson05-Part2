using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP100_Lesson05_Part2
{
    class Program
    {
        enum WeekDay { SUNDAY=1, MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY };

        const double HST = 0.13d;

        static void Main ( string [] args )
        {
            int age;
            int day;

            day = (int)WeekDay.SUNDAY;
            Console.WriteLine( "Enter your age: " );
            age = Convert.ToInt32( Console.ReadLine() );


            Console.WriteLine( (int)WeekDay.SUNDAY);

            Console.WriteLine( "Press any key to exit..." );
            Console.ReadKey();
            


        }
    }
}
