namespace CSharp12.AdvancedPatternMatching;

public record Point(int X, int Y);
public static class Points
{
    public static string DescribePoint(Point point)
    {
        return point switch
        {
            // Matching recursively with deconstruction
            Point(0, 0) => "At the origin",
            Point(let x, let y) when x == y => "X equals Y",
            Point(let x, _) when x > 0 => "Positive X-coordinate",
            Point(_, let y) when y > 0 => "Positive Y-coordinate",
            _ => "Somewhere else"
        };
    }

}
