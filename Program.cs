namespace LR_4
{
    internal class Program
    {
        struct Student
        {
            public string name;
            public string first_name;
            public string last_name;
            public string groupNumber;
            public int[] estimates;
            double avgGrade;

            public Student(string name = "Underfined", string first_name = "Underfined", string last_name = "Underfined", string groupNumber = "Underfined", int[] estimates = null)
            {
                this.name = name;
                this.first_name = first_name;
                this.last_name = last_name;
                this.groupNumber = groupNumber;
                this.estimates = estimates;
                avgGrade = estimates.Average();
            }

            public double AvgGrade
            {
                get
                {
                    return avgGrade;
                }
            }
        }

        static void Main(string[] args)
        {
            Student[] students = {
                new Student("Русинов", "Ю.", "А.", "20ит17", new int [5]{5, 4, 5, 5, 5}),
                new Student("Жирнова", "Е.", "А.", "20ит17", new int [5]{5, 4, 5, 5, 5}),
                new Student("Марусик", "М.", "Д.", "20ит17", new int [5]{3, 4, 5, 5, 4}),
                new Student("Михотин", "И.", "А.", "20ит17", new int [5]{4, 4, 5, 5, 5}),
                new Student("Туманина", "А.", "А.", "20ит17", new int [5]{3, 4, 5, 5, 5}),
                new Student("Парфенова", "Т.", "А.", "20ит17", new int [5]{3, 4, 5, 5, 4})};

            Array.Sort(students, (a, b) => a.estimates.Average().CompareTo(b.estimates.Average()));

            foreach (Student student in students)
            {
                Console.WriteLine(String.Format("ФИО: {0} {1} {2}, Номер группы: {3}, Средний балл: {4}", student.name, student.first_name, student.last_name, student.groupNumber, student.AvgGrade));
            }
            Console.ReadLine();
        }
    }

}
