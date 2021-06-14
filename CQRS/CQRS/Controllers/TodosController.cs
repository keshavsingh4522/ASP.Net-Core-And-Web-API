using CQRS.Commands;
using CQRS.Context;
using CQRS.Model;
using CQRS.Quaries;
using CQRS.Repository.IRepository;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly ITodoRepository _todoRepository;
        private readonly IMediator _mediator;

        public TodosController(
            ApplicationDbContext context,
            ITodoRepository todoRepository,
            IMediator mediator
            )
        {
            _context = context;
            _todoRepository = todoRepository;
            _mediator = mediator;
        }

        [HttpGet]
        public List<Todo> Get()
        {
            return _todoRepository.Get();
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var response = _mediator.Send(new GetTodoById.Query(id));
            return response == null ? NotFound() : Ok(response);
            //return _todoRepository.Get(id);
        }

        //[HttpPost]
        //public IActionResult Add(Todo todo)
        //{
        //    if(todo!=null)
        //    {
        //        _todoRepository.Add(todo);
        //        return Ok();
        //    }
        //    return BadRequest();
        //}
        [HttpPost]
        public async Task<IActionResult> AddTodo(AddTodo.Commands commands)
        {
            return Ok(_mediator.Send(commands));
        }

    }
}
