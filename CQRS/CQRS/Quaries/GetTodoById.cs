using CQRS.Context;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS.Quaries
{
    public static class GetTodoById
    {
        // query / command
        // All the data we need to execute
        public record Query(int Id):IRequest<Response>;

        // Handler
        // All the business logic to execute returns a response
        public class Handler : IRequestHandler<Query, Response>
        {
            // for data fetching
            private readonly ApplicationDbContext _context;
            public Handler(ApplicationDbContext context )
            {
                _context = context;
            }

            public async Task<Response> Handle(Query request, CancellationToken cancellationToken)
            {
                // All the business Logic
                var todo = _context.Todos.FirstOrDefault(x=>x.Id==request.Id);
                return todo == null ? null : new Response(todo.Id,todo.Name);
            }
        }

        // response 
        // the data we want to return
        public record Response(int id,string name);
    }
}
