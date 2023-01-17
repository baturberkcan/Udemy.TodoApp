using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.TodoApp.Dtos.WorkDtos;

namespace Udemy.TodoApp.Business.ValidationRules
{
    public class WorkUpdateDtoValidator : AbstractValidator<WorkUpdateDto>
    {
        public WorkUpdateDtoValidator()
        {
            RuleFor(x => x.Defination).NotEmpty().WithMessage("defination alanı boş geçilemez");
            RuleFor(x => x.Id).NotEmpty(); 
        }
    }
}
