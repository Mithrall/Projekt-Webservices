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
        List<string> LogListe = new List<string>();
        public List<string> LogFil(string s)
        {
            LogListe.Add(s);

            return LogListe;
        }


    }
}
