﻿using System.Collections.Generic;
using Bzundo.Models;

namespace Bzundo.Repository
{
    public interface IBzundoRepo
    {
        bool SaveChanges();
        IEnumerable<BzundoCmd> GetAllCommands();
        BzundoCmd GetCommandById(int id);
        void CreateCommand(BzundoCmd cmd);
    }
}