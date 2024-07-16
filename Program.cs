using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnumsApp.Types;


namespace EnumsApp
{
    internal class Program
    {

        //enums is user defined data type that has a fixed set of values 

        //enums are generally defined seperately in c# in another file ie :-EnumsApp --> Types --> Enum file

        static void Main(string[] args)
        {
            Devices Device = Devices.phone ; //accessing enum member 
            Console.WriteLine("Device : "+Device);

            int computerNumber = (int)Devices.computer; //type casting , accessing default value
            Console.WriteLine("Computer number : "+computerNumber);

            int headphoneNumber = (int)Devices.headphones; //accessing given value
            Console.WriteLine("Headphone number : "+headphoneNumber); 


        }
    }
}
