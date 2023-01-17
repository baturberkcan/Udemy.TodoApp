using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.TodoApp.Dtos.Interfaces;

namespace Udemy.TodoApp.Dtos.WorkDtos
{
    public class WorkListDto: IDto
    {
        public int Id { get; set; }
        public string Defination { get; set; }
        public bool IsCompleted { get; set; }
    }
}
