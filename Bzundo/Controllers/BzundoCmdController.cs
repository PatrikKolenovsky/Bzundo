using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using dto = Bzundo.Models;
using System.Collections.Generic;
using Bzundo.Models;
using Bzundo.Repository;
using Microsoft.AspNetCore.Mvc;
using MySqlConnector;
using Microsoft.Extensions.Configuration;
using MySqlCommand = MySql.Data.MySqlClient.MySqlCommand;
using MySqlDataReader = MySql.Data.MySqlClient.MySqlDataReader;

namespace Bzundo.Controllers
{
    [Route("api/cmd")]
    [ApiController]
    public class BzundoCmdController : ControllerBase
    {
        private MySqlDatabase MySqlDatabase { get; set; }
        private readonly IBzundoRepo _repo;

        public BzundoCmdController(IBzundoRepo repo, MySqlDatabase mySqlDatabase)
        {
            _repo = repo;
            MySqlDatabase = mySqlDatabase;
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
            var cmd = MySqlDatabase.Connection.CreateCommand();
            cmd.CommandText = @"SELECT * from commands";
            MySqlDataReader rdr = cmd.ExecuteReader();
            string ret = "";
            while (rdr.Read())
            {
                ret = String.Concat(ret, (rdr[0] + " -- " + rdr[1]));
            }

            rdr.Close();
            return Ok(ret);
        }
    }
}