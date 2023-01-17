using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.TodoApp.Common.ResponseObject;
using Udemy.TodoApp.Dtos.Interfaces;
using Udemy.TodoApp.Dtos.WorkDtos;

namespace Udemy.TodoApp.Business.Interfaces
{
    public interface IWorkService
    {
        Task<IResponse<List<WorkListDto>>> GetAll();
        Task<IResponse<WorkCreateDto>> Create(WorkCreateDto dto);
        Task<IResponse<IDto>> GetById<IDto>(int id);

        Task<IResponse> remove(int id);

        Task<IResponse<WorkUpdateDto>> update(WorkUpdateDto dto);
    }
}
