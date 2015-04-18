using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Power4
{
    class ArrayFormat : IArrayFormatter
    {
        /* Converti en string un IArrayStock
         */
        public ArrayFormat()
        {

        }

        public string formatAsAGrid(IArrayStock tabTokens)
        {
            string result = "";
            for (int i = 0; i < tabTokens.nbrows; i++)
            {
                for (int j = 0; j < tabTokens.nbcols; j++)
                {
                    result += " " + tabTokens.getValue(i, j).value;
                }
                result += "\n";
            }
            result += "_______________ \n";
            result += " 1 2 3 4 5 6 7 \n";
            return result;
        }
    }
}
