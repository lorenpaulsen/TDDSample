using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServiceClient.Core.Data
{
    public interface IReadOnlyRepository<T>
    {
        IEnumerable<T> GetAll();
    }
}
