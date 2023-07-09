// See https://aka.ms/new-console-template for more information

using LinqExamples.Models;

Console.WriteLine("Hello, World!");

void PrintStudents(List<Student> students) => students.ForEach(Console.WriteLine);

void PrintPeople(List<Person> people) => people.ForEach(Console.WriteLine);

void PrintProfiles(List<Profile> profiles) => profiles.ForEach(Console.WriteLine);

var students = new List<Student>
{
    new() { Id = 1, Name = "John", Age = 18, ProfileId = 1 },
    new() { Id = 2, Name = "Steve", Age = 21, ProfileId = 1 },
    new() { Id = 3, Name = "Bill", Age = 18, ProfileId = 2 },
    new() { Id = 4, Name = "Ram", Age = 20, ProfileId = 2 },
    new() { Id = 5, Name = "Ron", Age = 21 }
};

var profiles = new List<Profile>
{
    new() { Id = 1, Email = "john@john.john" },
    new() { Id = 2, Email = "Steve@steve.steve" },
    new() { Id = 3, Email = "Bill@bill.bill" }
};

PrintStudents(students);
PrintProfiles(profiles);


// #1. Order Students by Age 

// #2. Same as above and filter the students that are over 18 years old 

// #3 Same as above but show only the age, I'm expecting an arrays of ints 

// #4. From point 2, convert the students into persons

// #5. Group students by Age

// #6. Join students with profiles.

// #7. Find the oldest student. 
    
// #8.  Find the youngest student.

// #9. Extract the total age for all our Students

// #10. Write all the queries from above in query Syntax. 