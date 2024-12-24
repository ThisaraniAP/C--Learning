namespace paradigm_examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student std1 = new Student("Harry", "Potter", 11, "Male", 75);
            Student std2 = new Student("Hermione", "Granger", 11, "Female", 100);

            std1.Information();
            std2.Information();
        }
    }
}

