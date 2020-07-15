using System.Collections.Generic;

namespace BzundoApi.Repository
{
    public interface IBzundoApiRepo
    {
        IEnumerable<Models.BzundoCmd> GetAppCommands();
        Models.BzundoCmd GetCommandById();
    }
}