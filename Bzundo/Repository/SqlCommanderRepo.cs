using System;
using System.Collections.Generic;
using System.Linq;
using Bzundo.Models;

namespace Bzundo.Repository
{
    public class SqlCommanderRepo : IBzundoRepo
    {
        private readonly BzundoContext _context;

        public SqlCommanderRepo(BzundoContext context)
        {
            _context = context;
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public IEnumerable<BzundoCmd> GetAllCommands()
        {
            return _context.Commands.ToList();
        }

        public BzundoCmd GetCommandById(int id)
        {
            return _context.Commands.FirstOrDefault(p => p.Id == id);
        }

        public void CreateCommand(BzundoCmd cmd)
        {
            if (cmd == null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }

            _context.Commands.Add(cmd);
        }
    }
}