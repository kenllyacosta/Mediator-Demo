using MediatR;
using MediatRDemo.Ports;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace MediatRDemo
{
    public class CreateProduct : IRequest
    {
        public CreateProduct(string name, ICreateProductOutPort outPutPort)
        {
            Name = name;
            OutPutPort = outPutPort;
        }

        public string Name { get; set; }
        public ICreateProductOutPort OutPutPort {  get; }
    }

    //Interactor
    public class CreateProductHandler : AsyncRequestHandler<CreateProduct>
    {
        protected override Task Handle(CreateProduct request, CancellationToken cancellationToken)
        {
            //...Creamos el producto aquí
            
            int Product = 7; //Id del producto creado

            request.OutPutPort.Handle(Product);
            return Task.CompletedTask;
        }
    }
}
