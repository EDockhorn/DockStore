using System.Threading;
using System.Threading.Tasks;
using DockStore.Core.Messages;
using MediatR;

namespace DockStore.Vendas.Application.Commands
{
    public class PedidoCommandHandler :
        IRequestHandler<AdicionarItemPedidoCommand, bool>        
        
    {
        //private readonly IPedidoRepository _pedidoRepository;
        //private readonly IMediatrHandler _mediatorHandler;

        //public PedidoCommandHandler(IPedidoRepository pedidoRepository,
        //                            IMediatrHandler mediatorHandler)
        //{
        //    _pedidoRepository = pedidoRepository;
        //    _mediatorHandler = mediatorHandler;
        //}

        public async Task<bool> Handle(AdicionarItemPedidoCommand message, CancellationToken cancellationToken)
        {
            if (!ValidarComando(message)) return false;

            return true;
        }
        private bool ValidarComando(Command message)
        {
            if (message.EhValido()) return true;

            foreach (var error in message.ValidationResult.Errors)
            {
                //
            }

            return false;
        }

    }
}