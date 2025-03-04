namespace JuniorDevChallenge1
{
    internal class GradesService
    {

        public void DisplayGrades(List<Student> students)
        {
            foreach (Student student in students)
            {
                Console.WriteLine(student.Name + " 的成績是 " + GetGradeLetter(student.Grade));
            }
        }

        private string GetGradeLetter(int grade)
        {
            return grade >= 90 ? "A" :
                   grade >= 80 ? "B" :
                   grade >= 70 ? "C" :
                   grade >= 60 ? "D" : "F";
        }
    }
}