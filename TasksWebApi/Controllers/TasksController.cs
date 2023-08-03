using Azure;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Reflection.Metadata.Ecma335;
using System.Text.Json;
using System.Threading.Tasks;
using TasksWebApi.Model;
using TasksWebApi.Services.MyTasksServices;

namespace TasksWebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly IMyTasksRepository _MyTasksRepository;
        public TasksController(IMyTasksRepository myTasksRepository)
        {
            _MyTasksRepository = myTasksRepository;
        }
        //[HttpGet(Name = "GetTasks")]
        //public string Get()
        //{
        //    return JsonSerializer.Serialize(System.IO.File.ReadAllText(@"./JsonDataSample/json.json"));            
        //}

        //[HttpGet(Name = "GetTasks")]
        //public object Get()
        //{
        //    string json = System.IO.File.ReadAllText(@"./JsonDataSample/json.json");
        //    //object obj = JsonConvert.DeserializeObject<Dictionary<string, string>(json);
        //    //= JsonSerializer.Deserialize(json, t);

        //    return json;
        //    //IEnumerable<Task> tasks = JsonSerializer.Deserialize<IEnumerable<Task>>(System.IO.File.ReadAllText(@"./JsonDataSample/json.json"));

        //    //return tasks;

        //    //string allText = System.IO.File.ReadAllText(@"./JsonDataSample/json.json");

        //    //object jsonObject = JsonConvert.SerializeObject(allText);
        //    //return jsonObject;
        //}

        [HttpGet(Name = "GetTasks")]
        public IEnumerable<MyTask> Get()
        {
            return _MyTasksRepository.GetTasks();
        }

        [HttpPut(Name = "UpdateMyTask")]
        public void UpdateMyTask(int taskId)
        {
            _MyTasksRepository.UpdateTaskReminder(taskId);
        }

        [HttpDelete(Name = "DeleteMyTask")]
        public void DeleteMyTask(int taskId)
        {
            _MyTasksRepository.DeleteTask(taskId);
        }

        [HttpPost(Name = "AddMyTask")]
        public void AddMyTask(MyTask task)
        {
            _MyTasksRepository.AddNewTask(task);
        }
    }
}
