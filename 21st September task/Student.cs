namespace Inheritance_StringBuilder_IsA_HasA
{
    public class Student
    {
        public string FullName;
        public double Point;
        public DateTime BirthDate;
        public string GroupNo;

        public void ShowInfo()
        {
            Console.WriteLine($"Full name:{FullName} Birth date: {BirthDate} Point: {Point} Group no: {GroupNo}");
        }
        public Student(string fullName, double point)
        {
            FullName = fullName;
            Point = point;
        }
    }
}

