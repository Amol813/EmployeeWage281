namespace EmployeeWage281
{
    public class Program
    {
        static void Main(string[] args)
        {
            const int FULL_TIME = 1;
            const int PART_TIME = 2;
            const int EMP_RATE_PER_HR = 20;
            const int MAX_WORKING_DAY = 20;
            int empHrs = 0;
            int empWage = 0;
            int totalwage = 0;
            Console.WriteLine("Welcome to the EmployeeWage Computation Problem!");
            Random random = new Random();
            for (int day = 0;day< MAX_WORKING_DAY;day++)
            {
                int randomInput = random.Next(0, 3); //0 or 1 or 2
                switch (randomInput)
                {
                    case FULL_TIME:
                        empHrs = 8;
                      //  Console.WriteLine("FullTime Employee is Present");
                        break;
                    case PART_TIME:
                        empHrs = 4;
                      //  Console.WriteLine("PartTime Employee is Present");
                        break;
                    default:
                        break;
                }
                empWage = EMP_RATE_PER_HR * empHrs;
                totalwage += empWage; // totalWage=totalWage+empWage;
                Console.WriteLine("Employee Wage per Day{0}:{1}",day, empWage);
            }
            Console.WriteLine("Totalwage for {0} day is: day is {1}",MAX_WORKING_DAY, totalwage);
            Console.ReadLine();
        }
         
    }
}