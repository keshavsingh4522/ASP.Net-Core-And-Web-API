using CQRS.Context;
using CQRS.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS.Commands
{
    public static class AddTodo
    {
        // query / commands
        public record Commands(string name):IRequest<int>;

        //handler

        public class Handler : IRequestHandler<Commands, int>
        {
            private readonly ApplicationDbContext _context;

            public Handler(ApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<int> Handle(Commands request, CancellationToken cancellationToken)
            {
                var count = _context.Todos.ToList().Count;
                _context.Add(new Todo { Name=request.name});
                _context.SaveChanges();
                return count+1;
            }
        }
    }
}
