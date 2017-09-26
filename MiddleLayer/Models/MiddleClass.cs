using Core.Interfaces;
using Repository;

namespace Core.Models
{
    public class MiddleClass : IMiddleClass
    {
        private IBottomClass _bottomClass;

        public MiddleClass(IBottomClass bottomClass)
        {
            _bottomClass = bottomClass;
        }

        public string GetMessage(string message)
        {
            return _bottomClass.GetMessage(string.Format("{0}", message));
        }
    }
}
