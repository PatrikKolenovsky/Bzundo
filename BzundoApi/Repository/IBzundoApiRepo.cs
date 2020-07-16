using System.Collections.Generic;
using BzundoApi.Models;

namespace BzundoApi.Repository
{
    public interface IBzundoApiRepo
    {
        IEnumerable<BzundoCmd> GetAppCommands();
        BzundoCmd GetCommandById();
    }
}