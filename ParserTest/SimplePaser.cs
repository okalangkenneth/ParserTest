using System;

public class SimplePaser
    {
        public int ParseAndSum(string numbers)
        {
            if (numbers.Length == 0)
            {
                return 0;
            }
            if (!numbers.Contains(","))
            {
                return int.Parse(numbers);
            }
            else
            {
                "I can only handle 0 or 1 numbers for now!");
            }
        }
    }


class SimpleParserTests
{
    public static void TestReturnsZeroWhenEmptyString()
    {
        try
        {
            SimplePaser p = new SimplePaser();
            int result = p.ParseAndSum(string.Empty);
            if(result != 0)
            {
                Console.WriteLine(
                    @"***SimpleParserTests.TestReturnZeroWhenEmptyString:
                    -------
                    Parser and sum should have returned 0 on an empty string");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
}