namespace Home_Work_Group
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Lolo", "Mukhammed", "Kamel",DateTime.Now, "asda12", 1234);
            Student student2 = new Student("Lolo", "Mukhammed", "Kamel", DateTime.Now, "asda12", 1234);

            Group group1 = new Group("p26", Spaciality.SoftwareDeveloper, 1);
            Group group2 = new Group("p26", Spaciality.SoftwareDeveloper, 1);

            ConsoleStudentManager consoleStudentManager = new ConsoleStudentManager();
            ConsoleGroupManager consoleGroupManager = new ConsoleGroupManager();
            ConsoleGroupPrinter consoleGroupPrinter = new ConsoleGroupPrinter();

            consoleStudentManager.AddExamGrades(student1, 12);
            consoleStudentManager.AddExamGrades(student1, 11);
            consoleStudentManager.AddExamGrades(student1, 8);
            consoleStudentManager.AddHomeworkGrades(student1, 9);
            consoleStudentManager.AddTermPaperGrades(student1, 8);

            consoleStudentManager.AddExamGrades(student2, 12);
            consoleStudentManager.AddExamGrades(student2, 11);
            consoleStudentManager.AddExamGrades(student2, 8);
            consoleStudentManager.AddHomeworkGrades(student2, 9);
            consoleStudentManager.AddTermPaperGrades(student2, 8);

            consoleGroupManager.AddStudent(group1, student1);
            consoleGroupManager.AddStudent(group2, student2);

            //consoleGroupPrinter.Print(group1);

            ConsoleStudentPrinter printer = new ConsoleStudentPrinter();
            printer.Print(student1);
            Console.WriteLine("\n\n\n\n\n");
            printer.Print(student2);

            //if (group1 == group2)
            //{
            //    Console.WriteLine("Yes!");
            //}
            //else
            //{
            //    Console.WriteLine("No!");
            //}

            //if (student1 == student2)
            //{
            //    Console.WriteLine("Yes!");
            //}
            //else
            //{
            //    Console.WriteLine("No!");
            //}


        }
    }
}
