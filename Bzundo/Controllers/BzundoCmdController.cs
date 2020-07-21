using System.Collections.Generic;
using AutoMapper;
using Bzundo.DTOS;
using Microsoft.AspNetCore.Mvc;
using dto = Bzundo.Models;
using Bzundo.Models;
using Bzundo.Repository;

namespace Bzundo.Controllers
{
    [Route("api/cmd")]
    [ApiController]
    public class BzundoCmdController : ControllerBase
    {
        private readonly IBzundoRepo _repo;
        private readonly IMapper _mapper;

        public BzundoCmdController(IBzundoRepo repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        //GET api/cmd    
        [HttpGet]
        public ActionResult<IEnumerable<BzundoCmd>> GetAllCommands()
        {
            var cmdItems = _repo.GetAllCommands();
            return Ok(cmdItems);
        }

        //GET api/cmd/{id}
        [HttpGet("{id}")]
        public ActionResult<CommandReadDto> GetCommandById(int id)
        {
            var commandItem = _repo.GetCommandById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<CommandReadDto>(commandItem));
            }
            return NotFound();
        }
    }
}