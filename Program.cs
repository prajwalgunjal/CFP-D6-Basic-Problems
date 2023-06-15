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
            /* Console.WriteLine(issameResult.IsResultTheSame(3 * 3, 18 / 2));
             Console.WriteLine(issameResult.IsResultTheSame(3 + 7, 12 - 8));           
             Console.WriteLine(issameResult.IsResultTheSame(3 * 7 * 8, 256 / 2 / 3));  */

            //problem 5
            /*Console.WriteLine(ModuloOperation.ModuloOperations(542, 28, 7));    
            Console.WriteLine(ModuloOperation.ModuloOperations(33, 10, 2));     
            Console.WriteLine(ModuloOperation.ModuloOperations(2634, 892, 55)); */

            //problem 6
            /*Console.WriteLine(Cube.TheCubeOf(15));
            Console.WriteLine(Cube.TheCubeOf(0.25));  
            Console.WriteLine(Cube.TheCubeOf(-12));
            Console.WriteLine(Cube.TheCubeOf(-0.1));*/

            //PRoblem 7 
            /*Console.WriteLine(swapTwoNos.SwapTwoNumbers(23, 15));      
            Console.WriteLine(swapTwoNos.SwapTwoNumbers(-123, 999));   
            Console.WriteLine(swapTwoNos.SwapTwoNumbers(0, 333));*/

            //problem8 
            /*Console.WriteLine(Absolute.AbsoluteValue(-690543));  
            Console.WriteLine(Absolute.AbsoluteValue(2744));     
            Console.WriteLine(Absolute.AbsoluteValue(0));        
            Console.WriteLine(Absolute.AbsoluteValue(-23));      */

            //problem 9
            /*Console.WriteLine(Capital.IfConsistsOfUppercaseLetters("drY")); 
            Console.WriteLine(Capital.IfConsistsOfUppercaseLetters("LOL")); 
            Console.WriteLine(Capital.IfConsistsOfUppercaseLetters("N0t")); 
            Console.WriteLine(Capital.IfConsistsOfUppercaseLetters("$1r")); */

            // problem 10
            /*Console.WriteLine(greater.IfGreaterThanThirdOne(new int[] { 10, 5, 22 }));     // True
            Console.WriteLine(greater.IfGreaterThanThirdOne(new int[] { -15, -25, 100 })); // True
            Console.WriteLine(greater.IfGreaterThanThirdOne(new int[] { 11, 15, 166 })); */  // False

            // problem  11
            /*Console.WriteLine(evenNumber.IfNumberIsEven(8));          // True
            Console.WriteLine(evenNumber.IfNumberIsEven(54749));      // False*/

            // problem 12
            /*            Console.WriteLine(sorted.IfSortedAscending(new int[] { 3, 6, 9 })); // True
                        Console.WriteLine(sorted.IfSortedAscending(new int[] { 34, 17, 90 })); // False
                        Console.WriteLine(sorted.IfSortedAscending(new int[] { -50, -24, -1 })); // True*/

            // problem 13
            /*Console.WriteLine(neighbour.IfHasNeighbour("DCA")); // True
            Console.WriteLine(neighbour.IfHasNeighbour("PRT")); // False*/

            // problem 14
            /* Console.WriteLine(positivenegzero.PositiveNegativeOrZero(3.14)); // Positive
             Console.WriteLine(positivenegzero.PositiveNegativeOrZero(0.0)); // Zero
             Console.WriteLine(positivenegzero.PositiveNegativeOrZero(-200.003)); // Negative*/

            // problem 15
            /*  Console.WriteLine(LeapYear.IfYearIsLeap(2020)); // True
              Console.WriteLine(LeapYear.IfYearIsLeap(1719)); // False
              Console.WriteLine(LeapYear.IfYearIsLeap(2000)); // True
              Console.WriteLine(LeapYear.IfYearIsLeap(1412)); // True
              Console.WriteLine(LeapYear.IfYearIsLeap(1582)); // False*/

            // problem 16
            /* Console.WriteLine(IfnumberContain3.IfNumberContains3(5384562)); 
             Console.WriteLine(IfnumberContain3.IfNumberContains3(0));       
             Console.WriteLine(IfnumberContain3.IfNumberContains3(390462));*/

            //problem 17
            //MultiplicationTable.Multiplicationtable();

            //problem 18
            /*Console.WriteLine(FractionSum. FractionsSum(2)); 
            Console.WriteLine(FractionSum.FractionsSum(7));  
            Console.WriteLine(FractionSum.FractionsSum(10)); */

            // problem 19
            /*int[] sortedArr = sortArray.SortArrayAscending(new int[] { 0, -23, 9, 18, -51, 1, 90, 57, -1, 25 });

            foreach (var s in sortedArr)
            {
                Console.Write($"{s} "); // -51 -23 -1 0 1 9 18 25 57 90
            }*/
            // problem 20
            Console.WriteLine(Biggestnumber.TheBiggestNumber(new int[] { 9, 4, 8, 1, 0, 2 }));                   // 9
            Console.WriteLine(Biggestnumber.TheBiggestNumber(new int[] { -34, -54, -7, -40, -123, -99 }));       // -7
            Console.WriteLine(Biggestnumber.TheBiggestNumber(new int[] { 1009, 998, 1090, 3000, 2934, 4888 }));  // 4888
        }

    }
}