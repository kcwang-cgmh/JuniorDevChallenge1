namespace JuniorDevChallenge1
{
    internal class Program
    {
        static void Main()
        {
            List<Student> students = GetStudentsData();

            DisplayGrades(students);
        }

        private static List<Student> GetStudentsData()
        {
            var students = new List<Student>();
            string addMoreStudents = "Y";

            do
            {
                Console.WriteLine("請輸入學生姓名: ");
                string? name = Console.ReadLine();

                if (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("學生姓名不能空白，請重新輸入。");
                    continue;
                }

                int grade = GetStudentGrade();

                students.Add(new Student(name, grade));

                Console.WriteLine("是否要輸入另一位學生？(Y/N)");
                addMoreStudents = Console.ReadLine() ?? "N";
            } while (addMoreStudents?.ToUpper() == "Y");

            return students;
        }

        private static int GetStudentGrade()
        {
            while (true)
            {
                Console.WriteLine("請輸入學生成績(0-100): ");
                if (int.TryParse(Console.ReadLine(), out int grade) && grade >= 0 && grade <= 100)
                {
                    return grade;
                }
                Console.WriteLine("成績請輸入 0-100 之間的數字。");
            }
        }

        private static void DisplayGrades(List<Student> students)
        {
            foreach (Student student in students)
            {
                Console.WriteLine(student.Name + " 的成績是 " + GetGradeLetter(student.Grade));
            }
        }

        private static string GetGradeLetter(int grade)
        {
            return grade >= 90 ? "A" :
                   grade >= 80 ? "B" :
                   grade >= 70 ? "C" :
                   grade >= 60 ? "D" : "F";
        }
    }
}
