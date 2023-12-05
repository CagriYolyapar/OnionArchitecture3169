using Project.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.Managers
{
    public interface IManager<T> where T : BaseDTO
    {
    }
}
