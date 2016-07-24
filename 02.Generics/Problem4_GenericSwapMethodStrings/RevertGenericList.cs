using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4_GenericSwapMethodStrings
{
    public static class RevertGenericList<T>
    {
         
        public static List<T> Revert(List<T> list, int firstIndex, int secondIndex)
        {
            list.Reverse(firstIndex, secondIndex+1);
            return list;
        }
    }
}
