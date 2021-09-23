using LancooDemoInAction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LancooDemoInAction.Helpers;
using LancooDemoInAction.ViewModelParameter;

namespace LancooDemoInAction.Services
{
    public interface ITestTaskRepository
    {
        Task<TaskView> GetTestTaskByIdAsync(int taskId);
        Task<PagedList<TaskView>> GetCompaniesAsync(TestTaskViewModelParameter parameters);
    }
}
