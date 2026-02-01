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
            statementsAndLoops.LeftTrianglePattern();


        }
    }
}
