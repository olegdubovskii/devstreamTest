using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using VehiclesTask.Services.Abstractions;

namespace VehiclesTask.Services.Implementations
{
    public class InstanceService<T> : IInstanceService<T> where T : class
    {
        public IEnumerable<T> GetInstances()
        {
            var specifiedType = typeof(T);
            return AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(assembly => assembly.GetTypes())
                .Where(t => t.IsClass && !t.IsAbstract && t.IsSubclassOf(specifiedType))
                .Select(t => (T)Activator.CreateInstance(t));
        }
    }
}
