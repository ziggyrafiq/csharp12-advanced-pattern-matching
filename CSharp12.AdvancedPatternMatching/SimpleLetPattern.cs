namespace CSharp12.AdvancedPatternMatching;

public static class SimpleLetPattern
{
    public static string CheckDiscount(int age)
    {
        return age switch
        {
            // Using 'let' to introduce an intermediate variable
            
            let isAdult when isAdult >= 18 => "Eligible for discount",
            _ => "Not eligible for discount"
        };
    }

    public static string GetCoordinates((int X, int Y) point)
    {
        return point switch
        {
            // Recursive pattern matching on the tuple
            (0, 0) => "Origin",
            (let x, 0) when x > 0 => "X-axis positive",
            (0, let y) when y > 0 => "Y-axis positive",
            _ => "Somewhere else"
        };
    }


}
