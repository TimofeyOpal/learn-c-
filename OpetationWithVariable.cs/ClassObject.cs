using System;
using System.Collections.Generic;
using System.Text;

namespace OpetationWithVariable.cs
{
    class ClassObject
    {
        public int findMax(int left, int right)
        {
            int result;

            if (left > right)
            {
                result = left;
            }
            else
            {
                result = right;
            }
            return result;
        }

    }
}
