namespace Basic_Problem_D6
{
    public class Program
    {
        static void Main(string[] args)
        {
            // problem 1
            /* AddTwoNumber addTwoNumber = new AddTwoNumber();
             int sum =addTwoNumber.add(10,20,30);
             Console.WriteLine(sum);*/

            // problem 2
            /*Celsius_to_Fahrenheit celsius_To_Fahrenheit = new Celsius_to_Fahrenheit();
            celsius_To_Fahrenheit.Findcelsius(0);
            celsius_To_Fahrenheit.Findcelsius(-800);
            celsius_To_Fahrenheit.Findcelsius(22.5);*/

            //problem 3
            //Console.WriteLine(ElementryOperations.ElementaryOperations(36,15));

            // problem 4
            Console.WriteLine(issameResult.IsResultTheSame(3 * 3, 18 / 2));           // True
            Console.WriteLine(issameResult.IsResultTheSame(3 + 7, 12 - 8));           // False
            Console.WriteLine(issameResult.IsResultTheSame(3 * 7 * 8, 256 / 2 / 3));  // False
        }
    }
}