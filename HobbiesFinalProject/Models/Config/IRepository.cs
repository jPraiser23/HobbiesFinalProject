using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HobbiesFinalProject.Models.Config
{
    interface IRepository<T> where T : class
    {
        IEnumerable<T> List();
        T Get(int id);
    }
}
