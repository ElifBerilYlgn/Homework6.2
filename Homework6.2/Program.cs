using System;

class Course
{
    public string Code { get; init; }
    public string Name { get; set; }

    private int credits;

    public int Credits
    {
        get { return credits; }
        set
        {
            if (value >= 1 && value <= 10)
                credits = value;
            else
                throw new ArgumentException("Credits must be between 1 and 10.");
        }
    }

    public Course(string code, string name, int credits)
    {
        Code = code;
        Name = name;
        Credits = credits;
    }

    public string Info()
    {
        return $"{Code} {Name} ({Credits} cr)";
    }
}

class Program
{
    static void Main()
    {
        Course[] courses =
        {
            new Course("CENG211", "Object Oriented Programming", 4),
            new Course("MATH101", "Calculus", 5),
            new Course("PHYS101", "Physics", 4),
            new Course("CENG101", "Introduction to Programming", 3),
            new Course("ENG101", "English", 2)
        };

        int totalCredits = 0;

        foreach (Course course in courses)
        {
            Console.WriteLine(course.Info());
            totalCredits += course.Credits;
        }

        Console.WriteLine($"Total credits: {totalCredits}");

        string[] names = new string[courses.Length];

        for (int i = 0; i < courses.Length; i++)
        {
            names[i] = courses[i].Name;
        }

        Array.Sort(names);

        Console.WriteLine();
        Console.WriteLine("Course names in alphabetical order:");

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }
}
