using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz;

public class FizzHandler : Handler
{
    public override string Handle(int request)
    {
        if (request % 3 == 0 && request % 5 != 0)
        {
            return "Fizz";
        }
        return base.Handle(request);
    }
}
