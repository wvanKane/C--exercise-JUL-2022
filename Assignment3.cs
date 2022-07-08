using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{

    //public int[] GenerateNumbers()
    //{
    //    int[] numbers = new int[10];
    //    for (int i = 0; i < numbers.Length; i++)
    //    {
    //        numbers[i] = i + 1;
    //    }
    //    return numbers;
    //}
    public int[] GenerateNumbers(int len)
    {
        int[] numbers = new int[len];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = i + 1;
        }
        return numbers;
    }
    public void Reverse(int[] numbers)
    {
        int start = 0;
        int end = numbers.Length - 1;
        while (start < end)
        {
            int temp = numbers[start];
            numbers[start] = numbers[end];
            numbers[end] = temp;
            start++;
            end--;
        }
    }

    public void PrintNumbers(int[] numbers)
    {
        Console.WriteLine(String.Join(",", numbers));
    }

    public int Fibonacci(int n)
    {
        if (n <= 1)
            return n;
        int res = Fibonacci(n - 1) + Fibonacci(n - 2);
        return res;
    }

    public class Student
    {
        public List<Course> CourseList { get; set; }
        private List<GradePoint> GradePoints { get; set; }

        public Student(string name, DateTime birthDate, string[] addresses) : base(name, birthDate, addresses)
        {
            CourseList = new List<Course>();
            GradePoints = new List<GradePoint>();
        }

        public float calculateGPA()
        {
            float gpa = 0.0f;
            foreach (GradePoint gp in GradePoints)
            {
                gpa += (float)gp;
            }
            return gpa / GradePoints.Count;
        }
    }

    public class Person
    {
        private int _id;
        private string _name;
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        public string Name
        {
            get => _name;
            set { _name = value; }
        }

        public Person()
        {
            Id = 0;
        }
        public Person(int id, String name)
        {
            Id = id;
            Name = name;
        }
    }

    public class Ball
    {
        public Color color;
        public int Size { get; set; }
        public int trackTimes { get; set; }

        public Ball(Color color, int size, int trackTimes)
        {
            this.color = color;
            Size = size;
            this.trackTimes = trackTimes;
        }
        public Ball(Color color, int size)
        {
            this.color = color;
            Size = size;
            this.trackTimes = 0;
        }
        public void Pop()
        {
            Size = 0;
        }

        public void Throw()
        {
            if (Size != 0)
            {
                trackTimes++;
            }
        }

        public int getTrackTimes()
        {
            return trackTimes;
        }
    }

    public class Color
    {
        public int red { get; set; }
        public int green { get; set; }
        public int blue { get; set; }
        public int alpha { get; set; }

        public Color(int red, int green, int blue, int alpha)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;
        }
        public Color(int red, int green, int blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            alpha = 255;
        }

        public double getGrayscale()
        {
            return (double)(red + blue + green) / 3;
        }
    }
}
