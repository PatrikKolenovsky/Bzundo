using System.Collections.Generic;
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

        public BzundoCmdController(IBzundoRepo repo)
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
            // var cmd = MySqlDatabase.Connection.CreateCommand();
            // cmd.CommandText = @"SELECT * from commands";
            // MySqlDataReader rdr = cmd.ExecuteReader();
            // string ret = "";
            // while (rdr.Read())
            // {
            //     ret = String.Concat(ret, (rdr[0] + " -- " + rdr[1]));
            // }
            //
            // rdr.Close();
            return Ok(1);
        }
    }
}