namespace LinqExamples.Models;

internal class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public int ProfileId { get; set; }

    public override string ToString()
    {
        return $@"Id: {Id}, Name: {Name}, Age: {Age}, StandardId: {ProfileId}";
    }
}