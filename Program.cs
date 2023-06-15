namespace Basic_Problem_D6
{
    public class Program
    {
        static void Main(string[] args)
        {
            AddTwoNumber addTwoNumber = new AddTwoNumber();
            int sum =addTwoNumber.add(10,20,30);
            Console.WriteLine(sum);
        }
    }
}