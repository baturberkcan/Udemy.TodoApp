using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.TodoApp.DataAccess.Interfaces;
using Udemy.TodoApp.Entities.Domains;

namespace Udemy.TodoApp.DataAccess.UnitofWork
{
    public interface IUow
    {
        IRepository<T> GetRepository<T>() where T : BaseEntity; 

        Task SaveChanges();
    }
}
