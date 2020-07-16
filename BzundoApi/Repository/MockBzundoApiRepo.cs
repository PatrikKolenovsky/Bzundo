using System.Collections.Generic;
using BzundoApi.Models;

namespace BzundoApi.Repository
{
    public class MockBzundoApiRepo : IBzundoApiRepo
    {
        public IEnumerable<BzundoCmd> GetAppCommands()
        {
            BzundoCmd cmd1 = new BzundoCmd(0, "Boil an egg", "Boil water", "Kettle");
            BzundoCmd cmd2 = new BzundoCmd(1, "Prepare sausage", "Boil sausage", "Kettle");
            BzundoCmd cmd3 = new BzundoCmd(2, "Mix ingredients", "Finish", "Plate");
            var commands = new List<BzundoCmd>();
            commands.Add(cmd1);
            commands.Add(cmd2);
            commands.Add(cmd3);
            return commands;
        }
        
        public BzundoCmd GetCommandById()
        {
            return new BzundoCmd(0, "Boil an egg", "Boil water", "Kettle and pan");
        }
    }
}