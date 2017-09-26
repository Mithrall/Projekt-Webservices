using System.Runtime.Serialization;
using System.ServiceModel;

namespace WcfService
{
    
    [ServiceContract]
    public interface ILogService
    {
        [OperationContract]
        string Input(string s);

        
    }

    
}
