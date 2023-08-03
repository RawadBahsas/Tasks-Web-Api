using TasksWebApi.Model;

namespace TasksWebApi.Services.MyTasksServices
{
    public interface IMyTasksRepository
    {
        public IEnumerable<MyTask> GetTasks();
        public void UpdateTaskReminder(int myTaskId);
        public void AddNewTask(MyTask myTask);
        public void DeleteTask(int myTaskId);

    }
}
