namespace MediatRDemo.Ports
{
    public class Presenter : ICreateProductOutPort
    {
        public string Content { get; private set; }
        public void Handle(int response)
        {
            Content = response.ToString($"Id del producto: {response}");
        }
    }
}