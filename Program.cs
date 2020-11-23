using System;

namespace Assignment_4
{
    class Program
    {
        public static void Main(string[] args)
        {
            double PERDAY = 75.00;
            double BATH = 112.00;
            double BOTH = 169.00;
            double total;
            Console.WriteLine("How many days will your dog be staying?");
            int days = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you want bath, bath and grooming, or none?");
            Console.WriteLine("type 1-bath, 2-bath and grooming, or 0-none?");
            int service = Convert.ToInt32(Console.ReadLine());

            if(service == 1){
                total = computeRate(days, BATH);
                Console.WriteLine("For the bath, the cost is $" + total + " dollars for "+ days + " day(s)");
            }
            else if(service == 2){
                total = computeRate(days, BOTH);
                Console.WriteLine("For the bath and grooming, the cost is $" + total + " dollars for "+ days + " day(s)");
            }
            else if(service == 0){
                total = computeRate(days, PERDAY);
                Console.WriteLine("For the no additional fees, the cost is $" + total + " dollars for "+ days + " day(s)");
            }

        }
        static double computeRate(int days, double PERDAY)
        {
            double sum;
            sum = days * PERDAY;
            return sum;
        }
        static double computeRate(int days, double BATH, int service)
        {
            double sum;
            sum = days * BATH;
            return sum;
        }
        static double computeRate(int service, int days, double BOTH)
        {
            double sum;
            sum = days * BOTH;
            return sum;
        }
    }
}
