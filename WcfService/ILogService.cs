using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace WcfService
{
    
    [ServiceContract]
    public interface ILogService
    {
        [OperationContract]
        List<string> LogFil(string s);

        
    }

    
}
