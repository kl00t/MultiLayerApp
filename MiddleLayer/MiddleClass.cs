using Repository;

namespace Core
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
