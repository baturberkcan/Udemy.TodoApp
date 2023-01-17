using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.TodoApp.Dtos.Interfaces;

namespace Udemy.TodoApp.Dtos.WorkDtos
{
    public class WorkUpdateDto : IDto
    {
        // [Range(1, int.MaxValue, ErrorMessage = "Id isrequired")]
        public int Id { get; set; }
        // [Required(ErrorMessage = "Defination is required")]
        public string Defination { get; set; }
        public bool IsCompleted { get; set; }
    }
}
