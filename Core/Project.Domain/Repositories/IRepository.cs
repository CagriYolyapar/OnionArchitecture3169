using Project.Domain.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domain.Repositories
{
    public interface IRepository<T> where T: BaseEntity
    {

    }
}
