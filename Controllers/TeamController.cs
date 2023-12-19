using Bets.Domain.Consts;
using Bets.Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public TeamController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        //[HttpGet]
        //public IActionResult GetById()
        //{
        //    return Ok(_unitOfWork.Teams.GetById(1));
        //}

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_unitOfWork.Teams.GetAll());
        }

        //[HttpGet("GetByName")]
        //public IActionResult GetByName()
        //{
        //    return Ok(_unitOfWork.Teams.Find(b => b.TeamName == "New Book", new[] { "Author" }));
        //}

        //[HttpGet("GetAllWithAuthors")]
        //public IActionResult GetAllWithAuthors()
        //{
        //    return Ok(_unitOfWork.Books.FindAll(b => b.Title.Contains("New Book"), new[] { "Author" }));
        //}

        //[HttpGet("GetOrdered")]
        //public IActionResult GetOrdered()
        //{
        //    return Ok(_unitOfWork.Teams.FindAll(b => b.Title.Contains("New Book"), null, null, b => b.Id, OrderBy.Descending));
        //}

        //[HttpPost("Add")]
        //public IActionResult Add()
        //{
        //    var book = _unitOfWork.Teams.Add(new Book { Title = "Test 4", AuthorId = 1 });
        //    _unitOfWork.Complete();
        //    return Ok(book);
        //}
    }
}
