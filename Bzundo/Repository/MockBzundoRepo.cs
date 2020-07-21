using System.Collections.Generic;
using Bzundo.Models;

namespace Bzundo.Repository
{
    public class MockBzundoRepo : IBzundoRepo
    {
        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<BzundoCmd> GetAllCommands()
        {
            // BzundoCmd cmd1 = new BzundoCmd(0, "Boil an egg", "Boil water", "Kettle");
            // BzundoCmd cmd2 = new BzundoCmd(1, "Prepare sausage", "Boil sausage", "Kettle");
            // BzundoCmd cmd3 = new BzundoCmd(2, "Mix ingredients", "Finish", "Plate");
            var commands = new List<BzundoCmd>();
            // commands.Add(cmd1);
            // commands.Add(cmd2);
            // commands.Add(cmd3);
            return commands;
        }
        
        public BzundoCmd GetCommandById(int id)
        {
            return new BzundoCmd();
        }

        public void CreateCommand(BzundoCmd cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}