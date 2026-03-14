using Task3.IndependentWork.Task1.Models;

namespace Task3.IndependentWork.Task1;

public static class Sandbox
{
    public static void Main()
    {
        Learner[] learners =
        [
            new Pupil("John Doe", 5),
            new Student("Jane Doe", "MIT", 2),
            new WorkingStudent("Jim Milton", "Harvard", 1, "Retail Sales Associate")
        ];

        foreach (var learner in learners)
        {
            Console.WriteLine(new string('=', 50));
            learner.Print();
        }
    }
}