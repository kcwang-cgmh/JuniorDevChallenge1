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

            // 使用 while 迴圈允許使用者不斷輸入學生資料
            do
            {
                Console.WriteLine("請輸入學生姓名: ");
                string? name = Console.ReadLine(); // 讀取學生姓名

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
            // 根據學生成績輸出對應的等級
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Grade >= 90)
                {
                    Console.WriteLine(students[i].Name + " 的成績是 A");
                }
                else if (students[i].Grade >= 80)
                {
                    Console.WriteLine(students[i].Name + " 的成績是 B");
                }
                else if (students[i].Grade >= 70)
                {
                    Console.WriteLine(students[i].Name + " 的成績是 C");
                }
                else if (students[i].Grade >= 60)
                {
                    Console.WriteLine(students[i].Name + " 的成績是 D");
                }
                else
                {
                    Console.WriteLine(students[i].Name + " 的成績是 F");
                }
            }
        }
    }

}
