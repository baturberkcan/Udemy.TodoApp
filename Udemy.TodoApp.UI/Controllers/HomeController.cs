﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using System.Threading.Tasks;
using Udemy.TodoApp.Business.Interfaces;
using Udemy.TodoApp.Common.ResponseObject;
using Udemy.TodoApp.Dtos.WorkDtos;

namespace Udemy.TodoApp.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWorkService _workService;

        public HomeController(IWorkService workService)
        {
            _workService = workService;
        }

        public async Task<IActionResult> Index()
        {
            var response = await _workService.GetAll();
            return View(response.Data);
        }
        public IActionResult Create()
        {
            return View(new WorkCreateDto());
        }

        [HttpPost]
        public async Task<IActionResult> Create(WorkCreateDto dto)
        {
            var response = await _workService.Create(dto);
            if (response.ResponseType == ResponseType.ValidationError)
            {
                foreach (var error in response.ValidationErrors)
                {
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);

                }
                return View(dto);
            }
            else
            {
                return RedirectToAction("Index");
            }

        }
        public async Task<IActionResult> Update(int id)
        {
            var response = await _workService.GetById<WorkUpdateDto>(id);
            if (response.ResponseType == ResponseType.NotFound)
                return NotFound();
            return View(response.Data);
        }

        [HttpPost]
        public async Task<IActionResult> Update(WorkUpdateDto dto)
        {
            var response = await _workService.update(dto);
            if (response.ResponseType == ResponseType.ValidationError)
            {
                foreach (var error in response.ValidationErrors)
                {
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                }
                return View(dto);
            }
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Remove(int id)
        {
            var response = await _workService.remove(id);
            if (response.ResponseType == ResponseType.NotFound)
                return NotFound();
            return RedirectToAction("Index");
        }

        public IActionResult NotFound(int code)
        {
            return  View();
        }
    }
}
