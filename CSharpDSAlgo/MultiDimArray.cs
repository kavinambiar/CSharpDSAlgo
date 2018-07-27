using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDSAlgo
{
    class MultiDimArray
    {
        int[,] product = new int[12, 12];

        public void displayProduct()
        {
            for(int i = 0; i < product.GetLength(0); i++)
            {
                for(int j = 0; j < product.GetLength(1); j++)
                {
                    product[i,j] = (i + 1) * (j + 1);
                }
            }

            for (int i = 0; i < product.GetLength(0); i++)
            {
                for (int j = 0; j < product.GetLength(1); j++)
                {
                    Console.Write("{0,4}", product[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
