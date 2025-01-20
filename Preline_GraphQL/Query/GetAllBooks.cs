using MediatR;
using Preline_GraphQL.Types;

namespace Preline_GraphQL.Query
{
    public class GetAllBooks : IRequest<Book?>
    {
    }

    public class GetAllBooksHandler : IRequestHandler<GetAllBooks, Book?>
    {
        public Task<Book?> Handle(GetAllBooks request, CancellationToken cancellationToken)
        {
            return null;
        }
    }
}
