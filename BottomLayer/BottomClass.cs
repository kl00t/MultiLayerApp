namespace Repository
{
    public class BottomClass : IBottomClass
    {
        public string GetMessage(string message)
        {
            return string.Format("Hello {0}!", message);
        }
    }
}
