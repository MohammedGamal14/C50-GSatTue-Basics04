namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            /* Create a one-dimensional array double[] prices with the values 25.5, 40.0, 33.75.
             Print the second price (index 1).*/
            double[] bookPrices = { 25.5, 40.0, 33.75 };
            Console.WriteLine(bookPrices[1]);
            #endregion

            #region Q2 
            /*Create a 2x2 multidimensional array int[,] shelfCopies where shelf 0 has 3, 5 copies and
            shelf 1 has 1, 4 copies. Print the number of copies on shelf 1, slot 0.*/
            int[,] shelfCopies = { { 3, 5 }, { 1, 4 } };
            Console.WriteLine(shelfCopies[1, 0]);
            #endregion

            #region Q3
            /* Write a method PrintWelcomeMessage that takes no parameters
               and prints "Welcome to the Library!". Call it from Main. */
            PrintWelcomeMessage();
            #endregion

            #region Q4
            /* Write a method PrintBookTitle(string title) that prints "Book title: " + title.
               Call it with "Clean Code". */
            PrintBookTitle("Clean Code");
            #endregion

            #region Q5
            /* Write a method AddBonusPages(int pages) that adds 50 to pages.
               Call it with int pages = 400; and print pages afterward.
               Expected: 400, because int is passed by value (the method changes only a copy). */
            int pages = 400;
            AddBonusPages(pages);
            Console.WriteLine(pages);
            #endregion

            #region Q6
            /* Write a method ApplyDiscount(double[] prices) that subtracts 5 from prices[0].
               Call it with double[] prices = { 25.5, 40.0 }; and print prices[0] afterward.
               Expected: 20.5, because arrays are reference types (the method changes the same array). */
            double[] discountPrices = { 25.5, 40.0 };
            ApplyDiscount(discountPrices);
            Console.WriteLine(discountPrices[0]);
            #endregion





        }

        static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Library!");
        }

        static void PrintBookTitle(string title)
        {
            Console.WriteLine("Book title: " + title);
        }

        static void AddBonusPages(int pages)
        {
            pages = pages + 50;
        }

        static void ApplyDiscount(double[] prices)
        {
            prices[0] = prices[0] - 5;
        }

        static void AddBonusPagesByRef(ref int pages)
        {
            pages = pages + 50;
        }

        static void ReplaceArray(ref double[] prices)
        {
            prices = new double[] { 10.0, 12.5, 15.0 };
        }

        static bool TryGetPrice(string title, out double price)
        {
            if (title == "Clean Code")
            {
                price = 25.5;
                return true;
            }

            price = 0;
            return false;
        }

        static void PrintBookInfo(string title, int pages = 300)
        {
            Console.WriteLine(title + " - " + pages + " pages");
        }

        static void PrintAllTitles(params string[] titles)
        {
            foreach (string currentTitle in titles)
            {
                Console.WriteLine(currentTitle);
            }
        }
    }
}
