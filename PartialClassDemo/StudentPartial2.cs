using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassDemo
{
    public partial class StudentPartial
    {
        public string GetCompleteName()
        {
            return _firstName + " " + _lastName;
        }
    }
}
