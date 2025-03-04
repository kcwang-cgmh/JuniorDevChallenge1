namespace JuniorDevChallenge1
{
    internal class Program
    {
        static void Main()
        {
            var studentsService = new StudentsService();
            List<Student> students = studentsService.GetStudentsData();

            var gradesService = new GradesService();
            gradesService.DisplayGrades(students);
        }
    }
}
