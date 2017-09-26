using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
    public class LogService : ILogService
    {
        public string Input(string s)
        {
            return s;
        }
    }
}
