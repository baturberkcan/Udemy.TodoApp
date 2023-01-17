using AutoMapper;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.TodoApp.Business.Interfaces;
using Udemy.TodoApp.Business.Mappings.AutoMapper;
using Udemy.TodoApp.Business.Services;
using Udemy.TodoApp.Business.ValidationRules;
using Udemy.TodoApp.DataAccess.Context;
using Udemy.TodoApp.DataAccess.UnitofWork;
using Udemy.TodoApp.Dtos.WorkDtos;

namespace Udemy.TodoApp.Business.DependencyResolvers.Microsoft
{
    public static class DependencyExtension
    {
        public static void AddDependencies(this IServiceCollection services)
        {
            services.AddDbContext<TodoContext>(opt =>
            {

                opt.UseSqlServer("Server=localhost;Database=ToDoDb;User Id=sa;Password=Bs!257125;");
                opt.LogTo(Console.WriteLine, LogLevel.Information);
            });
            var configration = new MapperConfiguration(opt => opt.AddProfile(new WorkProfile()));

            var mapper = configration.CreateMapper();
            services.AddSingleton(mapper);


            services.AddScoped<IUow, Uow>();
            services.AddScoped<IWorkService, WorkService>();
            services.AddTransient<IValidator<WorkCreateDto>,WorkCreateDtoValidator>();
            services.AddTransient<IValidator<WorkUpdateDto>, WorkUpdateDtoValidator>();

        }
    }
}
