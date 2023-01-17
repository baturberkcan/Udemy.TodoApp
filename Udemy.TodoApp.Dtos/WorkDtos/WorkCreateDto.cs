using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.TodoApp.Dtos.Interfaces;

namespace Udemy.TodoApp.Dtos.WorkDtos
{
    public class WorkCreateDto: IDto
    {
        //[Required(ErrorMessage ="Defination is required")]
        public string Defination { get; set; }
        public bool IsCompleted { get; set; }
    }
}
