using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mail_Recorder_App.DAO
{
    public class Facade : RecordMailFacade
    {
        private static Facade m;
        public static Facade Instance
        {
            get
            {
                if (m == null)
                {
                    m = new Facade();
                }
                return m;
                //return new Facade();
            }
        }
    }
}
