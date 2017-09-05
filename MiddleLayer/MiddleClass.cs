using BottomLayer;

namespace MiddleLayer
{
    public class MiddleClass : IMiddleClass
    {
        private IBottomClass _bottomClass;

        public MiddleClass(IBottomClass bottomClass)
        {
            _bottomClass = bottomClass;
        }

        public string GetMessage()
        {
            return _bottomClass.GetMessage();
        }
    }
}
