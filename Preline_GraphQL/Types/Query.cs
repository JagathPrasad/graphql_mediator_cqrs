using MediatR;
using Preline_GraphQL.Query;

namespace Preline_GraphQL.Types
{
    [QueryType]
    public static class Query
    {
        public static Book GetBook([Service] IMediator _mediator)
        {
            _mediator.Send(new GetAllBooks());
            return new Book("C# in depth.", new Author("Jon Skeet"));
        }
            
    }
}
