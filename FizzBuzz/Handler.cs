using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz;

public abstract class Handler : IHandler
{
    private IHandler? _nextHandler;

    public IHandler SetNext(IHandler handler)
    {
        _nextHandler = handler;
        return handler;
    }

    public virtual string Handle(int request)
    {
        if (_nextHandler != null)
        {
            return _nextHandler.Handle(request);
        }
        return request.ToString();
    }
}
