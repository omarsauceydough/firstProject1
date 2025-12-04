using System.Diagnostics.Contracts;
using System.Runtime.InteropServices;
using System.Transactions;

internal class Program
{
    static List<Student> students = new List<Student>();
    static string StudentFile = "students.csv";
    private static void Main(string[] args)
    {
        LoadStudents();

        bool running = true;

        while (running)
        {
            Console.WriteLine();
            Console.WriteLine("=== Student Management System ===");
            Console.WriteLine("1) Add Student");
            Console.WriteLine("2) Assign Course to Student");
            Console.WriteLine("3) View Student Average");
            Console.WriteLine("4) List Students");
            Console.WriteLine("5) Save & Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddStudent();
                    break;
                case "2":
                    AssignCourse();
                    break;
                case "3":
                    ViewAverage();
                    break;
                case "4":
                    ListStudents();
                    break;
                case "5":
                    SaveStudents();
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }

    //addStudent method
    static void AddStudent()
    {
        Console.Write("Enter student name: ");
        string name = Console.ReadLine();
        if (name == null || name.Trim() == "")
        {
            Console.WriteLine("Name cannot be empty. Please enter a valid name.");
            return;
        }

        
        int id = students.Count + 1;
        Student s = new Student(id, name.Trim());
        students.Add(s);
        Console.WriteLine("Added student:" + s.Name + " (ID: " + s.Id + ")");
    }

    //Method to assign course
    static void AssignCourse()
    {
        Console.Write("Enter student ID >> ");
        string idInput = Console.ReadLine();
        int id;

        if (!int.TryParse(idInput, out id))
        {
            Console.WriteLine("Invlaid ID!");
            return;
        }

        Student student = null;
        foreach (Student st in students)
        {
            if (st.Id == id)
            {
                student = st;
                break;
            }
        }

        if (student == null)
        {
            Console.WriteLine("Student not found!");
            return;
        }

        Console.Write("Enter course name>> ");
        string courseName = Console.ReadLine();
        if (courseName == null || courseName.Trim() == "")
        {
            Console.WriteLine("Course name cannot be empty!");
            return;
        }

        Console.Write("Enter grade (0-100)>> ");
        string gradeInput = Console.ReadLine();
        int grade;
        if (!int.TryParse(gradeInput, out grade))
        {
            Console.WriteLine("Invalid grade!");
            return;
        }
        if (grade < 0 || grade > 100)
        {
            Console.WriteLine("Grade must be a number between 0 and 100!");
            return;
        }

        student.AddCourse(courseName.Trim(), grade);
        Console.WriteLine("Assigned " + courseName.Trim() + " with grade " + grade + " to " + student.Name);
    }

    //Method to view the average of the student grade
    static void ViewAverage()
    {
        Console.Write("Enter student ID>> ");
        string idInput = Console.ReadLine();
        int id;
        if (!int.TryParse(idInput, out id))
        {
            Console.WriteLine("Invalid ID!");
            return;
        }

        Student s = null;
        foreach (Student st in students)
        {
            if (st.Id == id)
            {
                s = st;
                break;
            }
        }

        if (s == null)
        {
            Console.WriteLine("Student not found!");
            return;
        }

        double avg = s.GetAverage();
        Console.WriteLine(s.Name + "'s average grade >>> " + avg);
    }

    //Method to list all students
    static void ListStudents()
    {
        if (students.Count == 0)
        {
            Console.WriteLine("No students found!");
            return;
        }

        Console.WriteLine();
        Console.WriteLine("Students:");
        foreach (Student s in students)
        {
            int courseCount = s.Courses.Count;
            Console.WriteLine("ID: " + s.Id + ", Name: " + s.Name + ", Courses: " + courseCount);
        }
    }

    //Save and exit method
    static void SaveStudents()
    {
        using (StreamWriter sw = new StreamWriter(StudentFile))
        {
            foreach (Student s in students)
            {
                string coursesPart = "";
                foreach (Course c in s.Courses)
                {
                    coursesPart = coursesPart + c.Name + ":" + c.Grade + "|";
                }
                if (coursesPart.Length > 0)
                {
                    coursesPart = coursesPart.Substring(0, coursesPart.Length - 1);
                }
                sw.WriteLine(s.Id + "," + s.Name + "," + coursesPart);
            }
        }

        Console.WriteLine("Saved " + students.Count + " students to " + StudentFile);
    }

    //Method to load students in
    static void LoadStudents()
    {
        if (!File.Exists(StudentFile))
        {
            return;
        }

        string[] lines = File.ReadAllLines(StudentFile);
        foreach (string line in lines)
        {
            if (line == null) continue;
            string trimmed = line.Trim();
            if (trimmed == "") continue;

            string[] parts = trimmed.Split(',');
            if (parts.Length < 2) continue;

            int id = int.Parse(parts[0]);
            string name = parts[1];
            Student s = new Student(id, name);

            if (parts.Length >= 3 && parts[2] != "")
            {

                string[] courses = parts[2].Split('|');
                foreach (string course in courses)
                {
                    if (course == "") continue;
                    string[] c = course.Split(':');
                    string courseName = c[0];
                    int grade = int.Parse(c[1]);
                    s.AddCourse(courseName, grade);
                }
            }
            students.Add(s);
        }

        Console.WriteLine("Loaded " + students.Count + " students from " + StudentFile);
    }
}