using System;
using Data;

namespace Service;

public class TaskService
{
    private TaskRepository _taskRepository = new TaskRepository();

    public void AddTask(Task task)
    {
        _taskRepository.Add(task);
    }
    public void DeleteTask(int id)
    {
        _taskRepository.Delete(id);
    }
    public List<Task> GetAllTasks()
    {
        return _taskRepository.GetAll();
    }
}
