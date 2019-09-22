using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassNulable
{
    public static class IsNullable
    {
        public static bool IsNull(this object obj)
        {
            return (obj == null) ? true : false;
        }
    }
}
