using System;

namespace Data;

public class TaskRepository
{
    private List<Task> _tasks = new List<Task>();

    public void Add(Task task)
    {
        _tasks.Add(task);
    }
    public void Delete(int id)
    {
        var task = _tasks.FirstOrDefault(x => x.Id == id);
        if (task != null)
        {
            _tasks.Remove(task);
        }
    }
    public List<Task> GetAll()
    {
        return _tasks;
    }
}


