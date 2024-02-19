namespace DateTestUnitaire;

class Program
{
    

    static void Main(string[] args)
    {
        DateValidator date = new DateValidator();

        //string test = "12-14-2003";
        //string[] test2 = test.Split('-');

        //if (test[1] < 1 || test[1] > 12)
        //{
        //    Console.WriteLine("false");
        //} 




        //date.IsDateValid("12-14-2001");

        Console.WriteLine(date.IsDateValid("32-12-2001"));
        //string[] test2 = test.Split('-');
        //Console.WriteLine(test2.Length);

        //foreach (string item in test2)
        //{
        //    Console.WriteLine(item);
        //}

    }
}

