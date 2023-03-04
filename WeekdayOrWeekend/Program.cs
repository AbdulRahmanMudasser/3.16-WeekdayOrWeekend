class WeekdayOrWeekend
{
    static void Main(string[] args)
    {
        int input;

        Console.Write("Enter An Integer From 1 to 7: ");
        input = Convert.ToInt32(Console.ReadLine());

        if (input == 1 || input == 2 || input == 3 || input == 4 || input == 5)
        {
            Console.Write("Working Day");
        }

        else if (input == 6 || input == 7)
        {
            Console.Write("Weekend");
        }

        else
        {
            Console.Write("Invalid Input!");
        }
    }
    // end of Main method
}
// end of WeekdayOrWeekend class
