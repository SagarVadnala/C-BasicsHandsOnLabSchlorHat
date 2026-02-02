namespace HandsOnLabSchlorHat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GettingStartedBasics :");

            GettingStartedBasics basics = new GettingStartedBasics();
            // basics.AreaOfSqr();
            //basics.SwapWithSeconVar();
            //basics.SwapWithOutSeconVar();
            //basics.SumOfAllNum();

            StatementsAndLoops statementsAndLoops = new StatementsAndLoops();
            //statementsAndLoops.CheckCharIsAlphaOrNot();
            //statementsAndLoops.CheckNumIsEvenOrOdd();
            // statementsAndLoops.RighttrianglePattern();
            // statementsAndLoops.LeftTrianglePattern();
            Array_String array_String = new Array_String();
            //array_String.AvgArrayElements();
            //array_String.LargestArrayElements();
            array_String.RotateMatrixRight();

        }
    }
}
