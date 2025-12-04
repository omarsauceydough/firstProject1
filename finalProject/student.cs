using System.Collections.Concurrent;
using System.Runtime.InteropServices;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Course> Courses { get; set; }

    public Student(int id, string name)
    {
        Id = id;
        Name = name;
        Courses = new List<Course>();
    }

    public void AddCourse(string courseName, int grade)
    {
        Course c = new Course(courseName, grade);
        Courses.Add(c);
    }

    //avg grade calc across all courses 
    public double GetAverage()
    {
        if (Courses.Count == 0) return 0.0;

        int total = 0;
        int count = 0;
        foreach (Course c in Courses)
        {
            total = total + c.Grade;
            count = count + 1;
        }
        if (count == 0) return 0;
        return (double)total / count;
    }
}