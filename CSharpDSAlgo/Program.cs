using System;

namespace CSharpDSAlgo
{
    class Program
    {
        static void Main(string[] args)
        {
            MonthNames mn = new MonthNames();
            mn.displayMonths();

            MultiplicationTable mt = new MultiplicationTable();
            mt.displayProduct();

            GameMap gm = new GameMap();
            gm.displayGameMap();
        }
    }
}
