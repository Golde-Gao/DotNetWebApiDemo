using LancooDemoInAction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LancooDemoInAction.Services
{
    public interface ITestTaskRepository
    {
        Task<TaskView> GetTestTaskByIDAsync(int taskID);
    }
}
