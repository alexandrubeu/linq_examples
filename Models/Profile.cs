namespace LinqExamples.Models;

internal class Profile
{
    public int Id { get; set; }
    public string Email { get; set; }

    public override string ToString()
    {
        return $"ID: {Id}, Name: {Email}";
    }
}