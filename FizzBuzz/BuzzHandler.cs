namespace FizzBuzz;

public class BuzzHandler : Handler
{
    public override string Handle(int request)
    {
        if (request % 5 == 0 && request % 3 != 0)
        {
            return "Buzz";
        }
        return base.Handle(request);
    }
}
