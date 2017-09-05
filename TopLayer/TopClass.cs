using MiddleLayer;

namespace TopLayer
{
    public class TopClass : ITopClass
    {
        private IMiddleClass _middleClass;

        public TopClass(IMiddleClass middleClass)
        {
            _middleClass = middleClass;
        }

        public string GetMessage()
        {
            return _middleClass.GetMessage();
        }
    }
}
