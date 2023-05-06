namespace EmployeeWage281
{
    public class Program
    {
        static void Main(string[] args)
        {
            const int IS_PRESENT = 1;
            Console.WriteLine("Welcome to the EmployeeWage Computation Problem!");
            Random random = new Random();
            int randomInput = random.Next(0, 2);
            if (IS_PRESENT == randomInput)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
            Console.ReadLine();

        }
    }
}