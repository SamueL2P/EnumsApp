using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsApp.Types
{
    enum Devices
    {
        //If value not assigned to the members of enum, by default 0 is assigned to the first member. 
        //1 for second and so on incrementing by 1

        phone,    // 0
        tablet,   // 1
        computer, // 2

        //we can assign values to enum members manually also 
        headphones = 6,
    }
}
