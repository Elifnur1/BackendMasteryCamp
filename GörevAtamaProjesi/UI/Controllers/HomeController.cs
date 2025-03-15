using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Service;
using UI.Models;

namespace UI.Controllers;

public class HomeController : Controller
{
    private readonly TaskService _taskService;
    public IActionResult Index()
    {
        List<Task> tasks = _taskService.GetAllTasks();
        return View();
    }
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Create(Task task)
    {
        if (ModelState.IsValid)
        {
            _taskService.AddTask(task);
            return RedirectToAction("Index");
        }
        return View(task);
    }
    public IActionResult Delete(int id)
    {
        _taskService.DeleteTask(id);
        return RedirectToAction("Index");
    }

}
