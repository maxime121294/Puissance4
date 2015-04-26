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

        public string formatAsAGrid(IArrayStock tabTokens)
        {
            string result = "";
            for (int i = tabTokens.nbrows-1; i >=0 ; i--)
            {
                for (int j = 0; j < tabTokens.nbcols; j++)
                    result += " " + tabTokens.getValue(i, j).value;
                result += "\n";
            }
            for (int j = 0; j < tabTokens.nbcols; j++)
                result += "__";
            result += "_\n";
            for (int j = 1; j <= tabTokens.nbcols; j++)
                result += " " + j;
            result += " \n";
            return result;
        }
    }
}
