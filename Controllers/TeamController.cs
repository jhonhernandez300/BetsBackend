using Bets.Domain.Consts;
using Bets.Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bets.Domain.Models;

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

        [HttpGet("GetById/{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_unitOfWork.Teams.GetById(id));
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_unitOfWork.Teams.GetAll());
        }

        [HttpGet("GetByName/{name}")]        
        public IActionResult GetByName(string name)
        {
            return Ok(_unitOfWork.Teams.Find(b => b.TeamName == name));
        }

        [HttpPost("Add")]
        public IActionResult Add(Team team)
        {
            var book = _unitOfWork.Teams.Add(team);
            _unitOfWork.Complete();
            return Ok(book);
        }

        [HttpPut("Update")]
        public Team Update(Team team)
        {
            var result = _unitOfWork.Teams.Update(team);
            _unitOfWork.Complete(); 
            return result;            
        }

        [HttpDelete("Delete")]
        public bool Delete(Team team)
        {
            _unitOfWork.Teams.Delete(team);
            _unitOfWork.Complete();
            return true;            
        }
    }
}
