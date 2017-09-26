using Core.Interfaces;

namespace Core.Models
{
    public class TopClass : ITopClass
    {
        private IMiddleClass _middleClass;

        public TopClass(IMiddleClass middleClass)
        {
            _middleClass = middleClass;
        }

        public string GetMessage(string message)
        {
            return _middleClass.GetMessage(string.Format("{0}", message));
        }
    }
}
