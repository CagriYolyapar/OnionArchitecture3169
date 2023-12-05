using Project.Domain.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domain.Entities.Concretes
{
    public class Category:BaseEntity
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }
        //Relational Properties
    }
}
