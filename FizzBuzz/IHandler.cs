﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz;

public interface IHandler
{
    IHandler SetNext(IHandler handler);
    string Handle(int request);
}
