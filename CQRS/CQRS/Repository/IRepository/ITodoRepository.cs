using CQRS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS.Repository.IRepository
{
    public interface ITodoRepository
    {
        public List<Todo> Get();

        public Todo Get(int id);

        public void Add(Todo todo);
    }
}
