public class Course
{
    public string Name { get; set; }
    public int Grade { get; set; }

    public Course(string name, int grade)
    {
        Name = name;
        Grade = grade;
    }
}