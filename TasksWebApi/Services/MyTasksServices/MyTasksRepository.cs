using Azure.Core.Pipeline;
using TasksWebApi.Data;
using TasksWebApi.Model;

namespace TasksWebApi.Services.MyTasksServices
{
    
    public class MyTasksRepository : IMyTasksRepository
    {
        private readonly ApplicationDbContext _db;
        public MyTasksRepository(ApplicationDbContext applicationDbContext)
        {
            _db = applicationDbContext;
        }

        public IEnumerable<MyTask> GetTasks()
        {
            return _db.MyTasks;
        }

        public void UpdateTaskReminder(int myTaskId)
        {
            var myTask = _db.MyTasks.Find(myTaskId);
            myTask.Reminder = !myTask.Reminder;
            _db.SaveChanges();
        }

        public void AddNewTask(MyTask myTask)
        {
            _db.MyTasks.Add(myTask);
            _db.SaveChanges();
        }

        public void DeleteTask(int myTaskId)
        {
            _db.MyTasks.Remove(_db.MyTasks.Find(myTaskId));
            _db.SaveChanges();
        }
    }
}
