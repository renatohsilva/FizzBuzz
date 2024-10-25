namespace FizzBuzz;

public class FizzBuzzHandler : Handler
{
    public override string Handle(int request)
    {
        if (request % 3 == 0 && request % 5 == 0)
        {
            return "FizzBuzz";
        }
        return base.Handle(request);
    }
}
