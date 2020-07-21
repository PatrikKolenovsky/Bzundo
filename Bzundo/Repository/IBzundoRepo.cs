﻿using System.Collections.Generic;
using Bzundo.Models;

namespace Bzundo.Repository
{
    public interface IBzundoRepo
    {
        IEnumerable<BzundoCmd> GetAllCommands();
        BzundoCmd GetCommandById(int id);
    }
}