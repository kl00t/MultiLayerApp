using System.ServiceModel;

namespace Client.WcfService
{
    [ServiceContract]
    public interface IClientService
    {

        [OperationContract]
        string GetMessage(string message);
    }
}
