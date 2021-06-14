using CQRS.Context;
using CQRS.Model;
using CQRS.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS.Repository
{
    public class TodoRepository : ITodoRepository
    {
        private readonly ApplicationDbContext _context;

        public TodoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(Todo todo)
        {
            _context.Add(todo);
            _context.SaveChanges();
        }

        public List<Todo> Get()
        {
            return _context.Todos.ToList();
        }

        public Todo Get(int id)
        {
            return _context.Todos.Find(id);
        }
    }
}
