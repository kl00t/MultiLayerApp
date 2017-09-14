using Core;

namespace Client.WcfService
{
    public class ClientService : IClientService
    {
        private readonly ITopClass _topClass;

        public ClientService(ITopClass topClass)
        {
            _topClass = topClass;
        }

        public string GetMessage(string message)
        {
            return _topClass.GetMessage(message);
        }
    }
}
