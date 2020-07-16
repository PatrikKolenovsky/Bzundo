using System.Collections;
using System.Collections.Generic;
using BzundoApi.Models;
using BzundoApi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BzundoApi.Controllers
{
    [Route("api/cmd")]
    [ApiController]
    public class BzundoCmdController : ControllerBase
    {
        private readonly IBzundoApiRepo _repo;
        public BzundoCmdController(IBzundoApiRepo repo)
        {
            _repo = repo;
        }
        
        //GET api/cmd    
        [HttpGet]
        public ActionResult<IEnumerable<BzundoCmd>> GetAllCommands()
        {
            var cmdItems = _repo.GetAppCommands();
            return Ok(cmdItems);
        }
        
        //GET api/cmd/{id}
        [HttpGet("{id}")]
        public ActionResult<BzundoCmd> GetCommandById(int id)
        {
            var cmdItem = _repo.GetCommandById();
            return Ok(cmdItem);
        }
    }
}