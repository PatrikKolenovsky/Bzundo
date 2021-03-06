﻿using System.Collections.Generic;
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
        public ActionResult<IEnumerable<CommandReadDto>> GetAllCommands()
        {
            var commandItem = _repo.GetAllCommands();
            return Ok(_mapper.Map<IEnumerable<CommandReadDto>>(commandItem));
        }

        //GET api/cmd/{id}
        [HttpGet("{id}", Name = "GetCommandById")]
        public ActionResult<CommandReadDto> GetCommandById(int id)
        {
            var commandItem = _repo.GetCommandById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<CommandReadDto>(commandItem));
            }
            return NotFound();
        }
        
        //POST api/commands
        [HttpPost]
        public ActionResult<CommandReadDto> CreateCommand(CommandCreateDto commandCreateDto)
        {
            var commandModel = _mapper.Map<BzundoCmd>(commandCreateDto);
            _repo.CreateCommand(commandModel);
            _repo.SaveChanges();

            var commandReadDto = _mapper.Map<CommandReadDto>(commandModel);

            return CreatedAtRoute(nameof(GetCommandById), new {Id = commandReadDto.Id}, commandReadDto);
            // return Ok(commandReadDto);
        }
    }
}