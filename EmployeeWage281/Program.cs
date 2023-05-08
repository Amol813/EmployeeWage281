namespace EmployeeWage281
{
    public class Program
    {
        static void Main(string[] args)
        {
            const int FULL_TIME = 1;
            const int EMP_RATE_PER_HR = 20;
            int empHrs = 0;
            int empWage = 0;
            Console.WriteLine("Welcome to the EmployeeWage Computation Problem!");
            Random random = new Random();
            int randomInput = random.Next(0, 2); //0 or 1
            if (FULL_TIME == randomInput)
            {
                empHrs = 8;
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            } 
            empWage = EMP_RATE_PER_HR * empHrs;
            Console.WriteLine("Employee Wage per Day:{0}", empWage);
            Console.ReadLine();
        }
    }
}