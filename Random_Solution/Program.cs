namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Working days in a month
            int daysWorkedInMonth = int.Parse(Console.ReadLine());

            // Daily profit
            double profitPerDay = double.Parse(Console.ReadLine());

            // USD currency value to BGN
            double usd = double.Parse(Console.ReadLine());
            //double usd = 1.85;

            // Checks if values are beneficial
            if(5 <= daysWorkedInMonth && daysWorkedInMonth <= 30 && 10.00 <= profitPerDay && profitPerDay <= 2000.00 && 0.99 <= usd && usd <= 1.99)
            {
                // Average daily profit
                double averageDailyProfit = 0.0;

                // Monthly salary based on the daily profit and the working days
                double monthSalary = daysWorkedInMonth * profitPerDay;

                // Bonus is 2.5 times the monthly salary
                double bonus = monthSalary * 2.5;

                // Year salary is 12 times the monthly salary
                double yearSalary = monthSalary * 12;

                // Adds the bonus to the year salary
                yearSalary += bonus; 

                // Calculates the 25% VAT from the year salary
                double VAT = yearSalary * 0.25;

                // Substracts the VAT from the year salary
                yearSalary -= VAT;

                // Calculates how many days have been worked in a year to calculate what is the average daily profit;
                double daysWorkedInYear = 365;

                averageDailyProfit = yearSalary / daysWorkedInYear;

                // Changes currencies from USD to BGN
                averageDailyProfit *= usd;

                // Prints average daily profit x.xx
                Console.WriteLine($"{averageDailyProfit:F2}");
            }
        }
    }
}