
namespace CSharp12.AdvancedPatternMatching;
public class Person
{
    public string Name { get; set; }=string.Empty;
    public Address? Address { get; set; }

    public static string GetPersonLocation(Person person)
    {
        return person switch
        {
            // Recursive pattern matching on nested objects
            { Address: { City: "New York", Country: "USA" } } => "Person is in New York, USA",
            { Address: { Country: "USA" } } => "Person is in the USA",
            { Address: { City: var city } } => $"Person is in {city}",
            _ => "Location unknown"
        };
    }

}
