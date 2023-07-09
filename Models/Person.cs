namespace LinqExamples.Models;

internal class Person
{
    public string Name { get; set; }
    public string Age { get; set; }

    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}";
    }
}