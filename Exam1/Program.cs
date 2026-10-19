namespace Exam1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject(1, "OOP");

            Console.Write("Exam type (1 = Final, 2 = Practical): ");
            int type = int.Parse(Console.ReadLine());

            subject.CreateExam(type);

            Console.WriteLine(subject);
            Console.WriteLine(subject.Exam);
            Console.WriteLine();

            subject.Exam.ShowExam();
        }
    }
}
