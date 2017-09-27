using System.Collections.Generic;
using System.ServiceModel;

namespace WcfService {

    [ServiceContract]
    public interface ILogService {
        [OperationContract]
        void LogFil(string s);

        [OperationContract]
        string GetLast();
    }
}
