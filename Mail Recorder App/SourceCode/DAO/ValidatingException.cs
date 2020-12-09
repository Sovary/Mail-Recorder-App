using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mail_Recorder_App.DAO
{
    public class ValidatingException: Exception
    {
        public ValidatingException(string msg) : base(msg) { }
    }
}
