using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesTask.Services.Abstractions
{
    public interface IInstanceService<T> where T : class
    {
        IEnumerable<T> GetInstances();
    }
}
